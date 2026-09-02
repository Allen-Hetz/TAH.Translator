namespace TAH.Translator.UI
{
    public partial class Translator : Form
    {
        public Translator()
        {
            InitializeComponent();
        }

        private void btnGerman_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Hallo Welt!";
            lblTranslationText.Text = "German:";
        }

        private void btnSpainish_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "¡Hola Mundo!";
            lblTranslationText.Text = "Spanish:";
        }

        private void btnFrench_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Bonjour le monde!";
            lblTranslationText.Text = "French:";
        }
    }
}

