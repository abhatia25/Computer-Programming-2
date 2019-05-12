namespace Snakes_and_Shillelaghs
{
    partial class frmLevel2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picGameOver = new System.Windows.Forms.PictureBox();
            this.pgbLeprechaunLife = new System.Windows.Forms.ProgressBar();
            this.picSnakeOrb = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picOrb = new System.Windows.Forms.PictureBox();
            this.btnBeginBattle = new System.Windows.Forms.Button();
            this.pgbSnakeLife = new System.Windows.Forms.ProgressBar();
            this.btnFire = new System.Windows.Forms.Button();
            this.picYouWon = new System.Windows.Forms.PictureBox();
            this.picDeadSnake = new System.Windows.Forms.PictureBox();
            this.picLiveSnake = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.picDistraction1 = new System.Windows.Forms.PictureBox();
            this.lblDistraction = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picGold = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnakeOrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouWon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeadSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDistraction1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // picGameOver
            // 
            this.picGameOver.BackColor = System.Drawing.Color.Transparent;
            this.picGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGameOver.Image = global::Snakes_and_Shillelaghs.Properties.Resources.gameover;
            this.picGameOver.Location = new System.Drawing.Point(237, 53);
            this.picGameOver.Name = "picGameOver";
            this.picGameOver.Size = new System.Drawing.Size(461, 277);
            this.picGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGameOver.TabIndex = 35;
            this.picGameOver.TabStop = false;
            this.picGameOver.Visible = false;
            this.picGameOver.Click += new System.EventHandler(this.picGameOver_Click);
            // 
            // pgbLeprechaunLife
            // 
            this.pgbLeprechaunLife.BackColor = System.Drawing.Color.Green;
            this.pgbLeprechaunLife.Enabled = false;
            this.pgbLeprechaunLife.ForeColor = System.Drawing.Color.Red;
            this.pgbLeprechaunLife.Location = new System.Drawing.Point(199, 359);
            this.pgbLeprechaunLife.Maximum = 70;
            this.pgbLeprechaunLife.Name = "pgbLeprechaunLife";
            this.pgbLeprechaunLife.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pgbLeprechaunLife.RightToLeftLayout = true;
            this.pgbLeprechaunLife.Size = new System.Drawing.Size(100, 15);
            this.pgbLeprechaunLife.Step = 1;
            this.pgbLeprechaunLife.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbLeprechaunLife.TabIndex = 34;
            this.pgbLeprechaunLife.Visible = false;
            // 
            // picSnakeOrb
            // 
            this.picSnakeOrb.BackColor = System.Drawing.Color.Transparent;
            this.picSnakeOrb.Image = global::Snakes_and_Shillelaghs.Properties.Resources.red_orb;
            this.picSnakeOrb.Location = new System.Drawing.Point(688, 402);
            this.picSnakeOrb.Name = "picSnakeOrb";
            this.picSnakeOrb.Size = new System.Drawing.Size(28, 24);
            this.picSnakeOrb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSnakeOrb.TabIndex = 33;
            this.picSnakeOrb.TabStop = false;
            this.picSnakeOrb.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Snakes_and_Shillelaghs.Properties.Resources.orb;
            this.pictureBox1.Location = new System.Drawing.Point(291, 482);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // picOrb
            // 
            this.picOrb.BackColor = System.Drawing.Color.Transparent;
            this.picOrb.Image = global::Snakes_and_Shillelaghs.Properties.Resources.orb;
            this.picOrb.Location = new System.Drawing.Point(291, 482);
            this.picOrb.Name = "picOrb";
            this.picOrb.Size = new System.Drawing.Size(31, 31);
            this.picOrb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrb.TabIndex = 24;
            this.picOrb.TabStop = false;
            // 
            // btnBeginBattle
            // 
            this.btnBeginBattle.BackColor = System.Drawing.Color.Azure;
            this.btnBeginBattle.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginBattle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBeginBattle.Location = new System.Drawing.Point(33, 12);
            this.btnBeginBattle.Name = "btnBeginBattle";
            this.btnBeginBattle.Size = new System.Drawing.Size(276, 52);
            this.btnBeginBattle.TabIndex = 27;
            this.btnBeginBattle.Text = "Begin Battle";
            this.btnBeginBattle.UseVisualStyleBackColor = false;
            this.btnBeginBattle.Click += new System.EventHandler(this.btnBeginBattle_Click);
            // 
            // pgbSnakeLife
            // 
            this.pgbSnakeLife.BackColor = System.Drawing.Color.Green;
            this.pgbSnakeLife.Enabled = false;
            this.pgbSnakeLife.ForeColor = System.Drawing.Color.Red;
            this.pgbSnakeLife.Location = new System.Drawing.Point(704, 258);
            this.pgbSnakeLife.Name = "pgbSnakeLife";
            this.pgbSnakeLife.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pgbSnakeLife.RightToLeftLayout = true;
            this.pgbSnakeLife.Size = new System.Drawing.Size(169, 20);
            this.pgbSnakeLife.Step = 1;
            this.pgbSnakeLife.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbSnakeLife.TabIndex = 31;
            this.pgbSnakeLife.Visible = false;
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.LightCyan;
            this.btnFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFire.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.Color.DarkRed;
            this.btnFire.Location = new System.Drawing.Point(199, 322);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 31);
            this.btnFire.TabIndex = 30;
            this.btnFire.Text = "Fire!!";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Visible = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // picYouWon
            // 
            this.picYouWon.BackColor = System.Drawing.Color.Transparent;
            this.picYouWon.Image = global::Snakes_and_Shillelaghs.Properties.Resources.youwon1;
            this.picYouWon.Location = new System.Drawing.Point(245, 53);
            this.picYouWon.Name = "picYouWon";
            this.picYouWon.Size = new System.Drawing.Size(405, 277);
            this.picYouWon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYouWon.TabIndex = 29;
            this.picYouWon.TabStop = false;
            this.picYouWon.Visible = false;
            this.picYouWon.Click += new System.EventHandler(this.picYouWon_Click);
            // 
            // picDeadSnake
            // 
            this.picDeadSnake.BackColor = System.Drawing.Color.Transparent;
            this.picDeadSnake.Image = global::Snakes_and_Shillelaghs.Properties.Resources.snake;
            this.picDeadSnake.Location = new System.Drawing.Point(608, 548);
            this.picDeadSnake.Name = "picDeadSnake";
            this.picDeadSnake.Size = new System.Drawing.Size(366, 38);
            this.picDeadSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeadSnake.TabIndex = 28;
            this.picDeadSnake.TabStop = false;
            this.picDeadSnake.Visible = false;
            // 
            // picLiveSnake
            // 
            this.picLiveSnake.BackColor = System.Drawing.Color.Transparent;
            this.picLiveSnake.Image = global::Snakes_and_Shillelaghs.Properties.Resources.snake;
            this.picLiveSnake.Location = new System.Drawing.Point(656, 272);
            this.picLiveSnake.Name = "picLiveSnake";
            this.picLiveSnake.Size = new System.Drawing.Size(277, 315);
            this.picLiveSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLiveSnake.TabIndex = 23;
            this.picLiveSnake.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Snakes_and_Shillelaghs.Properties.Resources.pc5raky9i;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 480);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Snakes_and_Shillelaghs.Properties.Resources.leppyclip2;
            this.pictureBox3.Location = new System.Drawing.Point(150, 380);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(275, 207);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // picDistraction1
            // 
            this.picDistraction1.BackgroundImage = global::Snakes_and_Shillelaghs.Properties.Resources.bird1;
            this.picDistraction1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDistraction1.Location = new System.Drawing.Point(716, 93);
            this.picDistraction1.Name = "picDistraction1";
            this.picDistraction1.Size = new System.Drawing.Size(137, 119);
            this.picDistraction1.TabIndex = 37;
            this.picDistraction1.TabStop = false;
            this.picDistraction1.Visible = false;
            // 
            // lblDistraction
            // 
            this.lblDistraction.BackColor = System.Drawing.Color.Transparent;
            this.lblDistraction.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistraction.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDistraction.Location = new System.Drawing.Point(716, 237);
            this.lblDistraction.Name = "lblDistraction";
            this.lblDistraction.Size = new System.Drawing.Size(137, 18);
            this.lblDistraction.TabIndex = 38;
            this.lblDistraction.Text = "Distraction!";
            this.lblDistraction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDistraction.Visible = false;
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(503, 393);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 39;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(366, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 45);
            this.label1.TabIndex = 40;
            this.label1.Text = "Enter your magic number:";
            this.label1.Visible = false;
            // 
            // picGold
            // 
            this.picGold.BackColor = System.Drawing.Color.Transparent;
            this.picGold.Image = global::Snakes_and_Shillelaghs.Properties.Resources._1495750445Coins_Gold_PNG_Clip_Art;
            this.picGold.Location = new System.Drawing.Point(237, 12);
            this.picGold.Name = "picGold";
            this.picGold.Size = new System.Drawing.Size(473, 373);
            this.picGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGold.TabIndex = 41;
            this.picGold.TabStop = false;
            this.picGold.Visible = false;
            this.picGold.Click += new System.EventHandler(this.picGold_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(503, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 42;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Snakes_and_Shillelaghs.Properties.Resources.ScentedSingleFurseal_size_restricted;
            this.pictureBox4.Location = new System.Drawing.Point(320, 391);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(330, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // frmLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snakes_and_Shillelaghs.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 591);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picGold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDistraction);
            this.Controls.Add(this.picDistraction1);
            this.Controls.Add(this.picGameOver);
            this.Controls.Add(this.pgbLeprechaunLife);
            this.Controls.Add(this.picSnakeOrb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picOrb);
            this.Controls.Add(this.btnBeginBattle);
            this.Controls.Add(this.pgbSnakeLife);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.picYouWon);
            this.Controls.Add(this.picDeadSnake);
            this.Controls.Add(this.picLiveSnake);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "frmLevel2";
            this.Text = "Level2";
            this.Load += new System.EventHandler(this.frmLevel2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnakeOrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouWon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeadSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDistraction1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGameOver;
        private System.Windows.Forms.ProgressBar pgbLeprechaunLife;
        private System.Windows.Forms.PictureBox picSnakeOrb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picOrb;
        private System.Windows.Forms.Button btnBeginBattle;
        private System.Windows.Forms.ProgressBar pgbSnakeLife;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.PictureBox picYouWon;
        private System.Windows.Forms.PictureBox picDeadSnake;
        private System.Windows.Forms.PictureBox picLiveSnake;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox picDistraction1;
        private System.Windows.Forms.Label lblDistraction;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picGold;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}