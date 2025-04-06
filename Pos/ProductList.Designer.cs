using PosLibrary;

namespace Pos
{
    partial class ProductList
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
            components = new System.ComponentModel.Container();
            productGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Image = new DataGridViewImageColumn();
            ProductbindingSource = new BindingSource(components);
            textBox_Name = new TextBox();
            textBox_Price = new TextBox();
            comboBox_Type = new ComboBox();
            button_AddProduct = new Button();
            button_Update = new Button();
            button_Delete = new Button();
            comboBox_Filter = new ComboBox();
            label_Filter = new Label();
            button_UploadImage = new Button();
            ((System.ComponentModel.ISupportInitialize)productGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductbindingSource).BeginInit();
            SuspendLayout();
            // 
            // productGridView
            // 
            productGridView.AutoGenerateColumns = false;
            productGridView.BackgroundColor = SystemColors.GradientActiveCaption;
            productGridView.ColumnHeadersHeight = 30;
            productGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, Image });
            productGridView.DataSource = ProductbindingSource;
            productGridView.Dock = DockStyle.Bottom;
            productGridView.Location = new Point(0, 154);
            productGridView.MultiSelect = false;
            productGridView.Name = "productGridView";
            productGridView.RowHeadersWidth = 50;
            productGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productGridView.Size = new Size(870, 402);
            productGridView.TabIndex = 0;
            productGridView.DoubleClick += productGridView_DoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 160;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 160;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 160;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.Width = 160;
            // 
            // Image
            // 
            Image.DataPropertyName = "Image";
            Image.HeaderText = "Image";
            Image.Name = "Image";
            Image.Width = 175;
            // 
            // ProductbindingSource
            // 
            ProductbindingSource.DataSource = typeof(Product);
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(12, 102);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.PlaceholderText = "Product name";
            textBox_Name.Size = new Size(100, 23);
            textBox_Name.TabIndex = 1;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(139, 102);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.PlaceholderText = "Price";
            textBox_Price.Size = new Size(100, 23);
            textBox_Price.TabIndex = 2;
            // 
            // comboBox_Type
            // 
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Items.AddRange(new object[] { "Snacks", "Drinks", "Bakery", "Fruits", "Meat" });
            comboBox_Type.Location = new Point(268, 102);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(107, 23);
            comboBox_Type.TabIndex = 3;
            // 
            // button_AddProduct
            // 
            button_AddProduct.Location = new Point(523, 102);
            button_AddProduct.Name = "button_AddProduct";
            button_AddProduct.Size = new Size(95, 23);
            button_AddProduct.TabIndex = 4;
            button_AddProduct.Text = "Add Product";
            button_AddProduct.UseVisualStyleBackColor = true;
            button_AddProduct.Click += button_AddProduct_Click;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(633, 101);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(100, 23);
            button_Update.TabIndex = 5;
            button_Update.Text = "Update Selected Product";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(752, 101);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(104, 23);
            button_Delete.TabIndex = 6;
            button_Delete.Text = "Delete Selected Product";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // comboBox_Filter
            // 
            comboBox_Filter.FormattingEnabled = true;
            comboBox_Filter.Items.AddRange(new object[] { "Snacks", "Drinks", "Bakery", "Fruits", "Meat", "All" });
            comboBox_Filter.Location = new Point(139, 23);
            comboBox_Filter.Name = "comboBox_Filter";
            comboBox_Filter.Size = new Size(121, 23);
            comboBox_Filter.TabIndex = 7;
            comboBox_Filter.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // label_Filter
            // 
            label_Filter.AutoSize = true;
            label_Filter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Filter.Location = new Point(12, 23);
            label_Filter.Name = "label_Filter";
            label_Filter.Size = new Size(110, 21);
            label_Filter.TabIndex = 8;
            label_Filter.Text = "Filter by type";
            // 
            // button_UploadImage
            // 
            button_UploadImage.Location = new Point(402, 102);
            button_UploadImage.Name = "button_UploadImage";
            button_UploadImage.Size = new Size(105, 23);
            button_UploadImage.TabIndex = 9;
            button_UploadImage.Text = "Upload image";
            button_UploadImage.UseVisualStyleBackColor = true;
            button_UploadImage.Click += button_UploadImage_Click;
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 556);
            Controls.Add(button_UploadImage);
            Controls.Add(label_Filter);
            Controls.Add(comboBox_Filter);
            Controls.Add(button_Delete);
            Controls.Add(button_Update);
            Controls.Add(button_AddProduct);
            Controls.Add(comboBox_Type);
            Controls.Add(textBox_Price);
            Controls.Add(textBox_Name);
            Controls.Add(productGridView);
            Name = "ProductList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductList";
            ((System.ComponentModel.ISupportInitialize)productGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductbindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        public DataGridView productGridView;
        public BindingSource ProductbindingSource;
        private TextBox textBox_Name;
        private TextBox textBox_Price;
        private ComboBox comboBox_Type;
        private Button button_AddProduct;
        private Button button_Update;
        private Button button_Delete;
        private ComboBox comboBox_Filter;
        private Label label_Filter;
        private Button button_UploadImage;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Image;
    }
}