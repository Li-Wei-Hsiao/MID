using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MID_09156242_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Count(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(First_Number.Text);
            int number2 = Convert.ToInt32(Second_Number.Text);

            if(Radiobutton_Plus.Checked == true)
            {
                int answer = number1 + number2;
                Answer.Text = answer.ToString();
                Answer.Visible = true;
            }
            else if(Radiobutton_Minus.Checked == true)
            {
                int answer = number1 - number2;
                Answer.Text = answer.ToString();
                Answer.Visible = true;
            }
            else if(Radiobutton_Mutiply.Checked == true)
            {
                int answer = number1 * number2;
                Answer.Text = answer.ToString();
                Answer.Visible = true;
            }
            else if (Radiobutton_Divide.Checked == true)
            {
                if(number2 == 0)
                {
                    Answer.Text = "0";
                }
                else
                {
                    double answer = Math.Round((double)number1 / number2 * 100) / 100;
                    Answer.Text = answer.ToString();
                }
                Answer.Visible = true;
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            First_Number.Text = "";
            Second_Number.Text = "";
            Radiobutton_Plus.Checked = false;
            Radiobutton_Minus.Checked = false;
            Radiobutton_Mutiply.Checked = false;
            Radiobutton_Divide.Checked = false;
            Answer.Text = "";
            Answer.Visible = false;
        }
    }
}
