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
            label_TotalPrice = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 43);
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
            button_Confirm.Location = new Point(12, 107);
            button_Confirm.Name = "button_Confirm";
            button_Confirm.Size = new Size(283, 55);
            button_Confirm.TabIndex = 1;
            button_Confirm.Text = "Confirm";
            button_Confirm.UseVisualStyleBackColor = false;
            button_Confirm.Click += button_Confirm_Click;
            // 
            // label_TotalPrice
            // 
            label_TotalPrice.AutoSize = true;
            label_TotalPrice.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TotalPrice.Location = new Point(176, 43);
            label_TotalPrice.Name = "label_TotalPrice";
            label_TotalPrice.Size = new Size(33, 37);
            label_TotalPrice.TabIndex = 2;
            label_TotalPrice.Text = "0";
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(307, 194);
            Controls.Add(label_TotalPrice);
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
        private Label label_TotalPrice;
    }
}