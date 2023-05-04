namespace sahel_s
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);

            if (tal1 < tal2)
            {
                string tt = tal1.ToString();
                textBox3.Text = tt;
            }
                else
                {
                string tt = tal2.ToString();
                textBox3.Text = tt;
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}