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
    public partial class Receipt : Form
    {
        Payment payment;
        OrderedProductList orderedProductList;

        public Receipt(Payment p, OrderedProductList o)
        {
            InitializeComponent();

            payment = p;
            orderedProductList = o;
            label_Date.Text += " " + DateTime.Now.ToString();
            label_Total.Text =  payment.TotalPrice.ToString() + "₮";
            label_Paid.Text =  payment.PaidAmount.ToString() + "₮";
            label_Change.Text =  payment.Change.ToString() + "₮";

            DrawReceiptProduct();
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            var printer = new Print();
            printer.PrintReceipt(orderedProductList);

            orderedProductList.clear();
            Close();
        }

        private void DrawReceiptProduct()
        {
            foreach (var product in orderedProductList.OrderedProducts)
            {
                ReceiptProduct receiptProduct = new ReceiptProduct(product);
                receiptProduct.Location = new Point(3, 3);
                receiptProduct.Name = "receiptProduct1";
                receiptProduct.Size = new Size(471, 34);
                receiptProduct.TabIndex = 0;

                flowLayoutPanel1.Controls.Add(receiptProduct);
            }
        }
    }
}