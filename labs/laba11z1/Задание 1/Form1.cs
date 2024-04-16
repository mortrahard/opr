using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public double n, k;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Pol.Maximum = 100;
            n = Pol.Value;
            Mean_n.Text = n.ToString();

            k = Math.Pow(-1,n) * ((n + 1)/2);
            if (n % 2 == 0)
            {
                k -= 0.5;
                k = Convert.ToInt32(k);
                Mean.Text = (k.ToString());
            }
            else
            {
                k = Convert.ToInt32(k);
                Mean.Text = (k.ToString());
            }
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i%2 == 0)
                {
                    sum += i * (-1);
                }
                else
                {
                    sum += i;
                }
            }
            sum *= -1;
            Mean2.Text = sum.ToString();
        }
    }
}
