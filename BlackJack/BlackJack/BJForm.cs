using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class BJForm : Form
    {
        
        public BJForm()
        {
            InitializeComponent();
        }

        private void DrawBnt_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int card = rnd.Next(1, 53);
            String cardName = "" + card;

            System.Resources.ResourceManager rm = BlackJack.Properties.Resources.ResourceManager;
            Bitmap myImage = (Bitmap)rm.GetObject(cardName);

            Card1.Image = myImage;

            card = rnd.Next(1, 53);
            cardName = "" + card;

            Bitmap myImage2 = (Bitmap)rm.GetObject(cardName);

            Card2.Image = myImage2;

            card = rnd.Next(1, 53);
            cardName = "" + card;
        }
    }
}
