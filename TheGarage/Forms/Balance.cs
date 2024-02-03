using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheGarageV3
{
    public partial class Balance : Form
    {
        public string loc;
        public string con = "Data Source=DESKTOP-43SO5ER;Initial Catalog=TheGarageV1;Integrated Security=True; TrustServerCertificate=true;";
        public Balance()
        {
            InitializeComponent();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            btnDaily.Visible = false;
            btnMonthly.Visible = false;

            lblNum.Visible = true;
            lblNumVehic.Visible = true;
            lblRev.Visible = true;
            lblRevenues.Visible = true;
            btnBack.Visible = true;

            string date = DateTime.Now.ToString("dd.MM.yyyy");
            string location = loc;
            int matchingRowCount = 0;
            int fee = 0;

            string sqlQuery = "SELECT * FROM tblBalance WHERE Date LIKE @date AND Location = @location";
            using (SqlConnection connection = new SqlConnection(con))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@date",date);
                command.Parameters.AddWithValue("@location", location);
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    matchingRowCount++;
                    fee += Convert.ToInt32(rdr["Balance"]);

                }
                if (matchingRowCount == 0)
                {
                    MessageBox.Show("No Matches Found!", "WARNING!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                lblNumVehic.Text = matchingRowCount.ToString();
                lblRev.Text = fee.ToString();

            }
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            lblNum.Visible = false;
            lblNumVehic.Visible = false;
            lblRev.Visible = false;
            lblRevenues.Visible = false;
            btnBack.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblNum.Visible = false;
            lblNumVehic.Visible = false;
            lblRev.Visible = false;
            lblRevenues.Visible = false;
            btnBack.Visible = false;
            btnDaily.Visible = true;
            btnMonthly.Visible = true;
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            btnDaily.Visible = false;
            btnMonthly.Visible = false;

            lblNum.Visible = true;
            lblNumVehic.Visible = true;
            lblRev.Visible = true;
            lblRevenues.Visible = true;
            btnBack.Visible = true;

            string location = loc;
            int matchingRowCount = 0;
            int fee = 0;

            string sqlQuery = "SELECT * FROM tblBalance WHERE CONVERT(NVARCHAR, Date, 103) LIKE @date AND Location = @location";
            using (SqlConnection connection = new SqlConnection(con))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                connection.Open();

                string dateFilter = DateTime.Now.ToString("MM.yyyy");

                command.Parameters.AddWithValue("@date", "%" + dateFilter + "%");
                command.Parameters.AddWithValue("@location", location);

                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    matchingRowCount++;
                    fee += Convert.ToInt32(rdr["Balance"]);
                }
                if (matchingRowCount == 0)
                {
                    MessageBox.Show("No Matches Found!", "WARNING!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                lblNumVehic.Text = matchingRowCount.ToString();
                lblRev.Text = fee.ToString();
            }
        }
    }
}
