using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedCalculator
{
    public partial class Калькуляторр : Form
    {
        public Калькуляторр()
        {
            InitializeComponent();
        }


        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
       

        private void button10_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            textBox1.Text = textBox1.Text + B.Text;
        }
    }
}
