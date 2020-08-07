using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkiClub
{
    public partial class SkiForm : Form
    {
        public SkiForm()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string slected = "";
            if (Gloves.CheckState == CheckState.Checked)
                slected += Gloves.Text + "\n";
            if (Skis.CheckState == CheckState.Checked)
                slected += Skis.Text + "\n";
            if (Goggles.CheckState == CheckState.Checked)
                slected += Goggles.Text + "\n";
            if (Hat.CheckState == CheckState.Checked)
                slected += Hat.Text + "\n";
            if (Earmuffs.CheckState == CheckState.Checked)
                slected += Earmuffs.Text + "\n";
            if (Coat.CheckState == CheckState.Checked)
                slected += Coat.Text + "\n";
            MessageBox.Show(slected);

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
