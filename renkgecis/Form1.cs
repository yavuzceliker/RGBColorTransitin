using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renkgecis
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
        int r = 255,g=0,b=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "(" + r + "," + g + "," + b + ")";
            this.BackColor = Color.FromArgb(r, g, b);
            if (r == 255 && g < 255 && b==0)
            {
                g++;
            }
            else if (r > 0 && g == 255 && b == 0)
            {
                r--;
            }
            else if (r == 0 && g == 255 && b < 255)
            {
                b++;
            }
            else if (r == 0 && g >0 && b == 255)
            {
                g--;
            }
            else if (r < 255 && g == 0 && b == 255)
            {
                r++;
            }
            else if (r == 255 && g == 0 && b > 0)
            {
                b--;
            }
        }
    }
}
