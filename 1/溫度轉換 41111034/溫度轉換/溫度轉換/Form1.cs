using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 溫度轉換
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                double count = double.Parse(textBox1.Text);
                textBox2.Text = (count * 9 / 5 + 32).ToString();
                textBox3.Text = (count + 273.15).ToString();
                textBox4.Text = ((count + 273.15) * 9 / 5).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                double count = double.Parse(textBox2.Text);
                textBox1.Text = ((count - 32) / 1.8).ToString();
                textBox3.Text = ((count + 459.67) * (5 / 9)).ToString();
                textBox4.Text = (count + 459.67).ToString();
            }
        }

        
    }
}
