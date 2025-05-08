namespace Pos
{
    partial class Pay
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
            button_Confirm = new Button();
            label2 = new Label();
            textBox_PaidAmount = new TextBox();
            label3 = new Label();
            textBox_TotalPrice = new TextBox();
            textBox_Change = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 76);
            label1.Name = "label1";
            label1.Size = new Size(82, 37);
            label1.TabIndex = 0;
            label1.Text = "Total";
            // 
            // button_Confirm
            // 
            button_Confirm.BackColor = Color.SpringGreen;
            button_Confirm.Cursor = Cursors.Hand;
            button_Confirm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Confirm.Location = new Point(131, 267);
            button_Confirm.Name = "button_Confirm";
            button_Confirm.Size = new Size(283, 55);
            button_Confirm.TabIndex = 1;
            button_Confirm.Text = "Confirm";
            button_Confirm.UseVisualStyleBackColor = false;
            button_Confirm.Click += button_Confirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 132);
            label2.Name = "label2";
            label2.Size = new Size(180, 37);
            label2.TabIndex = 3;
            label2.Text = "Paid amount";
            // 
            // textBox_PaidAmount
            // 
            textBox_PaidAmount.BackColor = Color.White;
            textBox_PaidAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_PaidAmount.Location = new Point(309, 142);
            textBox_PaidAmount.Name = "textBox_PaidAmount";
            textBox_PaidAmount.Size = new Size(127, 29);
            textBox_PaidAmount.TabIndex = 4;
            textBox_PaidAmount.TextAlign = HorizontalAlignment.Right;
            textBox_PaidAmount.TextChanged += textBox_PaidAmount_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 193);
            label3.Name = "label3";
            label3.Size = new Size(113, 37);
            label3.TabIndex = 5;
            label3.Text = "Change";
            // 
            // textBox_TotalPrice
            // 
            textBox_TotalPrice.BackColor = Color.White;
            textBox_TotalPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_TotalPrice.Location = new Point(309, 76);
            textBox_TotalPrice.Name = "textBox_TotalPrice";
            textBox_TotalPrice.ReadOnly = true;
            textBox_TotalPrice.Size = new Size(127, 27);
            textBox_TotalPrice.TabIndex = 7;
            textBox_TotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox_Change
            // 
            textBox_Change.BackColor = Color.White;
            textBox_Change.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Change.Location = new Point(309, 201);
            textBox_Change.Name = "textBox_Change";
            textBox_Change.ReadOnly = true;
            textBox_Change.Size = new Size(127, 29);
            textBox_Change.TabIndex = 8;
            textBox_Change.TextAlign = HorizontalAlignment.Right;
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(542, 376);
            Controls.Add(textBox_Change);
            Controls.Add(textBox_TotalPrice);
            Controls.Add(label3);
            Controls.Add(textBox_PaidAmount);
            Controls.Add(label2);
            Controls.Add(button_Confirm);
            Controls.Add(label1);
            Name = "Pay";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pay";
            Load += Pay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_Confirm;
        private Label label2;
        private TextBox textBox_PaidAmount;
        private Label label3;
        private TextBox textBox_TotalPrice;
        private TextBox textBox_Change;
    }
}