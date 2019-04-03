namespace Hangman
{
    partial class frmHangman
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
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.lblBadGuesses = new System.Windows.Forms.Label();
            this.lblBad = new System.Windows.Forms.Label();
            this.picHangman = new System.Windows.Forms.PictureBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblHangmanWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnAssign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(12, 9);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(79, 13);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Guess a Letter:";
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(97, 6);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(37, 20);
            this.txtLetter.TabIndex = 1;
            // 
            // lblBadGuesses
            // 
            this.lblBadGuesses.AutoSize = true;
            this.lblBadGuesses.Location = new System.Drawing.Point(12, 55);
            this.lblBadGuesses.Name = "lblBadGuesses";
            this.lblBadGuesses.Size = new System.Drawing.Size(73, 13);
            this.lblBadGuesses.TabIndex = 2;
            this.lblBadGuesses.Text = "Bad Guesses:";
            // 
            // lblBad
            // 
            this.lblBad.AutoSize = true;
            this.lblBad.Location = new System.Drawing.Point(99, 55);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(0, 13);
            this.lblBad.TabIndex = 3;
            // 
            // picHangman
            // 
            this.picHangman.BackgroundImage = global::Hangman.Properties.Resources.start;
            this.picHangman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHangman.Location = new System.Drawing.Point(15, 85);
            this.picHangman.Name = "picHangman";
            this.picHangman.Size = new System.Drawing.Size(220, 162);
            this.picHangman.TabIndex = 4;
            this.picHangman.TabStop = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(12, 267);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(72, 301);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(86, 27);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check Letter";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblHangmanWord
            // 
            this.lblHangmanWord.AutoSize = true;
            this.lblHangmanWord.Location = new System.Drawing.Point(12, 342);
            this.lblHangmanWord.Name = "lblHangmanWord";
            this.lblHangmanWord.Size = new System.Drawing.Size(85, 13);
            this.lblHangmanWord.TabIndex = 7;
            this.lblHangmanWord.Text = "Hangman Word:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(102, 339);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(133, 20);
            this.txtWord.TabIndex = 8;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(50, 365);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(134, 23);
            this.btnAssign.TabIndex = 9;
            this.btnAssign.Text = "Assign Hangman Word";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 399);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblHangmanWord);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.picHangman);
            this.Controls.Add(this.lblBad);
            this.Controls.Add(this.lblBadGuesses);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.lblGuess);
            this.Name = "frmHangman";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Label lblBadGuesses;
        private System.Windows.Forms.Label lblBad;
        private System.Windows.Forms.PictureBox picHangman;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblHangmanWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnAssign;
    }
}

