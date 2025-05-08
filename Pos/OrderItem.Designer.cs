namespace Pos
{
    partial class OrderItem
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
            panel1 = new Panel();
            label_ProductName = new Label();
            panel2 = new Panel();
            label_UnitPrice = new Label();
            panel3 = new Panel();
            label_TotalPrice = new Label();
            panel4 = new Panel();
            radialButton2 = new RadialButton();
            radialButton1 = new RadialButton();
            textBox_Qty = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label_ProductName);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(88, 37);
            panel1.TabIndex = 0;
            // 
            // label_ProductName
            // 
            label_ProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_ProductName.AutoSize = true;
            label_ProductName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ProductName.Location = new Point(3, 7);
            label_ProductName.Name = "label_ProductName";
            label_ProductName.Size = new Size(79, 21);
            label_ProductName.TabIndex = 0;
            label_ProductName.Text = "Product1";
            // 
            // panel2
            // 
            panel2.Controls.Add(label_UnitPrice);
            panel2.Location = new Point(97, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(70, 37);
            panel2.TabIndex = 1;
            // 
            // label_UnitPrice
            // 
            label_UnitPrice.AutoSize = true;
            label_UnitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_UnitPrice.Location = new Point(12, 7);
            label_UnitPrice.Name = "label_UnitPrice";
            label_UnitPrice.Size = new Size(46, 21);
            label_UnitPrice.TabIndex = 0;
            label_UnitPrice.Text = "1000";
            // 
            // panel3
            // 
            panel3.Controls.Add(label_TotalPrice);
            panel3.Location = new Point(353, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(56, 37);
            panel3.TabIndex = 2;
            // 
            // label_TotalPrice
            // 
            label_TotalPrice.AutoSize = true;
            label_TotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TotalPrice.Location = new Point(3, 7);
            label_TotalPrice.Name = "label_TotalPrice";
            label_TotalPrice.Size = new Size(46, 21);
            label_TotalPrice.TabIndex = 0;
            label_TotalPrice.Text = "1000";
            // 
            // panel4
            // 
            panel4.Controls.Add(radialButton2);
            panel4.Controls.Add(radialButton1);
            panel4.Controls.Add(textBox_Qty);
            panel4.Location = new Point(173, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 37);
            panel4.TabIndex = 3;
            // 
            // radialButton2
            // 
            radialButton2.isPlus = true;
            radialButton2.Location = new Point(140, 7);
            radialButton2.Name = "radialButton2";
            radialButton2.Size = new Size(25, 27);
            radialButton2.TabIndex = 6;
            radialButton2.RadialClick += RadialButton_Click;
            // 
            // radialButton1
            // 
            radialButton1.isPlus = false;
            radialButton1.Location = new Point(3, 7);
            radialButton1.Name = "radialButton1";
            radialButton1.Size = new Size(25, 27);
            radialButton1.TabIndex = 5;
            radialButton1.RadialClick += RadialButton_Click;
            // 
            // textBox_Qty
            // 
            textBox_Qty.Location = new Point(34, 7);
            textBox_Qty.Name = "textBox_Qty";
            textBox_Qty.Size = new Size(100, 23);
            textBox_Qty.TabIndex = 4;
            textBox_Qty.Text = "0";
            textBox_Qty.TextAlign = HorizontalAlignment.Right;
            textBox_Qty.TextChanged += textBox_Qty_TextChanged;
            // 
            // OrderItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrderItem";
            Size = new Size(416, 37);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label_UnitPrice;
        private Label label_TotalPrice;
        private RadialButton radialButton1;
        private RadialButton radialButton2;
        public Label label_ProductName;
        public TextBox textBox_Qty;
    }
}
