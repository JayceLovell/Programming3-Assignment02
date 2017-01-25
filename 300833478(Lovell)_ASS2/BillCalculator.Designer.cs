namespace _300833478_Lovell__ASS2
{
    partial class BillCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillCalculator));
            this.BeverageCmbox = new System.Windows.Forms.ComboBox();
            this.AppetizerCmbB = new System.Windows.Forms.ComboBox();
            this.MainCourseCmbB = new System.Windows.Forms.ComboBox();
            this.DessertCmbB = new System.Windows.Forms.ComboBox();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.companylogolbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelusername = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSubtotalTitle = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbldivider = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.loginUserControl1 = new _300833478_Lovell__ASS2.LoginUserControl();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BeverageCmbox
            // 
            this.BeverageCmbox.FormattingEnabled = true;
            this.BeverageCmbox.Location = new System.Drawing.Point(13, 13);
            this.BeverageCmbox.Name = "BeverageCmbox";
            this.BeverageCmbox.Size = new System.Drawing.Size(135, 31);
            this.BeverageCmbox.TabIndex = 0;
            this.BeverageCmbox.Text = "Beverage";
            this.BeverageCmbox.SelectedIndexChanged += new System.EventHandler(this.ItemSelected);
            // 
            // AppetizerCmbB
            // 
            this.AppetizerCmbB.FormattingEnabled = true;
            this.AppetizerCmbB.Location = new System.Drawing.Point(154, 12);
            this.AppetizerCmbB.Name = "AppetizerCmbB";
            this.AppetizerCmbB.Size = new System.Drawing.Size(145, 31);
            this.AppetizerCmbB.TabIndex = 1;
            this.AppetizerCmbB.Text = "Appetizer";
            this.AppetizerCmbB.SelectedIndexChanged += new System.EventHandler(this.ItemSelected);
            // 
            // MainCourseCmbB
            // 
            this.MainCourseCmbB.FormattingEnabled = true;
            this.MainCourseCmbB.Location = new System.Drawing.Point(305, 13);
            this.MainCourseCmbB.Name = "MainCourseCmbB";
            this.MainCourseCmbB.Size = new System.Drawing.Size(145, 31);
            this.MainCourseCmbB.TabIndex = 2;
            this.MainCourseCmbB.Text = "Main Course";
            this.MainCourseCmbB.SelectedIndexChanged += new System.EventHandler(this.ItemSelected);
            // 
            // DessertCmbB
            // 
            this.DessertCmbB.FormattingEnabled = true;
            this.DessertCmbB.Location = new System.Drawing.Point(456, 13);
            this.DessertCmbB.Name = "DessertCmbB";
            this.DessertCmbB.Size = new System.Drawing.Size(145, 31);
            this.DessertCmbB.TabIndex = 3;
            this.DessertCmbB.Text = "Dessert";
            this.DessertCmbB.SelectedIndexChanged += new System.EventHandler(this.ItemSelected);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(12, 314);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 32);
            this.Clearbtn.TabIndex = 4;
            this.Clearbtn.Text = "Clear Bill";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companylogolbl,
            this.labelusername});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // companylogolbl
            // 
            this.companylogolbl.Image = ((System.Drawing.Image)(resources.GetObject("companylogolbl.Image")));
            this.companylogolbl.Name = "companylogolbl";
            this.companylogolbl.Size = new System.Drawing.Size(16, 17);
            this.companylogolbl.Click += new System.EventHandler(this.companylogolbl_Click);
            // 
            // labelusername
            // 
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(0, 17);
            // 
            // lblSubtotalTitle
            // 
            this.lblSubtotalTitle.AutoSize = true;
            this.lblSubtotalTitle.Location = new System.Drawing.Point(9, 268);
            this.lblSubtotalTitle.Name = "lblSubtotalTitle";
            this.lblSubtotalTitle.Size = new System.Drawing.Size(85, 23);
            this.lblSubtotalTitle.TabIndex = 6;
            this.lblSubtotalTitle.Text = "SubTotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(103, 259);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 32);
            this.txtSubtotal.TabIndex = 7;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(293, 259);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 32);
            this.txtTax.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(494, 259);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 32);
            this.txtTotal.TabIndex = 9;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(247, 268);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(40, 23);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(435, 268);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 23);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            // 
            // lbldivider
            // 
            this.lbldivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldivider.Location = new System.Drawing.Point(605, 13);
            this.lbldivider.Name = "lbldivider";
            this.lbldivider.Size = new System.Drawing.Size(1, 337);
            this.lbldivider.TabIndex = 13;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(674, 96);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 31);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // loginUserControl1
            // 
            this.loginUserControl1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.loginUserControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserControl1.Location = new System.Drawing.Point(609, 13);
            this.loginUserControl1.Margin = new System.Windows.Forms.Padding(5);
            this.loginUserControl1.Name = "loginUserControl1";
            this.loginUserControl1.Size = new System.Drawing.Size(220, 75);
            this.loginUserControl1.TabIndex = 12;
            // 
            // BillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(818, 371);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbldivider);
            this.Controls.Add(this.loginUserControl1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblSubtotalTitle);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.DessertCmbB);
            this.Controls.Add(this.MainCourseCmbB);
            this.Controls.Add(this.AppetizerCmbB);
            this.Controls.Add(this.BeverageCmbox);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BillCalculator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.BillCalculator_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BeverageCmbox;
        private System.Windows.Forms.ComboBox AppetizerCmbB;
        private System.Windows.Forms.ComboBox MainCourseCmbB;
        private System.Windows.Forms.ComboBox DessertCmbB;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel companylogolbl;
        private System.Windows.Forms.Label lblSubtotalTitle;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private LoginUserControl loginUserControl1;
        private System.Windows.Forms.ToolStripStatusLabel labelusername;
        private System.Windows.Forms.Label lbldivider;
        private System.Windows.Forms.Button btnLogin;
    }
}

