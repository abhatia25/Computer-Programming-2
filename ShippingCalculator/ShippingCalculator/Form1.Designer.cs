namespace ShippingCalculator
{
    partial class frmShippingCalc
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
            this.lblShippingWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.grpDeliveryTime = new System.Windows.Forms.GroupBox();
            this.radGrd = new System.Windows.Forms.RadioButton();
            this.rad3rdDay = new System.Windows.Forms.RadioButton();
            this.rad2ndDay = new System.Windows.Forms.RadioButton();
            this.radNxtDay = new System.Windows.Forms.RadioButton();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.chkSig = new System.Windows.Forms.CheckBox();
            this.chkIns = new System.Windows.Forms.CheckBox();
            this.chkSat = new System.Windows.Forms.CheckBox();
            this.chkRush = new System.Windows.Forms.CheckBox();
            this.lblVal = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnRates = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDeliveryTime.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShippingWeight
            // 
            this.lblShippingWeight.AutoSize = true;
            this.lblShippingWeight.Location = new System.Drawing.Point(91, 9);
            this.lblShippingWeight.Name = "lblShippingWeight";
            this.lblShippingWeight.Size = new System.Drawing.Size(88, 13);
            this.lblShippingWeight.TabIndex = 0;
            this.lblShippingWeight.Text = "Shipping Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(185, 6);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 1;
            // 
            // grpDeliveryTime
            // 
            this.grpDeliveryTime.Controls.Add(this.radGrd);
            this.grpDeliveryTime.Controls.Add(this.rad3rdDay);
            this.grpDeliveryTime.Controls.Add(this.rad2ndDay);
            this.grpDeliveryTime.Controls.Add(this.radNxtDay);
            this.grpDeliveryTime.Location = new System.Drawing.Point(12, 32);
            this.grpDeliveryTime.Name = "grpDeliveryTime";
            this.grpDeliveryTime.Size = new System.Drawing.Size(395, 67);
            this.grpDeliveryTime.TabIndex = 2;
            this.grpDeliveryTime.TabStop = false;
            this.grpDeliveryTime.Text = "Delivery Time";
            // 
            // radGrd
            // 
            this.radGrd.AutoSize = true;
            this.radGrd.Location = new System.Drawing.Point(274, 42);
            this.radGrd.Name = "radGrd";
            this.radGrd.Size = new System.Drawing.Size(60, 17);
            this.radGrd.TabIndex = 3;
            this.radGrd.TabStop = true;
            this.radGrd.Text = "Ground";
            this.radGrd.UseVisualStyleBackColor = true;
            // 
            // rad3rdDay
            // 
            this.rad3rdDay.AutoSize = true;
            this.rad3rdDay.Location = new System.Drawing.Point(274, 19);
            this.rad3rdDay.Name = "rad3rdDay";
            this.rad3rdDay.Size = new System.Drawing.Size(111, 17);
            this.rad3rdDay.TabIndex = 2;
            this.rad3rdDay.TabStop = true;
            this.rad3rdDay.Text = "Third Day Express";
            this.rad3rdDay.UseVisualStyleBackColor = true;
            // 
            // rad2ndDay
            // 
            this.rad2ndDay.AutoSize = true;
            this.rad2ndDay.Location = new System.Drawing.Point(16, 42);
            this.rad2ndDay.Name = "rad2ndDay";
            this.rad2ndDay.Size = new System.Drawing.Size(99, 17);
            this.rad2ndDay.TabIndex = 1;
            this.rad2ndDay.TabStop = true;
            this.rad2ndDay.Text = "Second Day Air";
            this.rad2ndDay.UseVisualStyleBackColor = true;
            // 
            // radNxtDay
            // 
            this.radNxtDay.AutoSize = true;
            this.radNxtDay.Location = new System.Drawing.Point(16, 19);
            this.radNxtDay.Name = "radNxtDay";
            this.radNxtDay.Size = new System.Drawing.Size(84, 17);
            this.radNxtDay.TabIndex = 0;
            this.radNxtDay.TabStop = true;
            this.radNxtDay.Text = "Next Day Air";
            this.radNxtDay.UseVisualStyleBackColor = true;
            this.radNxtDay.CheckedChanged += new System.EventHandler(this.radNxtDay_CheckedChanged);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.txtVal);
            this.grpOptions.Controls.Add(this.chkSig);
            this.grpOptions.Controls.Add(this.chkIns);
            this.grpOptions.Controls.Add(this.chkSat);
            this.grpOptions.Controls.Add(this.chkRush);
            this.grpOptions.Controls.Add(this.lblVal);
            this.grpOptions.Location = new System.Drawing.Point(12, 105);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(395, 91);
            this.grpOptions.TabIndex = 4;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(312, 42);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(77, 20);
            this.txtVal.TabIndex = 5;
            // 
            // chkSig
            // 
            this.chkSig.AutoSize = true;
            this.chkSig.Location = new System.Drawing.Point(279, 68);
            this.chkSig.Name = "chkSig";
            this.chkSig.Size = new System.Drawing.Size(117, 17);
            this.chkSig.TabIndex = 4;
            this.chkSig.Text = "Signature Required";
            this.chkSig.UseVisualStyleBackColor = true;
            this.chkSig.CheckedChanged += new System.EventHandler(this.chkSig_CheckedChanged);
            // 
            // chkIns
            // 
            this.chkIns.AutoSize = true;
            this.chkIns.Location = new System.Drawing.Point(274, 19);
            this.chkIns.Name = "chkIns";
            this.chkIns.Size = new System.Drawing.Size(73, 17);
            this.chkIns.TabIndex = 3;
            this.chkIns.Text = "Insurance";
            this.chkIns.UseVisualStyleBackColor = true;
            // 
            // chkSat
            // 
            this.chkSat.AutoSize = true;
            this.chkSat.Location = new System.Drawing.Point(6, 68);
            this.chkSat.Name = "chkSat";
            this.chkSat.Size = new System.Drawing.Size(109, 17);
            this.chkSat.TabIndex = 2;
            this.chkSat.Text = "Saturday Delivery";
            this.chkSat.UseVisualStyleBackColor = true;
            // 
            // chkRush
            // 
            this.chkRush.AutoSize = true;
            this.chkRush.Location = new System.Drawing.Point(6, 19);
            this.chkRush.Name = "chkRush";
            this.chkRush.Size = new System.Drawing.Size(70, 17);
            this.chkRush.TabIndex = 1;
            this.chkRush.Text = "Rush AM";
            this.chkRush.UseVisualStyleBackColor = true;
            this.chkRush.Visible = false;
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(271, 44);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(37, 13);
            this.lblVal.TabIndex = 0;
            this.lblVal.Text = "Value:";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 202);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnRates
            // 
            this.btnRates.Location = new System.Drawing.Point(116, 202);
            this.btnRates.Name = "btnRates";
            this.btnRates.Size = new System.Drawing.Size(75, 23);
            this.btnRates.TabIndex = 7;
            this.btnRates.Text = "Rates";
            this.btnRates.UseVisualStyleBackColor = true;
            this.btnRates.Click += new System.EventHandler(this.btnRates_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(225, 202);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(332, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmShippingCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 237);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnRates);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpDeliveryTime);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblShippingWeight);
            this.DoubleBuffered = true;
            this.Name = "frmShippingCalc";
            this.Text = "Shipping Calculator";
            this.grpDeliveryTime.ResumeLayout(false);
            this.grpDeliveryTime.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShippingWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.GroupBox grpDeliveryTime;
        private System.Windows.Forms.RadioButton radGrd;
        private System.Windows.Forms.RadioButton rad3rdDay;
        private System.Windows.Forms.RadioButton rad2ndDay;
        private System.Windows.Forms.RadioButton radNxtDay;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.CheckBox chkSig;
        private System.Windows.Forms.CheckBox chkIns;
        private System.Windows.Forms.CheckBox chkSat;
        private System.Windows.Forms.CheckBox chkRush;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnRates;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
    }
}

