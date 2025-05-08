using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PosLibrary;

namespace Pos
{
    public partial class ReceiptProduct : UserControl
    {
        public OrderedProduct orderedProduct;
        public ReceiptProduct()
        {
            InitializeComponent();
            
        }

        public ReceiptProduct(OrderedProduct o) {
            InitializeComponent();

            orderedProduct = o;

            label_Name.Text = orderedProduct.Name;
            label_Qty.Text = orderedProduct.Quantity.ToString();
            label_Price.Text = orderedProduct.Price.ToString() + "₮";
            label_Total.Text = orderedProduct.TotalPrice.ToString() + "₮";
        }
    }
}
