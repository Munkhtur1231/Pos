namespace PosControl
{
    partial class TotalPrice
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
            label_TotalPrice = new Label();
            textBox_TotalPrice = new TextBox();
            SuspendLayout();
            // 
            // label_TotalPrice
            // 
            label_TotalPrice.AutoSize = true;
            label_TotalPrice.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TotalPrice.Location = new Point(3, 9);
            label_TotalPrice.Name = "label_TotalPrice";
            label_TotalPrice.Size = new Size(153, 37);
            label_TotalPrice.TabIndex = 0;
            label_TotalPrice.Text = "Total Price";
            // 
            // textBox_TotalPrice
            // 
            textBox_TotalPrice.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_TotalPrice.Location = new Point(162, 9);
            textBox_TotalPrice.Name = "textBox_TotalPrice";
            textBox_TotalPrice.Size = new Size(147, 43);
            textBox_TotalPrice.TabIndex = 1;
            textBox_TotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // TotalPrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox_TotalPrice);
            Controls.Add(label_TotalPrice);
            Name = "TotalPrice";
            Size = new Size(329, 61);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_TotalPrice;
        public TextBox textBox_TotalPrice;
    }
}
