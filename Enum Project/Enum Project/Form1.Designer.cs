namespace Enum_Project
{
    partial class frmMenu
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
            this.grpChoose = new System.Windows.Forms.GroupBox();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.radHamburger = new System.Windows.Forms.RadioButton();
            this.radCheeseburger = new System.Windows.Forms.RadioButton();
            this.radBigMac = new System.Windows.Forms.RadioButton();
            this.radQP = new System.Windows.Forms.RadioButton();
            this.radQPCheese = new System.Windows.Forms.RadioButton();
            this.radFries = new System.Windows.Forms.RadioButton();
            this.radCocaCola = new System.Windows.Forms.RadioButton();
            this.radMilkshake = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChoose
            // 
            this.grpChoose.Controls.Add(this.radMilkshake);
            this.grpChoose.Controls.Add(this.radCocaCola);
            this.grpChoose.Controls.Add(this.radFries);
            this.grpChoose.Controls.Add(this.radQPCheese);
            this.grpChoose.Controls.Add(this.radQP);
            this.grpChoose.Controls.Add(this.radBigMac);
            this.grpChoose.Controls.Add(this.radCheeseburger);
            this.grpChoose.Controls.Add(this.radHamburger);
            this.grpChoose.Location = new System.Drawing.Point(12, 60);
            this.grpChoose.Name = "grpChoose";
            this.grpChoose.Size = new System.Drawing.Size(188, 211);
            this.grpChoose.TabIndex = 0;
            this.grpChoose.TabStop = false;
            this.grpChoose.Text = "Choose";
            // 
            // lblSpecial
            // 
            this.lblSpecial.Location = new System.Drawing.Point(12, 9);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(188, 48);
            this.lblSpecial.TabIndex = 0;
            this.lblSpecial.Text = "Today\'s Special: ";
            // 
            // radHamburger
            // 
            this.radHamburger.AutoSize = true;
            this.radHamburger.Location = new System.Drawing.Point(6, 19);
            this.radHamburger.Name = "radHamburger";
            this.radHamburger.Size = new System.Drawing.Size(77, 17);
            this.radHamburger.TabIndex = 0;
            this.radHamburger.TabStop = true;
            this.radHamburger.Text = "Hamburger";
            this.radHamburger.UseVisualStyleBackColor = true;
            // 
            // radCheeseburger
            // 
            this.radCheeseburger.AutoSize = true;
            this.radCheeseburger.Location = new System.Drawing.Point(6, 44);
            this.radCheeseburger.Name = "radCheeseburger";
            this.radCheeseburger.Size = new System.Drawing.Size(91, 17);
            this.radCheeseburger.TabIndex = 1;
            this.radCheeseburger.TabStop = true;
            this.radCheeseburger.Text = "Cheeseburger";
            this.radCheeseburger.UseVisualStyleBackColor = true;
            // 
            // radBigMac
            // 
            this.radBigMac.AutoSize = true;
            this.radBigMac.Location = new System.Drawing.Point(6, 67);
            this.radBigMac.Name = "radBigMac";
            this.radBigMac.Size = new System.Drawing.Size(64, 17);
            this.radBigMac.TabIndex = 2;
            this.radBigMac.TabStop = true;
            this.radBigMac.Text = "Big Mac";
            this.radBigMac.UseVisualStyleBackColor = true;
            // 
            // radQP
            // 
            this.radQP.AutoSize = true;
            this.radQP.Location = new System.Drawing.Point(6, 90);
            this.radQP.Name = "radQP";
            this.radQP.Size = new System.Drawing.Size(103, 17);
            this.radQP.TabIndex = 3;
            this.radQP.TabStop = true;
            this.radQP.Text = "Quarter Pounder";
            this.radQP.UseVisualStyleBackColor = true;
            // 
            // radQPCheese
            // 
            this.radQPCheese.AutoSize = true;
            this.radQPCheese.Location = new System.Drawing.Point(6, 113);
            this.radQPCheese.Name = "radQPCheese";
            this.radQPCheese.Size = new System.Drawing.Size(164, 17);
            this.radQPCheese.TabIndex = 4;
            this.radQPCheese.TabStop = true;
            this.radQPCheese.Text = "Quarter Pounder with Cheese";
            this.radQPCheese.UseVisualStyleBackColor = true;
            // 
            // radFries
            // 
            this.radFries.AutoSize = true;
            this.radFries.Location = new System.Drawing.Point(6, 136);
            this.radFries.Name = "radFries";
            this.radFries.Size = new System.Drawing.Size(47, 17);
            this.radFries.TabIndex = 5;
            this.radFries.TabStop = true;
            this.radFries.Text = "Fries";
            this.radFries.UseVisualStyleBackColor = true;
            // 
            // radCocaCola
            // 
            this.radCocaCola.AutoSize = true;
            this.radCocaCola.Location = new System.Drawing.Point(6, 159);
            this.radCocaCola.Name = "radCocaCola";
            this.radCocaCola.Size = new System.Drawing.Size(74, 17);
            this.radCocaCola.TabIndex = 6;
            this.radCocaCola.TabStop = true;
            this.radCocaCola.Text = "Coca Cola";
            this.radCocaCola.UseVisualStyleBackColor = true;
            // 
            // radMilkshake
            // 
            this.radMilkshake.AutoSize = true;
            this.radMilkshake.Location = new System.Drawing.Point(6, 182);
            this.radMilkshake.Name = "radMilkshake";
            this.radMilkshake.Size = new System.Drawing.Size(73, 17);
            this.radMilkshake.TabIndex = 7;
            this.radMilkshake.TabStop = true;
            this.radMilkshake.Text = "Milkshake";
            this.radMilkshake.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(15, 274);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(185, 74);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(238, 9);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(209, 336);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 357);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSpecial);
            this.Controls.Add(this.grpChoose);
            this.Name = "frmMenu";
            this.Text = "Hamburger U Lunch Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.grpChoose.ResumeLayout(false);
            this.grpChoose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChoose;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.RadioButton radMilkshake;
        private System.Windows.Forms.RadioButton radCocaCola;
        private System.Windows.Forms.RadioButton radFries;
        private System.Windows.Forms.RadioButton radQPCheese;
        private System.Windows.Forms.RadioButton radQP;
        private System.Windows.Forms.RadioButton radBigMac;
        private System.Windows.Forms.RadioButton radCheeseburger;
        private System.Windows.Forms.RadioButton radHamburger;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSubmit;
    }
}

