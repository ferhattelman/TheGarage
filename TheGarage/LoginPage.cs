using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGarageV3
{
    public partial class LoginPage : Form
    {
        string con = "Data Source=DESKTOP-43SO5ER;Initial Catalog=TheGarageV1;Integrated Security=True; TrustServerCertificate=True;";
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT Location FROM tblLocation";
            using (SqlConnection connection = new SqlConnection(con))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbLoc.Items.Add(reader["Location"].ToString());
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT COUNT(*) FROM tblUsers WHERE Username = @username AND Password = @password";
            string username = txtUser.Text;
            string pass = txtPass.Text;

            using (SqlConnection connection = new SqlConnection(con))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", pass);

                connection.Open();

                int userCount = (int)command.ExecuteScalar();

                if (userCount > 0)
                {
                    MainPage main = new MainPage();
                    main.loc = cmbLoc.SelectedItem.ToString();
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is wrong. Please try again.");
                }
            }
        }
    }
}
