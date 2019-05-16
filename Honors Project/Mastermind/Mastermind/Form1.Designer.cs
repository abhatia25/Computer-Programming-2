namespace Mastermind
{
    partial class frmMasterMind
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbNumber1 = new System.Windows.Forms.ComboBox();
            this.cmbNumber2 = new System.Windows.Forms.ComboBox();
            this.cmbNumber3 = new System.Windows.Forms.ComboBox();
            this.cmbNumber4 = new System.Windows.Forms.ComboBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber4 = new System.Windows.Forms.Label();
            this.lblNumber3 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.btnTakeAShot = new System.Windows.Forms.Button();
            this.lblLabel1 = new System.Windows.Forms.Label();
            this.lblLabel3 = new System.Windows.Forms.Label();
            this.lblLabel2 = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblNearby = new System.Windows.Forms.Label();
            this.lblRightOn = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.statsToolStripMenuItem,
            this.cheatToolStripMenuItem,
            this.nameToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statsToolStripMenuItem.Text = "&Stats";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "S&how";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // cheatToolStripMenuItem
            // 
            this.cheatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setToolStripMenuItem,
            this.peekToolStripMenuItem});
            this.cheatToolStripMenuItem.Name = "cheatToolStripMenuItem";
            this.cheatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cheatToolStripMenuItem.Text = "Chea&t";
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.setToolStripMenuItem.Text = "S&et";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // peekToolStripMenuItem
            // 
            this.peekToolStripMenuItem.Name = "peekToolStripMenuItem";
            this.peekToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.peekToolStripMenuItem.Text = "&Peek";
            this.peekToolStripMenuItem.Click += new System.EventHandler(this.peekToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nameToolStripMenuItem.Text = "N&ame";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.rulesToolStripMenuItem.Text = "&Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.HorizontalScrollbar = true;
            this.lbxOutput.Location = new System.Drawing.Point(290, 33);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(211, 368);
            this.lbxOutput.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 90);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Guess My PIN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNumber1
            // 
            this.cmbNumber1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumber1.FormattingEnabled = true;
            this.cmbNumber1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbNumber1.Location = new System.Drawing.Point(12, 116);
            this.cmbNumber1.Name = "cmbNumber1";
            this.cmbNumber1.Size = new System.Drawing.Size(60, 21);
            this.cmbNumber1.TabIndex = 3;
            this.cmbNumber1.SelectedIndexChanged += new System.EventHandler(this.cmbNumber1_SelectedIndexChanged);
            // 
            // cmbNumber2
            // 
            this.cmbNumber2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumber2.FormattingEnabled = true;
            this.cmbNumber2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbNumber2.Location = new System.Drawing.Point(78, 116);
            this.cmbNumber2.Name = "cmbNumber2";
            this.cmbNumber2.Size = new System.Drawing.Size(60, 21);
            this.cmbNumber2.TabIndex = 4;
            this.cmbNumber2.SelectedIndexChanged += new System.EventHandler(this.cmbNumber2_SelectedIndexChanged);
            // 
            // cmbNumber3
            // 
            this.cmbNumber3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumber3.FormattingEnabled = true;
            this.cmbNumber3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbNumber3.Location = new System.Drawing.Point(144, 116);
            this.cmbNumber3.Name = "cmbNumber3";
            this.cmbNumber3.Size = new System.Drawing.Size(60, 21);
            this.cmbNumber3.TabIndex = 5;
            this.cmbNumber3.SelectedIndexChanged += new System.EventHandler(this.cmbNumber3_SelectedIndexChanged);
            // 
            // cmbNumber4
            // 
            this.cmbNumber4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumber4.FormattingEnabled = true;
            this.cmbNumber4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbNumber4.Location = new System.Drawing.Point(210, 116);
            this.cmbNumber4.Name = "cmbNumber4";
            this.cmbNumber4.Size = new System.Drawing.Size(60, 21);
            this.cmbNumber4.TabIndex = 6;
            this.cmbNumber4.SelectedIndexChanged += new System.EventHandler(this.cmbNumber4_SelectedIndexChanged);
            // 
            // lblNumber1
            // 
            this.lblNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(12, 140);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(60, 88);
            this.lblNumber1.TabIndex = 7;
            this.lblNumber1.Text = "?";
            this.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber4
            // 
            this.lblNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber4.Location = new System.Drawing.Point(210, 140);
            this.lblNumber4.Name = "lblNumber4";
            this.lblNumber4.Size = new System.Drawing.Size(60, 88);
            this.lblNumber4.TabIndex = 8;
            this.lblNumber4.Text = "?";
            this.lblNumber4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber3
            // 
            this.lblNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber3.Location = new System.Drawing.Point(144, 140);
            this.lblNumber3.Name = "lblNumber3";
            this.lblNumber3.Size = new System.Drawing.Size(60, 88);
            this.lblNumber3.TabIndex = 9;
            this.lblNumber3.Text = "?";
            this.lblNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber2
            // 
            this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(78, 140);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(60, 88);
            this.lblNumber2.TabIndex = 10;
            this.lblNumber2.Text = "?";
            this.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTakeAShot
            // 
            this.btnTakeAShot.Location = new System.Drawing.Point(12, 231);
            this.btnTakeAShot.Name = "btnTakeAShot";
            this.btnTakeAShot.Size = new System.Drawing.Size(258, 66);
            this.btnTakeAShot.TabIndex = 11;
            this.btnTakeAShot.Text = "Take a Shot";
            this.btnTakeAShot.UseVisualStyleBackColor = true;
            this.btnTakeAShot.Click += new System.EventHandler(this.btnTakeAShot_Click);
            // 
            // lblLabel1
            // 
            this.lblLabel1.Location = new System.Drawing.Point(15, 300);
            this.lblLabel1.Name = "lblLabel1";
            this.lblLabel1.Size = new System.Drawing.Size(69, 42);
            this.lblLabel1.TabIndex = 12;
            this.lblLabel1.Text = "Guess #";
            this.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabel3
            // 
            this.lblLabel3.Location = new System.Drawing.Point(201, 300);
            this.lblLabel3.Name = "lblLabel3";
            this.lblLabel3.Size = new System.Drawing.Size(69, 42);
            this.lblLabel3.TabIndex = 13;
            this.lblLabel3.Text = "Nearby";
            this.lblLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabel2
            // 
            this.lblLabel2.Location = new System.Drawing.Point(109, 300);
            this.lblLabel2.Name = "lblLabel2";
            this.lblLabel2.Size = new System.Drawing.Size(69, 42);
            this.lblLabel2.TabIndex = 14;
            this.lblLabel2.Text = "Right On";
            this.lblLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuess
            // 
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(15, 342);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(69, 59);
            this.lblGuess.TabIndex = 15;
            this.lblGuess.Text = "0";
            this.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNearby
            // 
            this.lblNearby.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNearby.Location = new System.Drawing.Point(201, 342);
            this.lblNearby.Name = "lblNearby";
            this.lblNearby.Size = new System.Drawing.Size(69, 59);
            this.lblNearby.TabIndex = 16;
            this.lblNearby.Text = "0";
            this.lblNearby.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightOn
            // 
            this.lblRightOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightOn.Location = new System.Drawing.Point(108, 342);
            this.lblRightOn.Name = "lblRightOn";
            this.lblRightOn.Size = new System.Drawing.Size(69, 59);
            this.lblRightOn.TabIndex = 17;
            this.lblRightOn.Text = "0";
            this.lblRightOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMasterMind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(513, 413);
            this.Controls.Add(this.lblRightOn);
            this.Controls.Add(this.lblNearby);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lblLabel2);
            this.Controls.Add(this.lblLabel3);
            this.Controls.Add(this.lblLabel1);
            this.Controls.Add(this.btnTakeAShot);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber3);
            this.Controls.Add(this.lblNumber4);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.cmbNumber4);
            this.Controls.Add(this.cmbNumber3);
            this.Controls.Add(this.cmbNumber2);
            this.Controls.Add(this.cmbNumber1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMasterMind";
            this.Text = "Master Mind";
            this.Load += new System.EventHandler(this.frmMasterMind_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peekToolStripMenuItem;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbNumber1;
        private System.Windows.Forms.ComboBox cmbNumber2;
        private System.Windows.Forms.ComboBox cmbNumber3;
        private System.Windows.Forms.ComboBox cmbNumber4;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber4;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Button btnTakeAShot;
        private System.Windows.Forms.Label lblLabel1;
        private System.Windows.Forms.Label lblLabel3;
        private System.Windows.Forms.Label lblLabel2;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblNearby;
        private System.Windows.Forms.Label lblRightOn;
    }
}

