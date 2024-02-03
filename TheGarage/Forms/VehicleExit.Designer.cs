namespace TheGarageV3.Forms
{
    partial class VehicleExit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExitDate = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblParkingDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblParkingTariff = new System.Windows.Forms.Label();
            this.lblTariff = new System.Windows.Forms.Label();
            this.lblParkingFee = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExitDate
            // 
            this.lblExitDate.AutoSize = true;
            this.lblExitDate.Font = new System.Drawing.Font("Garet Heavy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExitDate.Location = new System.Drawing.Point(476, 270);
            this.lblExitDate.Name = "lblExitDate";
            this.lblExitDate.Size = new System.Drawing.Size(0, 24);
            this.lblExitDate.TabIndex = 11;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Garet Book", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExit.Location = new System.Drawing.Point(276, 270);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(88, 24);
            this.lblExit.TabIndex = 10;
            this.lblExit.Text = "Exit Date";
            // 
            // lblParkingDate
            // 
            this.lblParkingDate.AutoSize = true;
            this.lblParkingDate.Font = new System.Drawing.Font("Garet Heavy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParkingDate.Location = new System.Drawing.Point(476, 200);
            this.lblParkingDate.Name = "lblParkingDate";
            this.lblParkingDate.Size = new System.Drawing.Size(0, 24);
            this.lblParkingDate.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Garet Book", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(276, 200);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(123, 24);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Parking Date";
            // 
            // txtPlate
            // 
            this.txtPlate.Font = new System.Drawing.Font("Garet Heavy", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlate.Location = new System.Drawing.Point(280, 99);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(130, 29);
            this.txtPlate.TabIndex = 7;
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Font = new System.Drawing.Font("Garet Book", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlate.Location = new System.Drawing.Point(100, 100);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(130, 24);
            this.lblPlate.TabIndex = 6;
            this.lblPlate.Text = "Number Plate";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnQuery.Font = new System.Drawing.Font("Garet Heavy", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(480, 99);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(130, 29);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Garet Heavy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalTime.Location = new System.Drawing.Point(476, 340);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(0, 24);
            this.lblTotalTime.TabIndex = 14;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Garet Book", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(276, 340);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 24);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Total Time";
            // 
            // lblParkingTariff
            // 
            this.lblParkingTariff.AutoSize = true;
            this.lblParkingTariff.Font = new System.Drawing.Font("Garet Heavy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParkingTariff.Location = new System.Drawing.Point(476, 410);
            this.lblParkingTariff.Name = "lblParkingTariff";
            this.lblParkingTariff.Size = new System.Drawing.Size(0, 24);
            this.lblParkingTariff.TabIndex = 16;
            // 
            // lblTariff
            // 
            this.lblTariff.AutoSize = true;
            this.lblTariff.Font = new System.Drawing.Font("Garet Book", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTariff.Location = new System.Drawing.Point(276, 410);
            this.lblTariff.Name = "lblTariff";
            this.lblTariff.Size = new System.Drawing.Size(125, 24);
            this.lblTariff.TabIndex = 15;
            this.lblTariff.Text = "Parking Tariff";
            // 
            // lblParkingFee
            // 
            this.lblParkingFee.AutoSize = true;
            this.lblParkingFee.Font = new System.Drawing.Font("Garet Heavy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParkingFee.Location = new System.Drawing.Point(476, 480);
            this.lblParkingFee.Name = "lblParkingFee";
            this.lblParkingFee.Size = new System.Drawing.Size(0, 24);
            this.lblParkingFee.TabIndex = 18;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Garet Book", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFee.Location = new System.Drawing.Point(276, 480);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(42, 24);
            this.lblFee.TabIndex = 17;
            this.lblFee.Text = "Fee";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnExit.Font = new System.Drawing.Font("Garet Heavy", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(778, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 48);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(104, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 464);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button1.Font = new System.Drawing.Font("Garet Heavy", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(778, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Choose Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button2.Font = new System.Drawing.Font("Garet Heavy", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(778, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 41);
            this.button2.TabIndex = 22;
            this.button2.Text = "Contuine";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(778, 170);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 34);
            this.textBox1.TabIndex = 23;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.button3.Font = new System.Drawing.Font("Garet Heavy", 10.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(778, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 38);
            this.button3.TabIndex = 24;
            this.button3.Text = "Enter by hand";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VehicleExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1049, 640);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblParkingFee);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblParkingTariff);
            this.Controls.Add(this.lblTariff);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblExitDate);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblParkingDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.lblPlate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleExit";
            this.Text = "VehicleExit";
            this.Load += new System.EventHandler(this.VehicleExit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExitDate;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblParkingDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblParkingTariff;
        private System.Windows.Forms.Label lblTariff;
        private System.Windows.Forms.Label lblParkingFee;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
    }
}