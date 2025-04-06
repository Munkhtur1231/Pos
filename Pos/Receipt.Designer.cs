namespace Pos
{
    partial class Receipt
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label_Date = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button_Print = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label_Total = new Label();
            label_Paid = new Label();
            label_Change = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 9);
            label1.Name = "label1";
            label1.Size = new Size(338, 37);
            label1.TabIndex = 0;
            label1.Text = "WELBEE's SUPERMARKET";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(6, 131);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(474, 280);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Date.Location = new Point(12, 68);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(42, 17);
            label_Date.TabIndex = 2;
            label_Date.Text = "Date: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(345, 425);
            label10.Name = "label10";
            label10.Size = new Size(43, 17);
            label10.TabIndex = 3;
            label10.Text = "Total:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(345, 456);
            label11.Name = "label11";
            label11.Size = new Size(39, 17);
            label11.TabIndex = 4;
            label11.Text = "Paid:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(326, 488);
            label12.Name = "label12";
            label12.Size = new Size(58, 17);
            label12.TabIndex = 5;
            label12.Text = "Change:";
            // 
            // button_Print
            // 
            button_Print.BackColor = Color.SteelBlue;
            button_Print.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Print.Location = new Point(99, 531);
            button_Print.Name = "button_Print";
            button_Print.Size = new Size(269, 50);
            button_Print.TabIndex = 6;
            button_Print.Text = "Print";
            button_Print.UseVisualStyleBackColor = false;
            button_Print.Click += button_Print_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 103);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 7;
            label6.Text = "Product name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(202, 100);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 8;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(305, 100);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 9;
            label8.Text = "Quantity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(417, 100);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 10;
            label9.Text = "Total";
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Location = new Point(413, 427);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(38, 15);
            label_Total.TabIndex = 11;
            label_Total.Text = "label2";
            // 
            // label_Paid
            // 
            label_Paid.AutoSize = true;
            label_Paid.Location = new Point(413, 458);
            label_Paid.Name = "label_Paid";
            label_Paid.Size = new Size(38, 15);
            label_Paid.TabIndex = 12;
            label_Paid.Text = "label3";
            // 
            // label_Change
            // 
            label_Change.AutoSize = true;
            label_Change.Location = new Point(413, 490);
            label_Change.Name = "label_Change";
            label_Change.Size = new Size(38, 15);
            label_Change.TabIndex = 13;
            label_Change.Text = "label4";
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 603);
            Controls.Add(label_Change);
            Controls.Add(label_Paid);
            Controls.Add(label_Total);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button_Print);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label_Date);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label_Date;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button_Print;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label_Total;
        private Label label_Paid;
        private Label label_Change;
    }
}