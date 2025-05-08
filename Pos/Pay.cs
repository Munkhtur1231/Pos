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
    public partial class Pay : Form
    {
        private Pos owner;
        private Payment payment;
        public Pay(Pos owner)
        {
            InitializeComponent();
            this.owner = owner;
            payment = new Payment();
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            textBox_TotalPrice.Text = owner.orderedProductList.TotalPrice + "₮";
            payment.TotalPrice = owner.orderedProductList.TotalPrice;
        }

        private void textBox_PaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (textBox_PaidAmount.Text == "")
            {
                textBox_Change.Text = "0₮";
                return;
            }
            payment.PaidAmount = double.Parse(textBox_PaidAmount.Text);
            payment.calc();
            textBox_Change.Text = payment.Change + "₮";
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (payment.PaidAmount < payment.TotalPrice)
            {
                MessageBox.Show("Төлбөрийн дүн буруу байна.");
                return;
            }

            owner.flowLayoutPanel1.Controls.Clear();
            owner.textBox_TotalPrice.Text = 0 + "₮";

            Receipt receipt = new Receipt(payment, owner.orderedProductList);
            receipt.TopMost = true;
            receipt.BringToFront();
            receipt.Show();

            Close();
        }
    }
}
