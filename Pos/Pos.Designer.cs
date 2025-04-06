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
            button_ClearTypeSearch = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel_UserMenu = new Panel();
            button_Help = new Button();
            button_ShowProductList = new Button();
            button_User = new Button();
            textBox_Search = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel_UserMenu.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(button_ClearTypeSearch);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel3);
            splitContainer1.Panel2.Controls.Add(panel_UserMenu);
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
            label_Date.Location = new Point(12, 55);
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
            label_SupermarketName.Size = new Size(262, 30);
            label_SupermarketName.TabIndex = 3;
            label_SupermarketName.Text = "WELBEE's SUPERMARKET";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(3, 87);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(448, 448);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button_ClearTypeSearch
            // 
            button_ClearTypeSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ClearTypeSearch.Location = new Point(552, 629);
            button_ClearTypeSearch.Name = "button_ClearTypeSearch";
            button_ClearTypeSearch.Size = new Size(102, 37);
            button_ClearTypeSearch.TabIndex = 6;
            button_ClearTypeSearch.Text = "Clear";
            button_ClearTypeSearch.UseVisualStyleBackColor = true;
            button_ClearTypeSearch.Click += button_ClearTypeSearch_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(7, 544);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(647, 79);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // panel_UserMenu
            // 
            panel_UserMenu.AllowDrop = true;
            panel_UserMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_UserMenu.Controls.Add(button_Help);
            panel_UserMenu.Controls.Add(button_ShowProductList);
            panel_UserMenu.Controls.Add(button_User);
            panel_UserMenu.Location = new Point(563, 3);
            panel_UserMenu.MaximumSize = new Size(93, 110);
            panel_UserMenu.MinimumSize = new Size(93, 36);
            panel_UserMenu.Name = "panel_UserMenu";
            panel_UserMenu.Size = new Size(93, 36);
            panel_UserMenu.TabIndex = 8;
            // 
            // button_Help
            // 
            button_Help.BackColor = Color.WhiteSmoke;
            button_Help.Location = new Point(0, 73);
            button_Help.Name = "button_Help";
            button_Help.Size = new Size(93, 37);
            button_Help.TabIndex = 2;
            button_Help.Text = "Help";
            button_Help.UseVisualStyleBackColor = false;
            button_Help.Click += button_Help_Click;
            // 
            // button_ShowProductList
            // 
            button_ShowProductList.BackColor = Color.WhiteSmoke;
            button_ShowProductList.Location = new Point(0, 35);
            button_ShowProductList.Name = "button_ShowProductList";
            button_ShowProductList.Size = new Size(93, 43);
            button_ShowProductList.TabIndex = 1;
            button_ShowProductList.Text = "Products";
            button_ShowProductList.UseVisualStyleBackColor = false;
            button_ShowProductList.Click += button_ShowProductList_Click;
            // 
            // button_User
            // 
            button_User.BackColor = Color.WhiteSmoke;
            button_User.Location = new Point(0, 0);
            button_User.Name = "button_User";
            button_User.Size = new Size(93, 35);
            button_User.TabIndex = 0;
            button_User.Text = "User";
            button_User.UseVisualStyleBackColor = false;
            button_User.Click += button_User_Click;
            // 
            // textBox_Search
            // 
            textBox_Search.BorderStyle = BorderStyle.FixedSingle;
            textBox_Search.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Search.Location = new Point(3, 46);
            textBox_Search.Margin = new Padding(3, 12, 3, 3);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.PlaceholderText = "Search Products";
            textBox_Search.Size = new Size(662, 35);
            textBox_Search.TabIndex = 1;
            textBox_Search.TextChanged += textBox_Search_TextChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Location = new Point(3, 87);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(662, 448);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // Pos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 678);
            Controls.Add(splitContainer1);
            Name = "Pos";
            StartPosition = FormStartPosition.CenterScreen;
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
            panel_UserMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        public TextBox textBox_TotalPrice;
        private Label label_TotalPrice;
        private TextBox textBox_Search;
        private Button button_ClearTypeSearch;
        public FlowLayoutPanel flowLayoutPanel1;
        private Button button_Pay;
        private Label label_SupermarketName;
        private Label label_Date;
        private Panel panel3;
        private Panel panel_UserMenu;
        private Button button_Help;
        private Button button_ShowProductList;
        public Button button_User;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}
