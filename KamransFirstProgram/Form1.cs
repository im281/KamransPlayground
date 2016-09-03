using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamransFirstProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Our1stMethod();
        }

        private static void Our1stMethod()
        {
            MessageBox.Show("Hi Kamran, Its Daddy!");
            MessageBox.Show("find the diamond sword");
            MessageBox.Show("find block");

            for (int i = 0; i < 100000; i++)
            {
                MessageBox.Show("What is the answer to:" + i + " " + "+" + 3 + " ?");
                MessageBox.Show(Convert.ToString(i + 3));

                if (i == 10)
                {
                    MessageBox.Show("You have reached 10!!!!!!");
                }
                if (i == 15)
                {
                    MessageBox.Show("its count down time");
                    for (int j = 15; j > 0; j--)
                    {
                        MessageBox.Show(Convert.ToString(j));

                    }
                    break;
                }
            }

            MessageBox.Show("We are DONE@!!!!!!!!!");
        }
    }
}
