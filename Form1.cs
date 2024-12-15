namespace ASCII
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (!string.IsNullOrEmpty(input))
            {
               
                int asciiValue = (int)input[0];

               
                label1.Text = $"ASCII: {asciiValue}";
            }
            else
            {
                
                label1.Text = "Zadejte znak!";
            }
        }
    }
}
