using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGarageV3.Forms
{
    internal class Statement
    {
        public string con = "Data Source=DESKTOP-43SO5ER;Initial Catalog=TheGarageV1;Integrated Security=True; TrustServerCertificate=true;";

        public void State(int count, int fee, string date, string loc)
        {
            string query = "INSERT INTO tblBalance (NumOfVehicles, Balance, Date, Location) VALUES (@Count, @Balance, @Date, @Location)";

            using (SqlConnection connection = new SqlConnection(con))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Count", count);
                command.Parameters.AddWithValue("@Balance", fee);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Location", loc);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

    }
}
