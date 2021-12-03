using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MID_09156242_3
{
    public partial class Form1 : Form
    {
        int x, y;

        public Form1()
        {
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            if (Minite.Text.Equals(""))
                x = 0;
            else
                x = Convert.ToInt32(Minite.Text);

            if (Second.Text.Equals(""))
                y = 0;
            else
                y = Convert.ToInt32(Second.Text);

            Count.Enabled = false;

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {            
            Counting.Text = x.ToString() + "分" + y.ToString() + "秒";
            if (x == 0 && y == 0)
            {
                timer.Stop();
                Count.Enabled = true;
                MessageBox.Show("時間到囉");
            }
            else if (y == 0 && x != 0)
            {
                x -= 1;
                y = 59;
            }
            else
            {
                y -= 1;
            }

        }
    }
}
