
namespace BigBucksCoffee
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
            this.btnDynamic = new System.Windows.Forms.Button();
            this.myUserControl1 = new UserControls.MyUserControl();
            this.SuspendLayout();
            // 
            // btnDynamic
            // 
            this.btnDynamic.Location = new System.Drawing.Point(78, 366);
            this.btnDynamic.Name = "btnDynamic";
            this.btnDynamic.Size = new System.Drawing.Size(117, 46);
            this.btnDynamic.TabIndex = 1;
            this.btnDynamic.Text = "See Range";
            this.btnDynamic.UseVisualStyleBackColor = true;
            this.btnDynamic.Click += new System.EventHandler(this.btnDynamic_Click_1);
            // 
            // myUserControl1
            // 
            this.myUserControl1.Amount = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.myUserControl1.DrinkID = 0;
            this.myUserControl1.IsInStock = false;
            this.myUserControl1.Location = new System.Drawing.Point(10, 10);
            this.myUserControl1.MyProductName = "ProductName";
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Price = "Price";
            this.myUserControl1.Size = new System.Drawing.Size(265, 418);
            this.myUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(944, 553);
            this.Controls.Add(this.btnDynamic);
            this.Controls.Add(this.myUserControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.MyUserControl myUserControl1;
        private System.Windows.Forms.Button btnDynamic;
    }
}

