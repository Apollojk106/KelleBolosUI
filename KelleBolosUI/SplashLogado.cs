using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelleBolosUI
{
    public partial class SplashLogado : Form
    {
        public SplashLogado()
        {
            InitializeComponent();
        }

        private void SplashLogado_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                timer1.Enabled = false;

                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }
    }
}
