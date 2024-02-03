using AForge.Imaging.Filters;
using AForge.Imaging;
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
using Tesseract;
using System.Diagnostics;

namespace TheGarageV3.Forms
{
    public partial class VehicleExit : Form
    {
        public string loc;
        public string plate;

        public string con = "Data Source=DESKTOP-43SO5ER;Initial Catalog=TheGarageV1;Integrated Security=True; TrustServerCertificate=true;";
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-43SO5ER;Initial Catalog=TheGarageV1;Integrated Security=True; TrustServerCertificate=true;");
        public VehicleExit()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string plate = txtPlate.Text;
            string tariff = loc;

            //con.Open();
            string sqlQuery = "SELECT * FROM tblCars WHERE NumberPlate LIKE @plate AND Tariff = @tariff";
            //SqlCommand cmd = new SqlCommand("SELECT * FROM tblCars WHERE NumberPlate LIKE @plate AND Tariff = @tariff", con);
            using (SqlConnection connection = new SqlConnection(con))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@plate", plate);
                command.Parameters.AddWithValue("@tariff", tariff);
                SqlDataReader rdr = command.ExecuteReader();
                if (rdr.Read())
                {
                    lblParkingDate.Text = rdr["Date"].ToString();
                    lblParkingTariff.Text = tariff;
                }
                else
                {
                    MessageBox.Show("Plate Number Not Found or Tariff Mismatch!", "WARNING!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //con.Close();
                connection.Close();
                DateTime entryDate;

                if (DateTime.TryParse(lblParkingDate.Text, out entryDate))
                {
                    entryDate = DateTime.Parse(lblParkingDate.Text);
                }

                DateTime exitDate = DateTime.Parse(lblExitDate.Text);
                TimeSpan span = exitDate - entryDate;
                int totalHours = (int)span.TotalHours;
                lblTotalTime.Text = totalHours.ToString();

                Fee fee = new Fee();
                decimal parkingFee = fee.ParkingFee(loc, totalHours);
                lblParkingFee.Text = parkingFee.ToString();
            }
           
        }

        private void VehicleExit_Load(object sender, EventArgs e)
        {
            lblDate.Visible = false;
            lblExitDate.Visible = false;
            lblParkingFee.Visible = false;
            lblTotalTime.Visible = false;
            lblExit.Visible = false;
            lblFee.Visible = false;
            lblParkingDate.Visible = false;
            lblParkingTariff.Visible = false;
            lblTariff.Visible = false;
            lblTime.Visible = false;
            txtPlate.Visible = false;
            lblPlate.Visible = false;
            btnExit.Visible = false;
            btnQuery.Visible = false;

            
            lblExitDate.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 1;
                string plate = txtPlate.Text;
                string location = loc;
                int fee = Convert.ToInt32(lblParkingFee.Text);
                string date = lblExitDate.Text.Split(' ')[0];

                Statement statement = new Statement();
                statement.State(count, fee, date, location);


                //con.Open();
                //SqlCommand cmd = new SqlCommand("DELETE FROM tblCars WHERE NumberPlate = @Plate AND Tariff = @Location", con);
                string sqlQuery = "DELETE FROM tblCars WHERE NumberPlate = @Plate AND Tariff = @Location";

                using (SqlConnection connection = new SqlConnection(con))
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Plate", plate);
                    command.Parameters.AddWithValue("@Location", location);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment Received! Plate Number Deleted Successfully!");

                    }
                    else
                    {
                        MessageBox.Show("Plate Number Not Found or Location Mismatch!!");
                    }
                    connection.Close();
                    //con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyaları (*.bmp)|*.jpg;*.gif;*.bmp;*.png;*.jpeg";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap image = (Bitmap)pictureBox1.Image;
                DetectLicensePlate(image);
            }
        }
        private void DetectLicensePlate(Bitmap image)
        {
            // Önce resmi siyah beyaz yap
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap grayImage = filter.Apply(image);

            // Daha sonra kenarları tespit et
            DifferenceEdgeDetector edgeDetector = new DifferenceEdgeDetector();
            Bitmap edgeImage = edgeDetector.Apply(grayImage);

            // Plakayı algıla
            //Blob bağlı piksellerden oluşan nesne
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(edgeImage);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            // Plakayı TextBox'a yazdır
            if (blobs.Length > 0)
            {
                Rectangle rect = blobs[0].Rectangle;
                Crop cropFilter = new Crop(rect);
                Bitmap licensePlate = cropFilter.Apply(image);
                string text = ReadLicensePlateText(licensePlate);

                if (!string.IsNullOrEmpty(text) && char.IsLetter(text[0]))
                {
                    text = text.Substring(1);
                    plate = text;
                    textBox1.Text = "Plaka: " + text;
                }
                textBox1.Text = "Plaka: " + text;
            }
            else
            {
                textBox1.Text = "Plaka algılanamadı.";
            }
        }
        private string ReadLicensePlateText(Bitmap licensePlate)
        {
            string tessDataPath = @"C:\Users\ferha\source\repos\TheGarageV3\bin\Debug\tessdata";

            using (var engine = new TesseractEngine(tessDataPath, "eng", EngineMode.Default))
            {
                using (var page = engine.Process(licensePlate))
                {
                    string text = page.GetText();
                    return text.Trim();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;

            lblDate.Visible = true;
            lblExitDate.Visible = true;
            lblParkingFee.Visible = true;
            lblTotalTime.Visible = true;
            lblExit.Visible = true;
            lblFee.Visible = true;
            lblParkingDate.Visible = true;
            lblParkingTariff.Visible = true;
            lblTariff.Visible = true;
            lblTime.Visible = true;
            txtPlate.Visible = true;
            lblPlate.Visible = true;
            btnExit.Visible = true;
            btnQuery.Visible = true;

            txtPlate.Text = plate;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;

            lblDate.Visible = true;
            lblExitDate.Visible = true;
            lblParkingFee.Visible = true;
            lblTotalTime.Visible = true;
            lblExit.Visible = true;
            lblFee.Visible = true;
            lblParkingDate.Visible = true;
            lblParkingTariff.Visible = true;
            lblTariff.Visible = true;
            lblTime.Visible = true;
            txtPlate.Visible = true;
            lblPlate.Visible = true;
            btnExit.Visible = true;
            btnQuery.Visible = true;

        }
    }
}
