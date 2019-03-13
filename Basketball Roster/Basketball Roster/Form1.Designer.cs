namespace Basketball_Roster
{
    partial class frmBasketballRoster
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
            this.lblPlayersPrompt = new System.Windows.Forms.Label();
            this.txtPlayers = new System.Windows.Forms.TextBox();
            this.lblFirstNamePrompt = new System.Windows.Forms.Label();
            this.lblLastNamePrompt = new System.Windows.Forms.Label();
            this.lblHeightPrompt = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.txtRoster = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPlayersPrompt
            // 
            this.lblPlayersPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblPlayersPrompt.Name = "lblPlayersPrompt";
            this.lblPlayersPrompt.Size = new System.Drawing.Size(339, 21);
            this.lblPlayersPrompt.TabIndex = 0;
            this.lblPlayersPrompt.Text = "How many players?";
            this.lblPlayersPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlayers
            // 
            this.txtPlayers.Location = new System.Drawing.Point(129, 33);
            this.txtPlayers.Name = "txtPlayers";
            this.txtPlayers.Size = new System.Drawing.Size(97, 20);
            this.txtPlayers.TabIndex = 1;
            // 
            // lblFirstNamePrompt
            // 
            this.lblFirstNamePrompt.AutoSize = true;
            this.lblFirstNamePrompt.Location = new System.Drawing.Point(12, 94);
            this.lblFirstNamePrompt.Name = "lblFirstNamePrompt";
            this.lblFirstNamePrompt.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNamePrompt.TabIndex = 2;
            this.lblFirstNamePrompt.Text = "First Name";
            // 
            // lblLastNamePrompt
            // 
            this.lblLastNamePrompt.AutoSize = true;
            this.lblLastNamePrompt.Location = new System.Drawing.Point(133, 94);
            this.lblLastNamePrompt.Name = "lblLastNamePrompt";
            this.lblLastNamePrompt.Size = new System.Drawing.Size(58, 13);
            this.lblLastNamePrompt.TabIndex = 3;
            this.lblLastNamePrompt.Text = "Last Name";
            // 
            // lblHeightPrompt
            // 
            this.lblHeightPrompt.AutoSize = true;
            this.lblHeightPrompt.Location = new System.Drawing.Point(249, 94);
            this.lblHeightPrompt.Name = "lblHeightPrompt";
            this.lblHeightPrompt.Size = new System.Drawing.Size(78, 13);
            this.lblHeightPrompt.TabIndex = 4;
            this.lblHeightPrompt.Text = "Height (inches)";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 110);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(131, 110);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(247, 110);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(141, 61);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(131, 158);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 20);
            this.txtPosition.TabIndex = 10;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(133, 142);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(68, 13);
            this.lblPosition.TabIndex = 9;
            this.lblPosition.Text = "Position (1-5)";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(247, 158);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Year (FR, SO, JR, SR)";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(141, 184);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlayer.TabIndex = 13;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // txtRoster
            // 
            this.txtRoster.Location = new System.Drawing.Point(12, 211);
            this.txtRoster.Multiline = true;
            this.txtRoster.Name = "txtRoster";
            this.txtRoster.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRoster.Size = new System.Drawing.Size(339, 154);
            this.txtRoster.TabIndex = 14;
            // 
            // frmBasketballRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 377);
            this.Controls.Add(this.txtRoster);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblHeightPrompt);
            this.Controls.Add(this.lblLastNamePrompt);
            this.Controls.Add(this.lblFirstNamePrompt);
            this.Controls.Add(this.txtPlayers);
            this.Controls.Add(this.lblPlayersPrompt);
            this.Name = "frmBasketballRoster";
            this.Text = "Basketball Roster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayersPrompt;
        private System.Windows.Forms.TextBox txtPlayers;
        private System.Windows.Forms.Label lblFirstNamePrompt;
        private System.Windows.Forms.Label lblLastNamePrompt;
        private System.Windows.Forms.Label lblHeightPrompt;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TextBox txtRoster;
    }
}

