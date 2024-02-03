namespace TheGarageV3
{
    partial class Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            this.btnDaily = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.lblRev = new System.Windows.Forms.Label();
            this.lblRevenues = new System.Windows.Forms.Label();
            this.lblNumVehic = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDaily
            // 
            this.btnDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnDaily.Font = new System.Drawing.Font("Garet Heavy", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDaily.ForeColor = System.Drawing.Color.White;
            this.btnDaily.Location = new System.Drawing.Point(207, 296);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(213, 48);
            this.btnDaily.TabIndex = 7;
            this.btnDaily.Text = "Daily Balance";
            this.btnDaily.UseVisualStyleBackColor = false;
            this.btnDaily.Click += new System.EventHandler(this.btnDaily_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnMonthly.Font = new System.Drawing.Font("Garet Heavy", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMonthly.ForeColor = System.Drawing.Color.White;
            this.btnMonthly.Location = new System.Drawing.Point(627, 296);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(213, 48);
            this.btnMonthly.TabIndex = 8;
            this.btnMonthly.Text = "Monthly Balance";
            this.btnMonthly.UseVisualStyleBackColor = false;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // lblRev
            // 
            this.lblRev.AutoSize = true;
            this.lblRev.Font = new System.Drawing.Font("Garet Heavy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRev.Location = new System.Drawing.Point(420, 185);
            this.lblRev.Name = "lblRev";
            this.lblRev.Size = new System.Drawing.Size(0, 24);
            this.lblRev.TabIndex = 15;
            // 
            // lblRevenues
            // 
            this.lblRevenues.AutoSize = true;
            this.lblRevenues.Font = new System.Drawing.Font("Garet Book", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRevenues.Location = new System.Drawing.Point(203, 185);
            this.lblRevenues.Name = "lblRevenues";
            this.lblRevenues.Size = new System.Drawing.Size(95, 24);
            this.lblRevenues.TabIndex = 14;
            this.lblRevenues.Text = "Revenues";
            // 
            // lblNumVehic
            // 
            this.lblNumVehic.AutoSize = true;
            this.lblNumVehic.Font = new System.Drawing.Font("Garet Heavy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumVehic.Location = new System.Drawing.Point(420, 115);
            this.lblNumVehic.Name = "lblNumVehic";
            this.lblNumVehic.Size = new System.Drawing.Size(0, 24);
            this.lblNumVehic.TabIndex = 13;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Garet Book", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNum.Location = new System.Drawing.Point(203, 115);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(180, 24);
            this.lblNum.TabIndex = 12;
            this.lblNum.Text = "Number of Vehicles";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(627, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1049, 640);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRev);
            this.Controls.Add(this.lblRevenues);
            this.Controls.Add(this.lblNumVehic);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnDaily);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Label lblRev;
        private System.Windows.Forms.Label lblRevenues;
        private System.Windows.Forms.Label lblNumVehic;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnBack;
    }
}