namespace BattleShipGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPlayer = new System.Windows.Forms.Label();
            this.txtEnemy = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.Label();
            this.enemyMove = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.Label();
            this.EnemyLocationListBox = new System.Windows.Forms.ComboBox();
            this.w2 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.EnemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.btnAttack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlayer.ForeColor = System.Drawing.Color.White;
            this.txtPlayer.Location = new System.Drawing.Point(294, 105);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(37, 30);
            this.txtPlayer.TabIndex = 0;
            this.txtPlayer.Text = "00";
            // 
            // txtEnemy
            // 
            this.txtEnemy.AutoSize = true;
            this.txtEnemy.BackColor = System.Drawing.Color.Transparent;
            this.txtEnemy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEnemy.ForeColor = System.Drawing.Color.White;
            this.txtEnemy.Location = new System.Drawing.Point(754, 105);
            this.txtEnemy.Name = "txtEnemy";
            this.txtEnemy.Size = new System.Drawing.Size(37, 30);
            this.txtEnemy.TabIndex = 1;
            this.txtEnemy.Text = "00";
            // 
            // txtRounds
            // 
            this.txtRounds.AutoSize = true;
            this.txtRounds.BackColor = System.Drawing.Color.Transparent;
            this.txtRounds.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRounds.ForeColor = System.Drawing.Color.White;
            this.txtRounds.Location = new System.Drawing.Point(395, 168);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(108, 30);
            this.txtRounds.TabIndex = 2;
            this.txtRounds.Text = "Round:10";
            // 
            // enemyMove
            // 
            this.enemyMove.AutoSize = true;
            this.enemyMove.BackColor = System.Drawing.Color.Transparent;
            this.enemyMove.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enemyMove.ForeColor = System.Drawing.Color.White;
            this.enemyMove.Location = new System.Drawing.Point(751, 28);
            this.enemyMove.Name = "enemyMove";
            this.enemyMove.Size = new System.Drawing.Size(40, 30);
            this.enemyMove.TabIndex = 3;
            this.enemyMove.Text = "A1";
            // 
            // txtHelp
            // 
            this.txtHelp.AutoSize = true;
            this.txtHelp.BackColor = System.Drawing.Color.Transparent;
            this.txtHelp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHelp.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtHelp.Location = new System.Drawing.Point(21, 563);
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(369, 20);
            this.txtHelp.TabIndex = 4;
            this.txtHelp.Text = "1- Click on 3 different locations from above to start";
            // 
            // EnemyLocationListBox
            // 
            this.EnemyLocationListBox.BackColor = System.Drawing.Color.SeaGreen;
            this.EnemyLocationListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnemyLocationListBox.DropDownWidth = 95;
            this.EnemyLocationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnemyLocationListBox.FormattingEnabled = true;
            this.EnemyLocationListBox.Location = new System.Drawing.Point(145, 28);
            this.EnemyLocationListBox.Name = "EnemyLocationListBox";
            this.EnemyLocationListBox.Size = new System.Drawing.Size(91, 33);
            this.EnemyLocationListBox.TabIndex = 5;
            // 
            // w2
            // 
            this.w2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w2.Location = new System.Drawing.Point(170, 234);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(66, 61);
            this.w2.TabIndex = 6;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = true;
            this.w2.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // x2
            // 
            this.x2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x2.Location = new System.Drawing.Point(170, 314);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(66, 61);
            this.x2.TabIndex = 6;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // w3
            // 
            this.w3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w3.Location = new System.Drawing.Point(243, 234);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(66, 61);
            this.w3.TabIndex = 6;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = true;
            this.w3.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // w4
            // 
            this.w4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w4.Location = new System.Drawing.Point(324, 234);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(66, 61);
            this.w4.TabIndex = 6;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = true;
            this.w4.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // x4
            // 
            this.x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x4.Location = new System.Drawing.Point(324, 314);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(66, 61);
            this.x4.TabIndex = 7;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = true;
            this.x4.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // x3
            // 
            this.x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x3.Location = new System.Drawing.Point(243, 314);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(66, 61);
            this.x3.TabIndex = 8;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = true;
            this.x3.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // x1
            // 
            this.x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x1.Location = new System.Drawing.Point(89, 314);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(66, 61);
            this.x1.TabIndex = 9;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // w1
            // 
            this.w1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w1.Location = new System.Drawing.Point(89, 234);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(66, 61);
            this.w1.TabIndex = 10;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = true;
            this.w1.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // z4
            // 
            this.z4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z4.Location = new System.Drawing.Point(324, 470);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(66, 61);
            this.z4.TabIndex = 15;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = true;
            this.z4.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // z3
            // 
            this.z3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z3.Location = new System.Drawing.Point(243, 470);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(66, 61);
            this.z3.TabIndex = 16;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = true;
            this.z3.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // z1
            // 
            this.z1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z1.Location = new System.Drawing.Point(89, 470);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(66, 61);
            this.z1.TabIndex = 17;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = true;
            this.z1.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // y1
            // 
            this.y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y1.Location = new System.Drawing.Point(89, 390);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(66, 61);
            this.y1.TabIndex = 18;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = true;
            this.y1.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // y4
            // 
            this.y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y4.Location = new System.Drawing.Point(324, 390);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(66, 61);
            this.y4.TabIndex = 11;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = true;
            this.y4.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // y3
            // 
            this.y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y3.Location = new System.Drawing.Point(243, 390);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(66, 61);
            this.y3.TabIndex = 12;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = true;
            this.y3.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // z2
            // 
            this.z2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z2.Location = new System.Drawing.Point(170, 470);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(66, 61);
            this.z2.TabIndex = 13;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = true;
            this.z2.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // y2
            // 
            this.y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y2.Location = new System.Drawing.Point(170, 390);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(66, 61);
            this.y2.TabIndex = 14;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = true;
            this.y2.Click += new System.EventHandler(this.PlayerPositionsButtonEvent);
            // 
            // d4
            // 
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d4.Location = new System.Drawing.Point(744, 470);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(66, 61);
            this.d4.TabIndex = 31;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            // 
            // d3
            // 
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d3.Location = new System.Drawing.Point(663, 470);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(66, 61);
            this.d3.TabIndex = 32;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // d1
            // 
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d1.Location = new System.Drawing.Point(509, 470);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(66, 61);
            this.d1.TabIndex = 33;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Location = new System.Drawing.Point(509, 390);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(66, 61);
            this.c1.TabIndex = 34;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // c4
            // 
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c4.Location = new System.Drawing.Point(744, 390);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(66, 61);
            this.c4.TabIndex = 27;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Location = new System.Drawing.Point(663, 390);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(66, 61);
            this.c3.TabIndex = 28;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d2.Location = new System.Drawing.Point(590, 470);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(66, 61);
            this.d2.TabIndex = 29;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Location = new System.Drawing.Point(590, 390);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(66, 61);
            this.c2.TabIndex = 30;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Location = new System.Drawing.Point(744, 314);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(66, 61);
            this.b4.TabIndex = 23;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Location = new System.Drawing.Point(663, 314);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(66, 61);
            this.b3.TabIndex = 24;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Location = new System.Drawing.Point(509, 314);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(66, 61);
            this.b1.TabIndex = 25;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // a1
            // 
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a1.Location = new System.Drawing.Point(509, 234);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(66, 61);
            this.a1.TabIndex = 26;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // a4
            // 
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.Location = new System.Drawing.Point(744, 234);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(66, 61);
            this.a4.TabIndex = 19;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a3.Location = new System.Drawing.Point(663, 234);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(66, 61);
            this.a3.TabIndex = 20;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Location = new System.Drawing.Point(590, 314);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(66, 61);
            this.b2.TabIndex = 21;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.Location = new System.Drawing.Point(590, 234);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(66, 61);
            this.a2.TabIndex = 22;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // EnemyPlayTimer
            // 
            this.EnemyPlayTimer.Interval = 1000;
            this.EnemyPlayTimer.Tick += new System.EventHandler(this.EnemyPlayerTimerEvent);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Transparent;
            this.btnAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAttack.ForeColor = System.Drawing.Color.Black;
            this.btnAttack.Location = new System.Drawing.Point(263, 19);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(68, 55);
            this.btnAttack.TabIndex = 35;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.AttackButtonEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BattleShipGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(880, 607);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.EnemyLocationListBox);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.enemyMove);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.txtEnemy);
            this.Controls.Add(this.txtPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle Ship Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.Label txtEnemy;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.Label enemyMove;
        private System.Windows.Forms.Label txtHelp;
        private System.Windows.Forms.ComboBox EnemyLocationListBox;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Timer EnemyPlayTimer;
        private System.Windows.Forms.Button btnAttack;
    }
}

