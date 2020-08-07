using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripCalc
{
    public partial class tripCalcu : Form
    {
        public tripCalcu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gallonsUsed = int.Parse(gallons.Text);
            int totalDistance = int.Parse(distance.Text);
            double mpg = (totalDistance*1.00)/(gallonsUsed*1.00);
            calculatedMPG.Text = String.Format("{0:F2}",mpg);
        }
    }
}
