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
            // Tady mùžeš provádìt akce pøi zmìnì textu v textBoxu, pokud je to potøeba.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Tady mùžeš provádìt akce pøi kliknutí na label, pokud je to potøeba.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Získání textu z textBoxu
            string input = textBox1.Text;

            // Zkontrolujeme, zda uživatel zadal alespoò jeden znak
            if (!string.IsNullOrEmpty(input))
            {
                // Získání ASCII hodnoty prvního znaku
                int asciiValue = (int)input[0];

                // Zobrazení ASCII hodnoty v labelu
                label1.Text = $"ASCII hodnota: {asciiValue}";
            }
            else
            {
                // Pokud není zadán žádný znak, mùžeme vymazat label
                label1.Text = "Zadejte znak!";
            }
        }
    }
}
