using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtheloGame
{
    public partial class OtheloForm : Form
    {
        PictureBox[,] chips = new PictureBox[8,8];
        System.Resources.ResourceManager rm;

        public OtheloForm()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            rm = OtheloGame.Properties.Resources.ResourceManager;
            int rowPos=0;
            int colPos=0;
            for(int i=0;i<8;i++)//row
            {
                for(int k=0; k<8;k++)//col
                {
                    Bitmap myImage = (Bitmap)rm.GetObject("Black");
                    chips[i, k] = new PictureBox();
                    chips[i, k].Size = new Size(10, 10);
                    chips[i, k].Image = myImage;
                    chips[i, k].Location = new Point(rowPos, colPos);
                    chips[i, k].Visible = true;
                    colPos += 10;

                }
                colPos = 0;
                rowPos += 10;
            }
            /*chips[0, 0] = r0c0;

            chips[0, 1] = r0c1;

            chips[0, 2] = r0c2;

            chips[0, 3] = r0c3;

            chips[0, 4] = r0c4;

            chips[0, 5] = r0c5;

            chips[0, 6] = r0c6;

            chips[0, 7] = r0c7;

            chips[1, 0] = r1c0;

            chips[1, 1] = r1c1;

            chips[1, 2] = r1c2;

            chips[1, 3] = r1c3;

            chips[1, 4] = r1c4;

            chips[1, 5] = r1c5;

            chips[1, 6] = r1c6;

            chips[1, 7] = r1c7;

            chips[2, 0] = r2c0;

            chips[2, 1] = r2c1;

            chips[2, 2] = r2c2;

            chips[2, 3] = r2c3;

            chips[2, 4] = r2c4;

            chips[2, 5] = r2c5;

            chips[2, 6] = r2c6;

            chips[2, 7] = r2c7;

            chips[3, 0] = r3c0;

            chips[3, 1] = r3c1;

            chips[3, 2] = r3c2;

            chips[3, 3] = r3c3;

            chips[3, 4] = r3c4;

            chips[3, 5] = r3c5;

            chips[3, 6] = r3c6;

            chips[3, 7] = r3c7;

            chips[4, 0] = r4c0;

            chips[4, 1] = r4c1;

            chips[4, 2] = r4c2;

            chips[4, 3] = r4c3;

            chips[4, 4] = r4c4;

            chips[4, 5] = r4c5;

            chips[4, 6] = r4c6;

            chips[4, 7] = r4c7;

            chips[5, 0] = r5c0;

            chips[5, 1] = r5c1;

            chips[5, 2] = r5c2;

            chips[5, 3] = r5c3;

            chips[5, 4] = r5c4;

            chips[5, 5] = r5c5;

            chips[5, 6] = r5c6;

            chips[5, 7] = r5c7;

            chips[6, 0] = r6c0;

            chips[6, 1] = r6c1;

            chips[6, 2] = r6c2;

            chips[6, 3] = r6c3;

            chips[6, 4] = r6c4;

            chips[6, 5] = r6c5;

            chips[6, 6] = r6c6;

            chips[6, 7] = r6c7;

            chips[7, 0] = r7c0;

            chips[7, 1] = r7c1;

            chips[7, 2] = r7c2;

            chips[7, 3] = r7c3;

            chips[7, 4] = r7c4;

            chips[7, 5] = r7c5;

            chips[7, 6] = r7c6;

            chips[7, 7] = r7c7;*/


        }

        private void test_Click(object sender, EventArgs e)
        {
            /*Bitmap myImage = (Bitmap)rm.GetObject("Black");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    String c = "r" + i + "c" + j;
                    c.Image = myImage;
                }
                        //chips[i, j].Image = myImage;
            }*/
        }
    }
}
