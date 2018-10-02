using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int i1 = 3 * 4;
            int i2 = 12 / 4;
            int i3 = 15 / 4;
            int i4 = 15 % 4;
            int i5 = 2 + 3 * 4;
            int i6 = 2 + (3 * 4) / (2 - 4);
            richTextBox1.AppendText(i1 + "\n" + i2 + "\n" + i3 + "\n" + i4 + "\n" + i4 + "\n" + i5 + "\n" + i6 + "\n");

            double d1 = Math.Pow(27, 1.0 / 3.0);
            richTextBox1.AppendText(d1 + "\n");


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double d1 = Convert.ToDouble(textBox1.Text);
                double d2 = Convert.ToDouble(textBox2.Text);
                d1 = Math.Pow(d1, 1.0 / d2);
                label1.Text = d1.ToString();
            }
            catch
            {
                MessageBox.Show("input needs to be a number");
            }

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double d1;
            try
            {
                d1 = Convert.ToDouble(textBox1.Text);

            }
            catch
            {
                d1 = 0;
            }
            double d2;
            try
            {
                d2 = Convert.ToDouble(textBox2.Text);

            }
            catch
            {
                d2 = 2;
            }
            d1 = Math.Pow(d1, 1.0 / d2);
            label1.Text = d1.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double d1, d2;
            try
            {
                d1= Convert.ToDouble(textBox1.Text);

            }
            catch
            {
                d1 = 0;
            }
            try
            {
                d2= Convert.ToDouble(textBox2.Text);

            }
            catch
            {
                d2 = 2;
            }
            d1 = Math.Pow(d1, 1.0 / d2 );
            label1.Text = d1.ToString();
        }
    }
}
