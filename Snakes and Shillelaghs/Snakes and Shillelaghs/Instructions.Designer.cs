namespace Snakes_and_Shillelaghs
{
    partial class frmInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstructions));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(12, 6);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(249, 189);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 198);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(246, 41);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // frmInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 251);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmInstructions";
            this.Text = "Instructions";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnStart;
    }
}