namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double h = 170, w = 60, bmi;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "BMI=";
            h = Convert.ToDouble(textBox1.Text);
            w = Convert.ToDouble(textBox2.Text);
            bmi = (10000 * w / h / h);
            textBox3.Text += bmi;
            if (bmi < 18.5)
            {
                textBox4.Text = "�L��";
            }
            else if (18.5 <= bmi && bmi < 24 ) 
            {
                textBox4.Text = "���`�d��";
            }
            else if (24 <= bmi && bmi < 27) 
            {
                textBox4.Text = "�L��";
            }
            else if (27 <= bmi && bmi < 30 )
            {
                textBox4.Text = "���תέD";
            }
            else if (30 <= bmi && bmi < 35) 
            {
                textBox4.Text = "���תέD";
            } 
            else if (35 <= bmi )
            {
                textBox4.Text = "���תέD";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
