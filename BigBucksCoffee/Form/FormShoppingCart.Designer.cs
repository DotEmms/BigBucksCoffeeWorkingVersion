
namespace BigBucksCoffee
{
    partial class FormShoppingCart
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
            this.lblItems = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblTotalNoBtw = new System.Windows.Forms.Label();
            this.lblBtw = new System.Windows.Forms.Label();
            this.lblInclBtw = new System.Windows.Forms.Label();
            this.lblExclBtw = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(66, 43);
            this.lblItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(59, 25);
            this.lblItems.TabIndex = 8;
            this.lblItems.Text = "Items";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(296, 692);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 25);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "label3";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Location = new System.Drawing.Point(296, 621);
            this.lblTaxAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(64, 25);
            this.lblTaxAmount.TabIndex = 14;
            this.lblTaxAmount.Text = "label2";
            // 
            // lblTotalNoBtw
            // 
            this.lblTotalNoBtw.AutoSize = true;
            this.lblTotalNoBtw.Location = new System.Drawing.Point(296, 542);
            this.lblTotalNoBtw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalNoBtw.Name = "lblTotalNoBtw";
            this.lblTotalNoBtw.Size = new System.Drawing.Size(64, 25);
            this.lblTotalNoBtw.TabIndex = 13;
            this.lblTotalNoBtw.Text = "label1";
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Location = new System.Drawing.Point(115, 621);
            this.lblBtw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.Size = new System.Drawing.Size(103, 25);
            this.lblBtw.TabIndex = 11;
            this.lblBtw.Text = "21% BTW";
            // 
            // lblInclBtw
            // 
            this.lblInclBtw.AutoSize = true;
            this.lblInclBtw.Location = new System.Drawing.Point(66, 692);
            this.lblInclBtw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInclBtw.Name = "lblInclBtw";
            this.lblInclBtw.Size = new System.Drawing.Size(146, 25);
            this.lblInclBtw.TabIndex = 10;
            this.lblInclBtw.Text = "Total incl. BTW";
            // 
            // lblExclBtw
            // 
            this.lblExclBtw.AutoSize = true;
            this.lblExclBtw.Location = new System.Drawing.Point(66, 542);
            this.lblExclBtw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExclBtw.Name = "lblExclBtw";
            this.lblExclBtw.Size = new System.Drawing.Size(152, 25);
            this.lblExclBtw.TabIndex = 9;
            this.lblExclBtw.Text = "Total excl. BTW";
            // 
            // lblTest
            // 
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTest.Location = new System.Drawing.Point(71, 89);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(542, 398);
            this.lblTest.TabIndex = 17;
            // 
            // FormShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 795);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblExclBtw);
            this.Controls.Add(this.lblInclBtw);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalNoBtw);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lblBtw);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormShoppingCart";
            this.Text = "My Shopping Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblTotalNoBtw;
        private System.Windows.Forms.Label lblBtw;
        private System.Windows.Forms.Label lblInclBtw;
        private System.Windows.Forms.Label lblExclBtw;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblTest;
    }
}