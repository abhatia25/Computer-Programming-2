namespace File_IO_Ex
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGetCreateTime = new System.Windows.Forms.Button();
            this.btnGetAccessTime = new System.Windows.Forms.Button();
            this.btnGetWriteTime = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(12, 12);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(154, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(12, 41);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(154, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 70);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(154, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnGetCreateTime
            // 
            this.btnGetCreateTime.Location = new System.Drawing.Point(12, 99);
            this.btnGetCreateTime.Name = "btnGetCreateTime";
            this.btnGetCreateTime.Size = new System.Drawing.Size(154, 23);
            this.btnGetCreateTime.TabIndex = 3;
            this.btnGetCreateTime.Text = "Creation Time";
            this.btnGetCreateTime.UseVisualStyleBackColor = true;
            this.btnGetCreateTime.Click += new System.EventHandler(this.btnGetCreateTime_Click);
            // 
            // btnGetAccessTime
            // 
            this.btnGetAccessTime.Location = new System.Drawing.Point(12, 128);
            this.btnGetAccessTime.Name = "btnGetAccessTime";
            this.btnGetAccessTime.Size = new System.Drawing.Size(154, 23);
            this.btnGetAccessTime.TabIndex = 4;
            this.btnGetAccessTime.Text = "Last Access Time";
            this.btnGetAccessTime.UseVisualStyleBackColor = true;
            this.btnGetAccessTime.Click += new System.EventHandler(this.btnGetAccessTime_Click);
            // 
            // btnGetWriteTime
            // 
            this.btnGetWriteTime.Location = new System.Drawing.Point(12, 157);
            this.btnGetWriteTime.Name = "btnGetWriteTime";
            this.btnGetWriteTime.Size = new System.Drawing.Size(154, 23);
            this.btnGetWriteTime.TabIndex = 5;
            this.btnGetWriteTime.Text = "Last Write Time";
            this.btnGetWriteTime.UseVisualStyleBackColor = true;
            this.btnGetWriteTime.Click += new System.EventHandler(this.btnGetWriteTime_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(12, 186);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(154, 23);
            this.btnMove.TabIndex = 6;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 216);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnGetWriteTime);
            this.Controls.Add(this.btnGetAccessTime);
            this.Controls.Add(this.btnGetCreateTime);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCopy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnGetCreateTime;
        private System.Windows.Forms.Button btnGetAccessTime;
        private System.Windows.Forms.Button btnGetWriteTime;
        private System.Windows.Forms.Button btnMove;
    }
}

