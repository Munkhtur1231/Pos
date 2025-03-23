using Pos.Properties;

namespace Pos
{
    public partial class Pos : Form
    {
        MenuProducts menuProducts;
        public OrderedProductList orderedProductList;
        public Pos()
        {
            InitializeComponent();
            menuProducts = new MenuProducts();
            orderedProductList = new OrderedProductList();
        }

        private void DrawProduct(List<Product> products)
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
                btn.Image = product.Image;
                btn.TextImageRelation = TextImageRelation.ImageAboveText;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.UseVisualStyleBackColor = true;
                btn.Click += Product_Click;
                btn.Tag = product;

                flowLayoutPanel2.Controls.Add(btn);
            }
        }

        private void Pos_Load(object sender, EventArgs e)
        {
            menuProducts.addProduct(new Product(1, "KitKat", 3500, "Snacks", Properties.Resources.Product_KitKat));
            menuProducts.addProduct(new Product(2, "Doritos", 7300, "Snacks", Properties.Resources.Product_Doritos));
            menuProducts.addProduct(new Product(3, "Snickers", 4000, "Snacks", Properties.Resources.Product_Snickers));
            menuProducts.addProduct(new Product(4, "Reese", 2100, "Snacks", Properties.Resources.Product_Reese));

            menuProducts.addProduct(new Product(5, "Apple", 4200, "Fruits", Properties.Resources.Product_Apple));
            menuProducts.addProduct(new Product(6, "Orange", 3700, "Fruits", Properties.Resources.Product_Orange));
            menuProducts.addProduct(new Product(7, "Pineapple", 2500, "Fruits", Properties.Resources.Product_Pineapple));

            menuProducts.addProduct(new Product(8, "Milk", 1900, "Drinks", Properties.Resources.Product_Milk));
            menuProducts.addProduct(new Product(9, "Coca Cola", 4000, "Drinks", Properties.Resources.Product_CocaCola));
            menuProducts.addProduct(new Product(10, "Green tea", 2500, "Drinks", Properties.Resources.Product_GreenTea));
            menuProducts.addProduct(new Product(11, "Water", 1100, "Drinks", Properties.Resources.Product_Water));

            menuProducts.addProduct(new Product(12, "Beef", 21000, "Meat", Properties.Resources.Product_Beef_Topside));
            menuProducts.addProduct(new Product(13, "Chicken wings", 13000, "Meat", Properties.Resources.Product_ChickenWings));
            menuProducts.addProduct(new Product(14, "Sausage", 7000, "Meat", Properties.Resources.Product_Sausage));

            menuProducts.addProduct(new Product(15, "Bread", 2500, "Bakery", Properties.Resources.Product_Bread));
            menuProducts.addProduct(new Product(16, "Donut", 3200, "Bakery", Properties.Resources.Product_Donut));
            menuProducts.addProduct(new Product(17, "Pie", 8900, "Bakery", Properties.Resources.Product_Pie));

            DrawProduct(menuProducts.products);
            label_Date.Text = DateTime.Now.ToString();
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
    }
}
