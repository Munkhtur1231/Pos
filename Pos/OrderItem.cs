using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pos
{
    public partial class OrderItem : UserControl
    {
        public OrderedProduct orderedProduct;
        private Pos owner;
        public OrderItem()
        {
            InitializeComponent();
        }
        public OrderItem(OrderedProduct orderedProduct, Pos owner)
        {
            InitializeComponent();
            this.orderedProduct = orderedProduct;
            label_ProductName.Text = orderedProduct.Name.ToString();
            textBox_Qty.Text = orderedProduct.Quantity.ToString();
            label_UnitPrice.Text = orderedProduct.Price.ToString();
            label_TotalPrice.Text = orderedProduct.TotalPrice.ToString();
            this.owner = owner;
        }
        private void RadialButton_Click(object sender, RadialClickEventArgs e)
        {
            // Nemeh 
            if (e.isPlus)
            {
                orderedProduct.Quantity++;
                textBox_Qty.Text = int.Parse(textBox_Qty.Text) + 1 + "";
                owner.textBox_TotalPrice.Text = owner.orderedProductList.TotalPrice + "₮";
                return;
            }
            // Hasah bol 1 ees baga bol ordered listnees uuriig ni hasna
            if (orderedProduct.Quantity <= 1)
            {
                owner.orderedProductList.removeOrderedProduct(orderedProduct);
                owner.flowLayoutPanel1.Controls.Remove(this);
                owner.textBox_TotalPrice.Text = owner.orderedProductList.TotalPrice + "₮";
                return;
            };
            // 1 ees ih bol too qty bagasgaj TotalPrice bodno
            orderedProduct.Quantity--;
            textBox_Qty.Text = int.Parse(textBox_Qty.Text) - 1 + "";
            owner.textBox_TotalPrice.Text = owner.orderedProductList.TotalPrice + "₮";
        }

        private void textBox_Qty_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!int.TryParse(textBox_Qty.Text, out i)) return; // too bish bol return
            if (i == 0)  // too bgaad ter ni 0 bol uuriiguu ustgana
            {
                owner.orderedProductList.removeOrderedProduct(orderedProduct);
                owner.flowLayoutPanel1.Controls.Remove(this);
                owner.textBox_TotalPrice.Text = owner.orderedProductList.TotalPrice + "₮";
                return;
            }
            orderedProduct.Quantity = int.Parse(textBox_Qty.Text);
            label_TotalPrice.Text = orderedProduct.TotalPrice + "";
        }
    }
}
