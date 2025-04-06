using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Pos.data;

namespace Pos
{
    public partial class ProductList : Form
    {

        SqliteConnection connection;
        SqliteCommand insertProduct;
        SqliteCommand deleteProduct;
        SqliteCommand updateProduct;

        Pos owner;
        DataGridViewRow selectedRow;

        public ProductList(Pos o)
        {
            InitializeComponent();
            owner = o;

            connection = new("Data Source=products.db");

            insertProduct = new("insert into Product (name, price, type, image) values (@name, @price, @type, @image)", connection);
            insertProduct.Parameters.Add("@name", SqliteType.Text);
            insertProduct.Parameters.Add("@price", SqliteType.Real);
            insertProduct.Parameters.Add("@type", SqliteType.Text);
            insertProduct.Parameters.Add("@image", SqliteType.Blob);

            deleteProduct = new SqliteCommand("delete from Product where id=@prod_id", connection);
            deleteProduct.Parameters.Add("@prod_id", SqliteType.Integer);

            updateProduct = new("update Product set name=@name, price=@price, type=@type, image=@image where id=@prod_id", connection);
            updateProduct.Parameters.Add("@prod_id", SqliteType.Integer);
            updateProduct.Parameters.Add("@name", SqliteType.Text);
            updateProduct.Parameters.Add("@price", SqliteType.Real);
            updateProduct.Parameters.Add("@type", SqliteType.Text);
            updateProduct.Parameters.Add("@image", SqliteType.Blob);

        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            if (!isManager()) return;
            if (textBox_Name.Text == "" || textBox_Price.Text == "" || comboBox_Type.Text == "")
            {
                MessageBox.Show("Бүх талбарыг бөглөнө үү.");
                return;
            }
            if (owner.productContext.Products.Any(p => p.Name == textBox_Name.Text))
            {
                MessageBox.Show("Бараа аль хэдийн байна.");
                return;
            }
            insertProduct.Parameters["@name"].Value = textBox_Name.Text;
            insertProduct.Parameters["@price"].Value = Double.Parse(textBox_Price.Text);
            insertProduct.Parameters["@type"].Value = comboBox_Type.Text;
            //insertProduct.Parameters["@image"].Value = DBNull.Value;

            connection.Open();
            try
            {
                insertProduct.ExecuteNonQuery();
                owner.productContext.SaveChanges();
                owner.menuProducts.addProduct(new Product
                {
                    Name = textBox_Name.Text,
                    Price = Double.Parse(textBox_Price.Text),
                    Type = comboBox_Type.Text,
                    Image = null
                });
                productGridView.DataSource = owner.productContext.Products.ToList();
                owner.DrawProductType();
                owner.DrawProduct(owner.productContext.Products.ToList());
                MessageBox.Show("Барааг амжилттай нэмлээ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            textBox_Name.Text = "";
            textBox_Price.Text = "";
            comboBox_Type.Text = "";


        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (!isManager()) return;
            if (selectedRow == null)
            {
                MessageBox.Show("Устгах бараагаа сонгоно уу.");
                return;
            }

            deleteProduct.Parameters["@prod_id"].Value = int.Parse(selectedRow.Cells[0].Value.ToString());

            connection.Open();

            try
            {
                deleteProduct.ExecuteNonQuery();
                owner.productContext.SaveChanges();
                productGridView.DataSource = owner.productContext.Products.ToList();
                
                owner.updateMenuProducts();
                owner.DrawProductType();
                owner.DrawProduct(owner.productContext.Products.ToList());
                MessageBox.Show("Барааг амжилттай устгалаа.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void productGridView_DoubleClick(object sender, EventArgs e)
        {
            if (productGridView.SelectedRows.Count != 0)
            {
                selectedRow = productGridView.SelectedRows[0];
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (!isManager()) return;
            if (selectedRow == null)
            {
                MessageBox.Show("Шинэчлэх бараагаа сонгоно уу.");
                return;
            }
            if (textBox_Name.Text == "" || textBox_Price.Text == "" || comboBox_Type.Text == "")
            {
                MessageBox.Show("Бүх талбарыг бөглөнө үү.");
                return;
            }
            if (selectedRow.Cells[1].Value.ToString() != textBox_Name.Text && owner.productContext.Products.Any(p => p.Name == textBox_Name.Text))
            {
                MessageBox.Show("Бараа аль хэдийн орсон байна.");
                return;
            }

            updateProduct.Parameters["@prod_id"].Value = int.Parse(selectedRow.Cells[0].Value.ToString());
            updateProduct.Parameters["@name"].Value = textBox_Name.Text;
            updateProduct.Parameters["@price"].Value = Double.Parse(textBox_Price.Text);
            updateProduct.Parameters["@type"].Value = comboBox_Type.Text;
            //updateProduct.Parameters["@image"].Value = DBNull.Value;

            connection.Open();

            try
            {
                updateProduct.ExecuteNonQuery();
                owner.productContext.SaveChanges();
                productGridView.DataSource = owner.productContext.Products.ToList();

                owner.updateMenuProducts();
                owner.DrawProductType();
                owner.DrawProduct(owner.productContext.Products.ToList());
                MessageBox.Show("Барааг амжилттай шинэчэллээ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Filter.Text == "All")
            {
                productGridView.DataSource = owner.productContext.Products.ToList();
                return;
            }
            productGridView.DataSource = owner.productContext.Products.Where(p => p.Type == comboBox_Filter.Text).ToList();
        }

        private void button_UploadImage_Click(object sender, EventArgs e)
        {
            if (!isManager()) return;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] imageData = System.IO.File.ReadAllBytes(dialog.FileName);
                    insertProduct.Parameters["@image"].Value = imageData;
                    updateProduct.Parameters["@image"].Value = imageData;
                    MessageBox.Show("Зураг амжилттай орууллаа.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private bool isManager()
        {
            return owner.user.Role == "manager";
        }
    }
}
