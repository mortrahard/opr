namespace lalal10z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Valid(string n)
            {
                double ch;
                if (double.TryParse(n, out ch) == true)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            if ((Valid(textBox1.Text) != 1) || (Valid(textBox2.Text) != 1) || (Valid(textBox3.Text) != 1))
            {
                MessageBox.Show("Только числа.");
            } 
            else
            {
                double ch1 = Convert.ToDouble(textBox1.Text);
                double ch2 = Convert.ToDouble(textBox2.Text);
                double ch3 = Convert.ToDouble(textBox3.Text);
                double summ = 1 / ch1 + 1 / ch2 + 1 / ch3;
                label2.Text = summ.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
