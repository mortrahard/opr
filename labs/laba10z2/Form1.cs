namespace labal10z2
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

        private void label2_Click(object sender, EventArgs e)
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
            if (Valid(textBox1.Text) != 1)
            {
                MessageBox.Show("Только числа.");
            }
            else
            {
                double ch = Convert.ToDouble(textBox1.Text);
                double summ = ch / 93.44;
                label2.Text = summ.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            if (Valid(textBox1.Text) != 1)
            {
                MessageBox.Show("Только числа.");
            }
            else
            {
                double ch = Convert.ToDouble(textBox1.Text);
                double summ = ch / 99.73;
                label2.Text = summ.ToString();
            }
        }
    }
}
