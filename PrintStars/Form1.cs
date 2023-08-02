using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintStars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            int row = (int)rowChooser.Value;
            string result = "";
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += "*";
                }
                result += "\n";
            }
            pictureBox1.Image = Properties.Resources.star;
            MessageBox.Show(result);
            
        }

        private void btPyramid_Click(object sender, EventArgs e)
        {
            int row = (int)rowChooser.Value;
            string result = "";
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= (row-i); j++)
                {
                    result+= " "; 
                }
                for (int k = 1; k <= (i*2-1); k++)
                {
                    result+= "*";
                }
                result += "\n";
            }

            pictureBox1.Image = Properties.Resources.Pyramid;
            MessageBox.Show(result);
        }
        private void rowChooser_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
