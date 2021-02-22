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
    public partial class Volume : Form
    {
        public Volume()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(textBox1.Text);
                float pi = 3.14f;
                string ans = (4 * pi * (r * r)).ToString();
                string answer = (4f / 3f * pi * (r * r * r)).ToString();
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("The total Sphere Area is: " + ans + "\nThe total Sphere Volume is: " + answer);
            }
            catch
            {
                textBox2.Clear();
                MessageBox.Show("Invalid input.\nRadius only input allowed.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(textBox1.Text);
                double h = Convert.ToDouble(textBox2.Text);
                float pi = 3.14f;
                string ans = (2 * pi * r * r + 2 * pi * r * h).ToString();
                string answer = (pi * (r * r) * h).ToString();
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("The total Cylinder Area is: " + ans + " \nThe total Cylinder Volume is: " + answer);
            }
            catch
            {
                MessageBox.Show("Invaild!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(textBox1.Text);
                double h = Convert.ToDouble(textBox2.Text);
                float pi = 3.14f;
                string ans = (pi * r * (r + Math.Sqrt(r * r + h * h))).ToString();
                string answer = ((1f / 3f) * (pi * r * r) * h).ToString();
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("The total Cone Area is: " + ans + "\nThe total Cone Volume is: " + answer);
            }
            catch
            {
                MessageBox.Show("Invaild!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
