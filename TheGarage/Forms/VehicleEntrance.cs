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

namespace TheGarageV3.Forms
{
    public partial class VehicleEntrance : Form
    {
        public string con = "Data Source=DESKTOP-43SO5ER;Initial Catalog=TheGarageV1;Integrated Security=True; TrustServerCertificate=true;";
        public string loc;
        public string plate;
        public VehicleEntrance()
        {
            InitializeComponent();
        }

        private void VehicleEntrance_Load(object sender, EventArgs e)
        {
            lblDate.Visible = false;
            lblOcc.Visible = false;
            lblOccupancy.Visible = false;
            lblParkingDate.Visible = false;
            lblParkingTariff.Visible = false;
            lblPlate.Visible = false;
            lblTariff.Visible = false;
            txtPlate.Visible = false;
            btnEntry.Visible = false;

            lblParkingTariff.Text = loc;
            lblParkingDate.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            string sqlQuery = $"SELECT COUNT(*) FROM tblCars WHERE Tariff = '{loc}'";

            using (SqlConnection connection = new SqlConnection(con))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {

                connection.Open();
                int occ = (int)command.ExecuteScalar();
                lblOccupancy.Text = occ.ToString() + "/100";
                if (occ == 100)
                {
                    MessageBox.Show("Wrong: Parking Lot Full!!");
                }
            }

        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            string sqlQuery = "INSERT INTO tblCars (NumberPlate, Date, Tariff) VALUES (@Plate, @Date, @Tariff)";

            using (SqlConnection connection = new SqlConnection(con))
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                connection.Open();

                string checkDuplicateQuery = "SELECT COUNT(*) FROM tblCars WHERE NumberPlate = @Plate";
                using (SqlCommand checkDuplicateCommand = new SqlCommand(checkDuplicateQuery, connection))
                {
                    checkDuplicateCommand.Parameters.AddWithValue("@Plate", txtPlate.Text);
                    int existingRecordCount = (int)checkDuplicateCommand.ExecuteScalar();

                    if (existingRecordCount > 0)
                    {
                        MessageBox.Show("Wrong: This Plate Number Already Exist!!");
                        return;
                    }
                }

                command.Parameters.AddWithValue("@Plate", txtPlate.Text);
                command.Parameters.AddWithValue("@Date", lblParkingDate.Text);
                command.Parameters.AddWithValue("@Tariff", lblParkingTariff.Text);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Plate Number Added Successfully!");
                }
            }
            txtPlate.Text = string.Empty;
            lblParkingDate.Text = string.Empty;
            lblParkingTariff.Text = string.Empty;

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
            lblOcc.Visible = true;
            lblOccupancy.Visible = true;
            lblParkingDate.Visible = true;
            lblParkingTariff.Visible = true;
            lblPlate.Visible = true;
            lblTariff.Visible = true;
            txtPlate.Visible = true;
            btnEntry.Visible = true;

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
            lblOcc.Visible = true;
            lblOccupancy.Visible = true;
            lblParkingDate.Visible = true;
            lblParkingTariff.Visible = true;
            lblPlate.Visible = true;
            lblTariff.Visible = true;
            txtPlate.Visible = true;
            btnEntry.Visible = true;

        }
    }
}

