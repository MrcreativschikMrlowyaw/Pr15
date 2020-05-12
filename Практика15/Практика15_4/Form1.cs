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
        byte i, u;
        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            i = 1;
            u = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rnd.Next(10) == Convert.ToByte(textBox1.Text))
            { 
                label2.Text = "Угадали!";
                u++;
            }
            else label2.Text = "Не угадали!";
            i++;
            if (i==10)
            {
                label3.Text = "Коэффициент удачи: " + (u / 10f * 100) + "%";
                i = 1;
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
