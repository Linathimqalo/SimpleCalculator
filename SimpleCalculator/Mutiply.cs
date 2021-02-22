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
    public partial class Mutiply : Form
    {
        public Mutiply()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            string ans = (a * b).ToString();
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("The total is: " + ans);
            }
            catch
            {
                MessageBox.Show("Invaild!");
            }
        }
    }
}
