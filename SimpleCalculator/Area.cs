using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            float pi = 3.1415926536f;
            string ans = (pi * (a * b)).ToString();
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("The total Circle Area is: " + ans);
            }
            catch
            {
                MessageBox.Show("Invaild!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            double b = Convert.ToDouble(textBox1.Text);
            double h = Convert.ToDouble(textBox2.Text);
            double area = 0.5;
            string ans = (area * (b * h)).ToString();
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("The total Triangle Area is: " + ans);
            }
            catch
            {
                MessageBox.Show("Invaild!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            string ans = (a * b).ToString();
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("The total Square Area is: " + ans);
            }
            catch
            {
                MessageBox.Show("Invaild!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { 
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            string ans = (a * b).ToString();
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("The total Rectangle Area is: " + ans);
            }
            catch
            {
                MessageBox.Show("Invaild!");
            }
        }
    }
}
