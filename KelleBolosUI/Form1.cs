﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

             

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                timer1.Enabled = false;

                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
