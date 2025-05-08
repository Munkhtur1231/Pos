namespace Pos
{
    partial class ReceiptProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Name = new Label();
            label_Price = new Label();
            label_Qty = new Label();
            label_Total = new Label();
            SuspendLayout();
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(16, 10);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(38, 15);
            label_Name.TabIndex = 0;
            label_Name.Text = "label1";
            // 
            // label_Price
            // 
            label_Price.AutoSize = true;
            label_Price.Location = new Point(191, 10);
            label_Price.Name = "label_Price";
            label_Price.Size = new Size(38, 15);
            label_Price.TabIndex = 1;
            label_Price.Text = "label2";
            // 
            // label_Qty
            // 
            label_Qty.AutoSize = true;
            label_Qty.Location = new Point(302, 10);
            label_Qty.Name = "label_Qty";
            label_Qty.Size = new Size(38, 15);
            label_Qty.TabIndex = 2;
            label_Qty.Text = "label3";
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Location = new Point(407, 10);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(38, 15);
            label_Total.TabIndex = 3;
            label_Total.Text = "label4";
            // 
            // ReceiptProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_Total);
            Controls.Add(label_Qty);
            Controls.Add(label_Price);
            Controls.Add(label_Name);
            Name = "ReceiptProduct";
            Size = new Size(457, 38);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Name;
        private Label label_Price;
        private Label label_Qty;
        private Label label_Total;
    }
}
