namespace Pos
{
    partial class Pos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            panel1 = new Panel();
            label_TotalPrice = new Label();
            textBox_TotalPrice = new TextBox();
            button_Pay = new Button();
            label_Date = new Label();
            label_SupermarketName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            button_Snacks = new Button();
            button_ClearTypeSearch = new Button();
            button_Drinks = new Button();
            button_Meat = new Button();
            button_Bakery = new Button();
            button_Fruits = new Button();
            textBox_Search = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(label_Date);
            splitContainer1.Panel1.Controls.Add(label_SupermarketName);
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(textBox_Search);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer1.Size = new Size(1126, 678);
            splitContainer1.SplitterDistance = 454;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(button_Pay);
            panel3.Location = new Point(0, 541);
            panel3.Name = "panel3";
            panel3.Size = new Size(454, 137);
            panel3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_TotalPrice);
            panel1.Controls.Add(textBox_TotalPrice);
            panel1.Location = new Point(6, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 65);
            panel1.TabIndex = 1;
            // 
            // label_TotalPrice
            // 
            label_TotalPrice.AutoSize = true;
            label_TotalPrice.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_TotalPrice.Location = new Point(25, 15);
            label_TotalPrice.Name = "label_TotalPrice";
            label_TotalPrice.Size = new Size(153, 37);
            label_TotalPrice.TabIndex = 1;
            label_TotalPrice.Text = "Total Price";
            // 
            // textBox_TotalPrice
            // 
            textBox_TotalPrice.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_TotalPrice.Location = new Point(184, 12);
            textBox_TotalPrice.Name = "textBox_TotalPrice";
            textBox_TotalPrice.ReadOnly = true;
            textBox_TotalPrice.Size = new Size(255, 43);
            textBox_TotalPrice.TabIndex = 0;
            textBox_TotalPrice.Text = "0₮";
            textBox_TotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // button_Pay
            // 
            button_Pay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Pay.BackColor = Color.FromArgb(0, 192, 0);
            button_Pay.Cursor = Cursors.Hand;
            button_Pay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Pay.ForeColor = Color.White;
            button_Pay.Location = new Point(-3, 74);
            button_Pay.Name = "button_Pay";
            button_Pay.Size = new Size(451, 51);
            button_Pay.TabIndex = 2;
            button_Pay.Text = "Pay";
            button_Pay.UseVisualStyleBackColor = false;
            button_Pay.Click += button_Pay_Click;
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Date.Location = new Point(12, 47);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(40, 21);
            label_Date.TabIndex = 4;
            label_Date.Text = "date";
            // 
            // label_SupermarketName
            // 
            label_SupermarketName.AutoSize = true;
            label_SupermarketName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_SupermarketName.Location = new Point(12, 17);
            label_SupermarketName.Name = "label_SupermarketName";
            label_SupermarketName.Size = new Size(198, 30);
            label_SupermarketName.TabIndex = 3;
            label_SupermarketName.Text = "AZ SUPERMARKET";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(3, 76);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(448, 459);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(button_Snacks);
            panel2.Controls.Add(button_ClearTypeSearch);
            panel2.Controls.Add(button_Drinks);
            panel2.Controls.Add(button_Meat);
            panel2.Controls.Add(button_Bakery);
            panel2.Controls.Add(button_Fruits);
            panel2.Location = new Point(3, 541);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 137);
            panel2.TabIndex = 7;
            // 
            // button_Snacks
            // 
            button_Snacks.BackColor = SystemColors.MenuHighlight;
            button_Snacks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Snacks.ForeColor = Color.White;
            button_Snacks.Location = new Point(14, 3);
            button_Snacks.Name = "button_Snacks";
            button_Snacks.Size = new Size(102, 72);
            button_Snacks.TabIndex = 2;
            button_Snacks.Text = "Snacks";
            button_Snacks.UseVisualStyleBackColor = false;
            button_Snacks.Click += button_Types_Click;
            // 
            // button_ClearTypeSearch
            // 
            button_ClearTypeSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ClearTypeSearch.Location = new Point(538, 81);
            button_ClearTypeSearch.Name = "button_ClearTypeSearch";
            button_ClearTypeSearch.Size = new Size(102, 37);
            button_ClearTypeSearch.TabIndex = 6;
            button_ClearTypeSearch.Text = "Clear";
            button_ClearTypeSearch.UseVisualStyleBackColor = true;
            button_ClearTypeSearch.Click += button_ClearTypeSearch_Click;
            // 
            // button_Drinks
            // 
            button_Drinks.BackColor = SystemColors.MenuHighlight;
            button_Drinks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Drinks.ForeColor = Color.White;
            button_Drinks.Location = new Point(141, 3);
            button_Drinks.Name = "button_Drinks";
            button_Drinks.Size = new Size(102, 72);
            button_Drinks.TabIndex = 3;
            button_Drinks.Text = "Drinks";
            button_Drinks.UseVisualStyleBackColor = false;
            button_Drinks.Click += button_Types_Click;
            // 
            // button_Meat
            // 
            button_Meat.BackColor = SystemColors.MenuHighlight;
            button_Meat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Meat.ForeColor = Color.White;
            button_Meat.Location = new Point(538, 3);
            button_Meat.Name = "button_Meat";
            button_Meat.Size = new Size(102, 72);
            button_Meat.TabIndex = 1;
            button_Meat.Text = "Meat";
            button_Meat.UseVisualStyleBackColor = false;
            button_Meat.Click += button_Types_Click;
            // 
            // button_Bakery
            // 
            button_Bakery.BackColor = SystemColors.MenuHighlight;
            button_Bakery.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Bakery.ForeColor = Color.White;
            button_Bakery.Location = new Point(273, 3);
            button_Bakery.Name = "button_Bakery";
            button_Bakery.Size = new Size(102, 72);
            button_Bakery.TabIndex = 5;
            button_Bakery.Text = "Bakery";
            button_Bakery.UseVisualStyleBackColor = false;
            button_Bakery.Click += button_Types_Click;
            // 
            // button_Fruits
            // 
            button_Fruits.BackColor = SystemColors.MenuHighlight;
            button_Fruits.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Fruits.ForeColor = Color.White;
            button_Fruits.Location = new Point(406, 3);
            button_Fruits.Name = "button_Fruits";
            button_Fruits.Size = new Size(102, 72);
            button_Fruits.TabIndex = 4;
            button_Fruits.Text = "Fruits";
            button_Fruits.UseVisualStyleBackColor = false;
            button_Fruits.Click += button_Types_Click;
            // 
            // textBox_Search
            // 
            textBox_Search.BorderStyle = BorderStyle.FixedSingle;
            textBox_Search.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Search.Location = new Point(3, 17);
            textBox_Search.Margin = new Padding(3, 12, 3, 3);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.PlaceholderText = "Search Products";
            textBox_Search.Size = new Size(662, 43);
            textBox_Search.TabIndex = 1;
            textBox_Search.TextChanged += textBox_Search_TextChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Location = new Point(3, 76);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(662, 459);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // Pos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 678);
            Controls.Add(splitContainer1);
            Name = "Pos";
            Text = "Form1";
            Load += Pos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        public TextBox textBox_TotalPrice;
        private Label label_TotalPrice;
        private TextBox textBox_Search;
        private Button button_Bakery;
        private Button button_Fruits;
        private Button button_Drinks;
        private Button button_Snacks;
        private Button button_Meat;
        private Button button_ClearTypeSearch;
        public FlowLayoutPanel flowLayoutPanel1;
        private Button button_Pay;
        private Label label_SupermarketName;
        private Label label_Date;
        private Panel panel2;
        private Panel panel3;
    }
}
