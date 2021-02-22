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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mutiply multiply = new Mutiply();
            multiply.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subtract subtract= new Subtract();
            subtract.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Divide divide = new Divide();
            divide.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Area area = new Area();
            area.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Volume volume = new Volume();
            volume.Show();
            this.Hide();
        }
    }
}
