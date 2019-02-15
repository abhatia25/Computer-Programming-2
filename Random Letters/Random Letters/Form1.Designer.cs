namespace Random_Letters
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
            this.radUpper = new System.Windows.Forms.RadioButton();
            this.radLower = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radUpper
            // 
            this.radUpper.AutoSize = true;
            this.radUpper.Location = new System.Drawing.Point(12, 12);
            this.radUpper.Name = "radUpper";
            this.radUpper.Size = new System.Drawing.Size(54, 17);
            this.radUpper.TabIndex = 0;
            this.radUpper.TabStop = true;
            this.radUpper.Text = "Upper";
            this.radUpper.UseVisualStyleBackColor = true;
            // 
            // radLower
            // 
            this.radLower.AutoSize = true;
            this.radLower.Location = new System.Drawing.Point(12, 35);
            this.radLower.Name = "radLower";
            this.radLower.Size = new System.Drawing.Size(54, 17);
            this.radLower.TabIndex = 1;
            this.radLower.TabStop = true;
            this.radLower.Text = "Lower";
            this.radLower.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(141, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(110, 48);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 72);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.radLower);
            this.Controls.Add(this.radUpper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radUpper;
        private System.Windows.Forms.RadioButton radLower;
        private System.Windows.Forms.Button btnGenerate;
    }
}

