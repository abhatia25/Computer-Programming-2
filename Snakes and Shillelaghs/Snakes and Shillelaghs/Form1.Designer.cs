namespace Snakes_and_Shillelaghs
{
    partial class frmWeaponChooser
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
            this.btnAdvance = new System.Windows.Forms.Button();
            this.picKnife = new System.Windows.Forms.PictureBox();
            this.picAxe = new System.Windows.Forms.PictureBox();
            this.picSword = new System.Windows.Forms.PictureBox();
            this.picShillelagh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picKnife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShillelagh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(130, 238);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(75, 23);
            this.btnAdvance.TabIndex = 4;
            this.btnAdvance.Text = "Advance";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Visible = false;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // picKnife
            // 
            this.picKnife.BackgroundImage = global::Snakes_and_Shillelaghs.Properties.Resources.throwing_knives_clipart_1;
            this.picKnife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picKnife.Location = new System.Drawing.Point(173, 122);
            this.picKnife.Name = "picKnife";
            this.picKnife.Size = new System.Drawing.Size(155, 110);
            this.picKnife.TabIndex = 3;
            this.picKnife.TabStop = false;
            this.picKnife.Click += new System.EventHandler(this.picKnife_Click);
            // 
            // picAxe
            // 
            this.picAxe.BackgroundImage = global::Snakes_and_Shillelaghs.Properties.Resources._140329;
            this.picAxe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAxe.Location = new System.Drawing.Point(12, 122);
            this.picAxe.Name = "picAxe";
            this.picAxe.Size = new System.Drawing.Size(155, 110);
            this.picAxe.TabIndex = 2;
            this.picAxe.TabStop = false;
            this.picAxe.Click += new System.EventHandler(this.picAxe_Click);
            // 
            // picSword
            // 
            this.picSword.BackgroundImage = global::Snakes_and_Shillelaghs.Properties.Resources.Trp_Sword_14226124129_v06;
            this.picSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSword.Location = new System.Drawing.Point(173, 12);
            this.picSword.Name = "picSword";
            this.picSword.Size = new System.Drawing.Size(155, 104);
            this.picSword.TabIndex = 1;
            this.picSword.TabStop = false;
            this.picSword.Click += new System.EventHandler(this.picSword_Click);
            // 
            // picShillelagh
            // 
            this.picShillelagh.BackgroundImage = global::Snakes_and_Shillelaghs.Properties.Resources.download;
            this.picShillelagh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picShillelagh.Location = new System.Drawing.Point(12, 12);
            this.picShillelagh.Name = "picShillelagh";
            this.picShillelagh.Size = new System.Drawing.Size(155, 104);
            this.picShillelagh.TabIndex = 0;
            this.picShillelagh.TabStop = false;
            this.picShillelagh.Click += new System.EventHandler(this.picShillelagh_Click);
            // 
            // frmWeaponChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 272);
            this.Controls.Add(this.btnAdvance);
            this.Controls.Add(this.picKnife);
            this.Controls.Add(this.picAxe);
            this.Controls.Add(this.picSword);
            this.Controls.Add(this.picShillelagh);
            this.Name = "frmWeaponChooser";
            this.Text = "Weapon Chooser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picKnife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShillelagh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picShillelagh;
        private System.Windows.Forms.PictureBox picSword;
        private System.Windows.Forms.PictureBox picAxe;
        private System.Windows.Forms.PictureBox picKnife;
        private System.Windows.Forms.Button btnAdvance;
    }
}

