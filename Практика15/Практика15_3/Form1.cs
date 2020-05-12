using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика15_3
{
    public partial class Form1 : Form
    {
        byte i=1, b, u=0;
        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = Convert.ToByte(textBox1.Text);
            if (rnd.Next(10) == b)
            { 
                label2.Text = "Угадали!";
                u++;
            }
            else label2.Text = "Не угадали!";
            i++;
            if (i==10)
            {
                label3.Text = "Коэффициент удачи: " + ((u / 10f) * 100) + "%";
                i = 0;
                u = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
