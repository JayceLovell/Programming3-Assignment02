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
            this.components = new System.ComponentModel.Container();
            this.BeverageCmbox = new System.Windows.Forms.ComboBox();
            this.AppetizerCmbB = new System.Windows.Forms.ComboBox();
            this.MainCourseCmbB = new System.Windows.Forms.ComboBox();
            this.DessertCmbB = new System.Windows.Forms.ComboBox();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.resturantMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.resturantMenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BeverageCmbox
            // 
            this.BeverageCmbox.FormattingEnabled = true;
            this.BeverageCmbox.Location = new System.Drawing.Point(13, 13);
            this.BeverageCmbox.Name = "BeverageCmbox";
            this.BeverageCmbox.Size = new System.Drawing.Size(121, 31);
            this.BeverageCmbox.TabIndex = 0;
            this.BeverageCmbox.Text = "Beverage";
            // 
            // AppetizerCmbB
            // 
            this.AppetizerCmbB.FormattingEnabled = true;
            this.AppetizerCmbB.Location = new System.Drawing.Point(140, 12);
            this.AppetizerCmbB.Name = "AppetizerCmbB";
            this.AppetizerCmbB.Size = new System.Drawing.Size(121, 31);
            this.AppetizerCmbB.TabIndex = 1;
            this.AppetizerCmbB.Text = "Appetizer";
            // 
            // MainCourseCmbB
            // 
            this.MainCourseCmbB.FormattingEnabled = true;
            this.MainCourseCmbB.Location = new System.Drawing.Point(267, 13);
            this.MainCourseCmbB.Name = "MainCourseCmbB";
            this.MainCourseCmbB.Size = new System.Drawing.Size(131, 31);
            this.MainCourseCmbB.TabIndex = 2;
            this.MainCourseCmbB.Text = "Main Course";
            // 
            // DessertCmbB
            // 
            this.DessertCmbB.FormattingEnabled = true;
            this.DessertCmbB.Location = new System.Drawing.Point(404, 12);
            this.DessertCmbB.Name = "DessertCmbB";
            this.DessertCmbB.Size = new System.Drawing.Size(121, 31);
            this.DessertCmbB.TabIndex = 3;
            this.DessertCmbB.Text = "Dessert";
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(13, 420);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 32);
            this.Clearbtn.TabIndex = 4;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // BillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(568, 464);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.DessertCmbB);
            this.Controls.Add(this.MainCourseCmbB);
            this.Controls.Add(this.AppetizerCmbB);
            this.Controls.Add(this.BeverageCmbox);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "BillCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.BillCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resturantMenuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox BeverageCmbox;
        private System.Windows.Forms.ComboBox AppetizerCmbB;
        private System.Windows.Forms.ComboBox MainCourseCmbB;
        private System.Windows.Forms.ComboBox DessertCmbB;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.BindingSource resturantMenuBindingSource;
    }
}

