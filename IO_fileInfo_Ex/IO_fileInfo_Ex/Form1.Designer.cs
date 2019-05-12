namespace IO_fileInfo_Ex
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
            this.LB = new System.Windows.Forms.ListBox();
            this.btnFileInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB
            // 
            this.LB.FormattingEnabled = true;
            this.LB.Location = new System.Drawing.Point(12, 70);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(776, 368);
            this.LB.TabIndex = 0;
            // 
            // btnFileInfo
            // 
            this.btnFileInfo.Location = new System.Drawing.Point(12, 12);
            this.btnFileInfo.Name = "btnFileInfo";
            this.btnFileInfo.Size = new System.Drawing.Size(776, 52);
            this.btnFileInfo.TabIndex = 1;
            this.btnFileInfo.Text = "File Info";
            this.btnFileInfo.UseVisualStyleBackColor = true;
            this.btnFileInfo.Click += new System.EventHandler(this.btnFileInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFileInfo);
            this.Controls.Add(this.LB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB;
        private System.Windows.Forms.Button btnFileInfo;
    }
}

