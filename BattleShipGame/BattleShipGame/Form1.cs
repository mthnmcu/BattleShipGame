using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BattleShipGame
{
    public partial class Form1 : Form
    {


        List<Button> PlayerPositionButton;
        List<Button> enemyPositionButtons;

        Random rand = new Random();

        int totalShips = 3;
        int round = 10;
        int playerScore;
        int enemyScore;


        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void EnemyPlayerTimerEvent(object sender, EventArgs e)
        {
            if (PlayerPositionButton.Count > 0 && round > 0)
            {
                round -= 1;

                txtRounds.Text = "Round: " + round;

                int index = rand.Next(PlayerPositionButton.Count);

                if ((string)PlayerPositionButton[index].Tag == "playerShip")
                {
                    PlayerPositionButton[index].BackgroundImage = Properties.Resources.fireIcon;
                    enemyMove.Text = PlayerPositionButton[index].Text;
                    PlayerPositionButton[index].Enabled = false;
                    PlayerPositionButton[index].BackColor = Color.DarkBlue;
                    PlayerPositionButton.RemoveAt(index);
                    enemyScore += 1;
                    txtEnemy.Text = enemyScore.ToString();
                    EnemyPlayTimer.Stop();
                }
                else
                {
                    PlayerPositionButton[index].BackgroundImage = Properties.Resources.missIcon;
                    enemyMove.Text = PlayerPositionButton[index].Text;
                    PlayerPositionButton[index].Enabled = false;
                    PlayerPositionButton[index].BackColor = Color.DarkBlue;
                    PlayerPositionButton.RemoveAt(index);
                    EnemyPlayTimer.Stop();
                }
            }

            if (round < 1 || enemyScore > 2 || playerScore > 2)
            {

                if (playerScore > enemyScore)
                {
                    MessageBox.Show("You Win!!", "Winning");
                    RestartGame();
                }
                else if (enemyScore > playerScore)
                {
                    MessageBox.Show("Haha, I sunk your battle ship", "Lost");
                    RestartGame();
                }
                else if (enemyScore == playerScore)
                {
                    MessageBox.Show("No one wins this game", "Draw");
                    RestartGame();
                }
            }
        }

        private void AttackButtonEvent(object sender, EventArgs e)
        {
            if (EnemyLocationListBox.Text != "")
            {

                var attackPosition = EnemyLocationListBox.Text.ToLower();

                int index = enemyPositionButtons.FindIndex(a => a.Name == attackPosition);

                if (enemyPositionButtons[index].Enabled && round > 0)
                {
                    round -= 1;
                    txtRounds.Text = "Round: " + round;


                    if ((string)enemyPositionButtons[index].Tag == "enemyShip")
                    {

                        enemyPositionButtons[index].Enabled = false;
                        enemyPositionButtons[index].BackgroundImage = Properties.Resources.fireIcon;
                        enemyPositionButtons[index].BackColor = Color.DarkBlue;
                        playerScore += 1;
                        txtPlayer.Text = playerScore.ToString();
                        EnemyPlayTimer.Start();

                    }
                    else
                    {
                        enemyPositionButtons[index].Enabled = false;
                        enemyPositionButtons[index].BackgroundImage = Properties.Resources.missIcon;
                        enemyPositionButtons[index].BackColor = Color.DarkBlue;
                        EnemyPlayTimer.Start();
                    }


                }


            }
            else
            {
                MessageBox.Show("Choose a location from the drop down first", "Information");
            }
        }

        private void PlayerPositionsButtonEvent(object sender, EventArgs e)
        {
            if (totalShips > 0)
            {
                var button = (Button)sender;

                button.Enabled = false;
                button.Tag = "playerShip";
                button.BackColor = Color.Orange;
                totalShips -= 1;
            }

            if (totalShips == 0)
            {
                btnAttack.Enabled = true;
                btnAttack.BackColor = Color.Red;
                btnAttack.ForeColor = Color.White;

                txtHelp.Text = "2) Now pick the attack position from the drop down";
            }
        }


        private void RestartGame()
        {


            PlayerPositionButton = new List<Button> { w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
            enemyPositionButtons = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };

            EnemyLocationListBox.Items.Clear();

            EnemyLocationListBox.Text = null;

            txtHelp.Text = "1) Click on three different locations from above to start!";


            for (int i = 0; i < enemyPositionButtons.Count; i++)
            {
                enemyPositionButtons[i].Enabled = true;
                enemyPositionButtons[i].Tag = null;
                enemyPositionButtons[i].BackColor = Color.White;
                enemyPositionButtons[i].BackgroundImage = null;
                EnemyLocationListBox.Items.Add(enemyPositionButtons[i].Text);
            }

            for (int i = 0; i < PlayerPositionButton.Count; i++)
            {
                PlayerPositionButton[i].Enabled = true;
                PlayerPositionButton[i].Tag = null;
                PlayerPositionButton[i].BackColor = Color.White;
                PlayerPositionButton[i].BackgroundImage = null;
            }

            playerScore = 0;
            enemyScore = 0;
            round = 10;
            totalShips = 3;

            txtPlayer.Text = playerScore.ToString();
            txtEnemy.Text = enemyScore.ToString();
            enemyMove.Text = "A1";

            btnAttack.Enabled = false;

            enemyLocationPicker();

        }

        private void enemyLocationPicker()
        {
            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(enemyPositionButtons.Count);

                if (enemyPositionButtons[index].Enabled == true && (string)enemyPositionButtons[index].Tag == null)
                {
                    enemyPositionButtons[index].Tag = "enemyShip";

                    Debug.WriteLine("Enemy Position: " + enemyPositionButtons[index].Text);
                }
                else
                {
                    index = rand.Next(enemyPositionButtons.Count);
                }
            }


        }
    }
}
