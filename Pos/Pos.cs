using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Pos.data;
using PosLibrary;

namespace Pos
{
    public partial class Pos : Form
    {
        public MenuProducts menuProducts;
        public List<string> productTypes;
        public OrderedProductList orderedProductList;
        public ProductList productList;  // List harah form
        public User user;
        bool isCollapsed = true; // User menu

        SqliteConnection connection;
        public ProductsContext productContext;

        SqliteCommand selectAllProduct;


        public Pos()
        {
            InitializeComponent();
            menuProducts = new MenuProducts();
            orderedProductList = new OrderedProductList();
            

            connection = new("Data Source=products.db");

            selectAllProduct = new("SELECT * FROM Product", connection);

            productContext = new();

        }

        public void DrawProduct(List<Product> products)
        {
            flowLayoutPanel2.Controls.Clear();
            foreach (var product in products)
            {
                Button btn = new Button();
                btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                btn.Location = new Point(3, 3);
                btn.Size = new Size(140, 120);
                btn.TabIndex = 0;
                btn.Text = product.Name + " " + product.Price + "₮";
                if (product.Image != null) btn.Image = ConvertByteArrayToImage(product.Image);
                btn.TextImageRelation = TextImageRelation.ImageAboveText;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.UseVisualStyleBackColor = true;
                btn.Click += Product_Click;
                btn.Tag = product;

                flowLayoutPanel2.Controls.Add(btn);
            }
        }

        public void DrawProductType()
        {
            productTypes = menuProducts.getTypes();

            flowLayoutPanel3.Controls.Clear();
            foreach (var type in productTypes)
            {
                Button btn = new Button();

                btn.BackColor = SystemColors.MenuHighlight;
                btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                btn.ForeColor = Color.White;
                btn.Location = new Point(3, 3);
                btn.Name = "button_" + type;
                btn.Size = new Size(102, 72);
                btn.TabIndex = 2;
                btn.Text = type;
                btn.UseVisualStyleBackColor = false;
                btn.Click += button_Types_Click;

                flowLayoutPanel3.Controls.Add(btn);
            }
        }

        public Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void Pos_Load(object sender, EventArgs e)
        {

            Login loginForm = new Login(this);
            loginForm.ShowDialog();

            updateMenuProducts();

            


            DrawProduct(menuProducts.products);
            DrawProductType();

            label_Date.Text = DateTime.Now.ToString();

        }

        public void updateMenuProducts()
        {
            connection.Open();

            SqliteDataReader reader = selectAllProduct.ExecuteReader();

            while (reader.Read())
            {
                menuProducts.addProduct(new Product
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetDouble(2),
                    Type = reader.GetString(3),
                    Image = reader.IsDBNull(4) ? null : (byte[])reader.GetValue(4)  // Handle null image
                });
            }
            connection.Close();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            // Daragdsan buttonii Tag dotorh productiin Id-g avna
            Button btn = ((Button)sender);
            double id = ((Product)btn.Tag).Id;
            OrderedProduct orderedProduct;
            // Id-aar ni umnu ni order list ruu nemegdsen esehiig shalgana
            if (orderedProductList.isOrdered(id))
            {
                orderedProduct = orderedProductList.getById(id);
                orderedProduct.Quantity++;

                var btnFound = flowLayoutPanel1.Controls
                    .Cast<OrderItem>()
                    .FirstOrDefault(e => (e.orderedProduct.Id == id));
                if (btnFound != null)
                {
                    btnFound.textBox_Qty.Text = int.Parse(btnFound.textBox_Qty.Text) + 1 + "";
                }
                textBox_TotalPrice.Text = orderedProductList.TotalPrice + "₮";
                return;
            }

            // Nemegdeegui bol shineer uusgej hiine
            orderedProduct = new OrderedProduct(id, ((Product)btn.Tag).Name, 1, ((Product)btn.Tag).Price);
            OrderItem orderItem = new OrderItem(orderedProduct, this);
            orderedProductList.addOrderedProduct(orderedProduct);
            flowLayoutPanel1.Controls.Add(orderItem);
            textBox_TotalPrice.Text = orderedProductList.TotalPrice + "₮";
        }



        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            DrawProduct(menuProducts.getByName(textBox_Search.Text));
        }

        private void button_Types_Click(object sender, EventArgs e)
        {
            DrawProduct(menuProducts.getByType(((Button)sender).Text));
        }

        private void button_ClearTypeSearch_Click(object sender, EventArgs e)
        {
            DrawProduct(menuProducts.products);
        }

        private void button_Pay_Click(object sender, EventArgs e)
        {
            Pay payForm = new Pay(this);
            payForm.ShowDialog();
        }

        private void button_User_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_UserMenu.Size = panel_UserMenu.MaximumSize;
                isCollapsed = false;
            }
            else
            {
                panel_UserMenu.Size = panel_UserMenu.MinimumSize;
                isCollapsed = true;
            }
        }

        private void button_ShowProductList_Click(object sender, EventArgs e)
        {
            productList = new ProductList(this);
            productList.ProductbindingSource.DataSource = productContext.Products.ToList();
            productList.productGridView.DataSource = productContext.Products.ToList();
            productList.Show();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {

        }
    }
}
