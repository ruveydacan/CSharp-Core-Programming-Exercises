namespace terstenyaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text); // TextBox'tan al
            int tersSayi = 0;

            while (sayi != 0)
            {
                int kalan = sayi % 10;
                tersSayi = tersSayi * 10 + kalan;
                sayi /= 10;
            }

            lblSonuc.Text = "Sonuç: " + tersSayi.ToString(); // Label'a yaz
        }

        private void txtSayi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
