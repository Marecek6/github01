using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace github01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soucet = 0;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            soucet = a + b;
            MessageBox.Show("soucet je " + soucet);

            int rozdil = 0;
            rozdil = a - b;
            MessageBox.Show("rozdil je " + rozdil);

            int soucin = 0;
            soucin = a * b;
            MessageBox.Show("soucin je " + soucin);

            int podil = 0;
            podil = a / b;
            MessageBox.Show("podil je " + podil);
        }
    }
}
