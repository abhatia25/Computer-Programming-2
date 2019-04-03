namespace Snakes_and_Shillelaghs
{
    partial class frmLevel1
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
            this.btnBeginBattle = new System.Windows.Forms.Button();
            this.pgbSnakeLife = new System.Windows.Forms.ProgressBar();
            this.btnFire = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picOrb = new System.Windows.Forms.PictureBox();
            this.picYouWon = new System.Windows.Forms.PictureBox();
            this.picDeadSnake = new System.Windows.Forms.PictureBox();
            this.picLiveSnake = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouWon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeadSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBeginBattle
            // 
            this.btnBeginBattle.BackColor = System.Drawing.Color.Azure;
            this.btnBeginBattle.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginBattle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBeginBattle.Location = new System.Drawing.Point(23, 12);
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
            this.pgbSnakeLife.Location = new System.Drawing.Point(775, 393);
            this.pgbSnakeLife.Name = "pgbSnakeLife";
            this.pgbSnakeLife.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pgbSnakeLife.RightToLeftLayout = true;
            this.pgbSnakeLife.Size = new System.Drawing.Size(143, 20);
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
            this.btnFire.Location = new System.Drawing.Point(208, 350);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 31);
            this.btnFire.TabIndex = 17;
            this.btnFire.Text = "Fire!!";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Visible = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Snakes_and_Shillelaghs.Properties.Resources.ATLASSEED_3;
            this.pictureBox1.Location = new System.Drawing.Point(291, 489);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // picOrb
            // 
            this.picOrb.BackColor = System.Drawing.Color.Transparent;
            this.picOrb.Image = global::Snakes_and_Shillelaghs.Properties.Resources.ATLASSEED_3;
            this.picOrb.Location = new System.Drawing.Point(291, 489);
            this.picOrb.Name = "picOrb";
            this.picOrb.Size = new System.Drawing.Size(31, 31);
            this.picOrb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrb.TabIndex = 11;
            this.picOrb.TabStop = false;
            // 
            // picYouWon
            // 
            this.picYouWon.BackColor = System.Drawing.Color.Transparent;
            this.picYouWon.Image = global::Snakes_and_Shillelaghs.Properties.Resources.youwon1;
            this.picYouWon.Location = new System.Drawing.Point(289, 2);
            this.picYouWon.Name = "picYouWon";
            this.picYouWon.Size = new System.Drawing.Size(545, 385);
            this.picYouWon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYouWon.TabIndex = 16;
            this.picYouWon.TabStop = false;
            this.picYouWon.Visible = false;
            this.picYouWon.Click += new System.EventHandler(this.picYouWon_Click);
            // 
            // picDeadSnake
            // 
            this.picDeadSnake.BackColor = System.Drawing.Color.Transparent;
            this.picDeadSnake.Image = global::Snakes_and_Shillelaghs.Properties.Resources.snakes_transparent_blue;
            this.picDeadSnake.Location = new System.Drawing.Point(727, 561);
            this.picDeadSnake.Name = "picDeadSnake";
            this.picDeadSnake.Size = new System.Drawing.Size(232, 33);
            this.picDeadSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeadSnake.TabIndex = 15;
            this.picDeadSnake.TabStop = false;
            this.picDeadSnake.Visible = false;
            // 
            // picLiveSnake
            // 
            this.picLiveSnake.BackColor = System.Drawing.Color.Transparent;
            this.picLiveSnake.Image = global::Snakes_and_Shillelaghs.Properties.Resources.snakes_transparent_blue;
            this.picLiveSnake.Location = new System.Drawing.Point(775, 419);
            this.picLiveSnake.Name = "picLiveSnake";
            this.picLiveSnake.Size = new System.Drawing.Size(143, 176);
            this.picLiveSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLiveSnake.TabIndex = 10;
            this.picLiveSnake.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Snakes_and_Shillelaghs.Properties.Resources.pc5raky9i;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 480);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Snakes_and_Shillelaghs.Properties.Resources.leppyclip2;
            this.pictureBox3.Location = new System.Drawing.Point(150, 387);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(275, 207);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // frmLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snakes_and_Shillelaghs.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 599);
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
            this.Name = "frmLevel1";
            this.Text = "Level 1";
            this.Load += new System.EventHandler(this.frmLevel1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouWon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeadSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
    }
}