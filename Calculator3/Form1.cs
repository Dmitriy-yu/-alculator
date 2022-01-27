using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3
{
    public partial class Form1 : Form
    {
        int a, b, s;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = int.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = a +b;
            textBox3.Text = s.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }


    }
}
