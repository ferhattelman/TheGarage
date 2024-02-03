using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGarageV3
{
    public partial class TheGarage : Form
    {
        public TheGarage()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LoginPage lgn = new LoginPage();
            lgn.Show();
            this.Hide();
            timer.Stop();
        }
    }
}
