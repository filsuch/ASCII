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
            // Tady m��e� prov�d�t akce p�i zm�n� textu v textBoxu, pokud je to pot�eba.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Tady m��e� prov�d�t akce p�i kliknut� na label, pokud je to pot�eba.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Z�sk�n� textu z textBoxu
            string input = textBox1.Text;

            // Zkontrolujeme, zda u�ivatel zadal alespo� jeden znak
            if (!string.IsNullOrEmpty(input))
            {
                // Z�sk�n� ASCII hodnoty prvn�ho znaku
                int asciiValue = (int)input[0];

                // Zobrazen� ASCII hodnoty v labelu
                label1.Text = $"ASCII hodnota: {asciiValue}";
            }
            else
            {
                // Pokud nen� zad�n ��dn� znak, m��eme vymazat label
                label1.Text = "Zadejte znak!";
            }
        }
    }
}
