namespace WindowsFormsApp11
{
    partial class Form1
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
            this.picSnakeOrb = new System.Windows.Forms.PictureBox();
            this.pgbLeprechaunLife = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picGameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouWon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeadSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnakeOrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp11.Properties.Resources.ATLASSEED_3;
            this.pictureBox1.Location = new System.Drawing.Point(285, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // picOrb
            // 
            this.picOrb.BackColor = System.Drawing.Color.Transparent;
            this.picOrb.Image = global::WindowsFormsApp11.Properties.Resources.ATLASSEED_3;
            this.picOrb.Location = new System.Drawing.Point(285, 487);
            this.picOrb.Name = "picOrb";
            this.picOrb.Size = new System.Drawing.Size(31, 31);
            this.picOrb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrb.TabIndex = 11;
            this.picOrb.TabStop = false;
            // 
            // btnBeginBattle
            // 
            this.btnBeginBattle.BackColor = System.Drawing.Color.Azure;
            this.btnBeginBattle.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginBattle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBeginBattle.Location = new System.Drawing.Point(17, 10);
            this.btnBeginBattle.Name = "btnBeginBattle";
            this.btnBeginBattle.Size = new System.Drawing.Size(276, 52);
            this.btnBeginBattle.TabIndex = 14;
            this.btnBeginBattle.Text = "Begin Battle";
            this.btnBeginBattle.UseVisualStyleBackColor = false;
            this.btnBeginBattle.Click += new System.EventHandler(this.btnBeginBattle_Click_1);
            // 
            // pgbSnakeLife
            // 
            this.pgbSnakeLife.BackColor = System.Drawing.Color.Green;
            this.pgbSnakeLife.Enabled = false;
            this.pgbSnakeLife.ForeColor = System.Drawing.Color.Red;
            this.pgbSnakeLife.Location = new System.Drawing.Point(698, 263);
            this.pgbSnakeLife.Name = "pgbSnakeLife";
            this.pgbSnakeLife.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pgbSnakeLife.RightToLeftLayout = true;
            this.pgbSnakeLife.Size = new System.Drawing.Size(169, 20);
            this.pgbSnakeLife.Step = 1;
            this.pgbSnakeLife.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbSnakeLife.TabIndex = 18;
            this.pgbSnakeLife.Visible = false;
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.LightCyan;
            this.btnFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFire.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.Color.DarkRed;
            this.btnFire.Location = new System.Drawing.Point(193, 327);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 31);
            this.btnFire.TabIndex = 17;
            this.btnFire.Text = "Fire!!";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Visible = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click_1);
            // 
            // picYouWon
            // 
            this.picYouWon.BackColor = System.Drawing.Color.Transparent;
            this.picYouWon.Image = global::WindowsFormsApp11.Properties.Resources.youwon11;
            this.picYouWon.Location = new System.Drawing.Point(239, 58);
            this.picYouWon.Name = "picYouWon";
            this.picYouWon.Size = new System.Drawing.Size(405, 277);
            this.picYouWon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYouWon.TabIndex = 16;
            this.picYouWon.TabStop = false;
            this.picYouWon.Visible = false;
            // 
            // picDeadSnake
            // 
            this.picDeadSnake.BackColor = System.Drawing.Color.Transparent;
            this.picDeadSnake.Image = global::WindowsFormsApp11.Properties.Resources.snakes_transparent_blue;
            this.picDeadSnake.Location = new System.Drawing.Point(602, 553);
            this.picDeadSnake.Name = "picDeadSnake";
            this.picDeadSnake.Size = new System.Drawing.Size(366, 38);
            this.picDeadSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeadSnake.TabIndex = 15;
            this.picDeadSnake.TabStop = false;
            this.picDeadSnake.Visible = false;
            // 
            // picLiveSnake
            // 
            this.picLiveSnake.BackColor = System.Drawing.Color.Transparent;
            this.picLiveSnake.Image = global::WindowsFormsApp11.Properties.Resources.snakes_transparent_blue;
            this.picLiveSnake.Location = new System.Drawing.Point(650, 277);
            this.picLiveSnake.Name = "picLiveSnake";
            this.picLiveSnake.Size = new System.Drawing.Size(277, 315);
            this.picLiveSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLiveSnake.TabIndex = 10;
            this.picLiveSnake.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WindowsFormsApp11.Properties.Resources.pc5raky9i;
            this.pictureBox2.Location = new System.Drawing.Point(-7, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 480);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::WindowsFormsApp11.Properties.Resources.leppyclip2;
            this.pictureBox3.Location = new System.Drawing.Point(144, 385);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(275, 207);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // picSnakeOrb
            // 
            this.picSnakeOrb.BackColor = System.Drawing.Color.Transparent;
            this.picSnakeOrb.Image = global::WindowsFormsApp11.Properties.Resources.marbles_clipart_red_pencil_and_in_color_marbles_clipart_red_clipart_qXjLNq;
            this.picSnakeOrb.Location = new System.Drawing.Point(682, 407);
            this.picSnakeOrb.Name = "picSnakeOrb";
            this.picSnakeOrb.Size = new System.Drawing.Size(28, 24);
            this.picSnakeOrb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSnakeOrb.TabIndex = 20;
            this.picSnakeOrb.TabStop = false;
            this.picSnakeOrb.Visible = false;
            // 
            // pgbLeprechaunLife
            // 
            this.pgbLeprechaunLife.BackColor = System.Drawing.Color.Green;
            this.pgbLeprechaunLife.Enabled = false;
            this.pgbLeprechaunLife.ForeColor = System.Drawing.Color.Red;
            this.pgbLeprechaunLife.Location = new System.Drawing.Point(193, 364);
            this.pgbLeprechaunLife.Maximum = 70;
            this.pgbLeprechaunLife.Name = "pgbLeprechaunLife";
            this.pgbLeprechaunLife.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pgbLeprechaunLife.RightToLeftLayout = true;
            this.pgbLeprechaunLife.Size = new System.Drawing.Size(100, 15);
            this.pgbLeprechaunLife.Step = 1;
            this.pgbLeprechaunLife.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbLeprechaunLife.TabIndex = 21;
            this.pgbLeprechaunLife.Visible = false;
            this.pgbLeprechaunLife.Click += new System.EventHandler(this.pgbLeprechaunLife_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 160;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picGameOver
            // 
            this.picGameOver.BackColor = System.Drawing.Color.Transparent;
            this.picGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGameOver.Image = global::WindowsFormsApp11.Properties.Resources.SlimWarmBluemorphobutterfly_max_1mb;
            this.picGameOver.Location = new System.Drawing.Point(239, 58);
            this.picGameOver.Name = "picGameOver";
            this.picGameOver.Size = new System.Drawing.Size(461, 277);
            this.picGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGameOver.TabIndex = 22;
            this.picGameOver.TabStop = false;
            this.picGameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp11.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 598);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouWon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeadSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSnakeOrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameOver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.PictureBox picSnakeOrb;
        private System.Windows.Forms.ProgressBar pgbLeprechaunLife;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picGameOver;
    }
}

