using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pos.data;
using Microsoft.Data.Sqlite;
using PosLibrary;

namespace Pos
{
    public partial class Login : Form
    {
        private Pos owner;
        UserContext userContext;

        SqliteConnection connection;
        SqliteCommand selectUser;

        public Login(Pos o)
        {
            InitializeComponent();
            userContext = new UserContext();
            owner = o;

            connection = new("Data Source=users.db");
            selectUser = new("SELECT * FROM User WHERE username=@username AND password=@password", connection);
            selectUser.Parameters.Add("@username", SqliteType.Text);
            selectUser.Parameters.Add("@password", SqliteType.Text);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Username.Text) || string.IsNullOrEmpty(textBox_Password.Text))
            {
                MessageBox.Show("Бүх талбарыг бөглөнө үү.");
                return;
            }

            selectUser.Parameters["@username"].Value = textBox_Username.Text;
            selectUser.Parameters["@password"].Value = textBox_Password.Text;

            connection.Open();

            SqliteDataReader reader = selectUser.ExecuteReader();
            if (reader.Read())
            {
                owner.user = new User
                {
                    Id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Role = reader.GetString(3)
                };
                owner.button_User.Text = owner.user.Username;
                connection.Close();
                owner.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Нэвтрэх нэр эсвэл нууц үг буруу байна.");
                connection.Close();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (owner.user == null)
            {
                owner.Close();
            }
        }
    }
}
