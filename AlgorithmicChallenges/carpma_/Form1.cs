using System.Diagnostics.Eventing.Reader;

namespace çarpmaçalışma
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
            if (int.TryParse(txtSayi.Text , out int sayi))
            {
                sayi = Math.Abs(sayi);

                if(sayi== 0)
                {
                    lblSonuc.Text = "çarpım 0";
                    return;
                }
                int carpim = 1;
                int kalan;

                while(sayi>0)
                {
                    kalan = sayi % 10;
                    carpim = carpim * kalan;
                    sayi = sayi / 10;
                }
                lblSonuc.Text = "çarpım: " + carpim.ToString();
            }
            else
            {
                MessageBox.Show("geçerli sayı giriniz");
            }
        }
    }
}
