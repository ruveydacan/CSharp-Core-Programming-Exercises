using System;
using System.Drawing;
using System.Windows.Forms;

namespace armstrong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Uygulama baþladýðýnda baþlýðý düzenleyelim
            this.Text = "Armstrong Sayý Gezgini";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // 1. Listeyi temizleyelim ki her basýþta sonuçlar üst üste binmesin
            lstSonuclar.Items.Clear();

            // 2. Kullanýcýdan alýnan metinleri sayýya çevirelim
            bool baslangicDogruMu = long.TryParse(txtBaslangic.Text, out long baslangic);
            bool bitisDogruMu = long.TryParse(txtBitis.Text, out long bitis);

            if (baslangicDogruMu && bitisDogruMu)
            {
                // Baþlangýç deðeri bitiþten büyükse kullanýcý hatasýný düzeltelim
                if (baslangic > bitis)
                {
                    long gecici = baslangic;
                    baslangic = bitis;
                    bitis = gecici;
                }

                int bulunanAdet = 0;

                // 3. Belirlenen aralýkta döngüye girelim
                for (long i = baslangic; i <= bitis; i++)
                {
                    if (IsArmstrong(i))
                    {
                        lstSonuclar.Items.Add(i); // Sayýyý listeye ekle
                        bulunanAdet++;
                    }
                }

                // 4. Sonuç mesajýný yazdýralým
                lblSonuc.Text = $"Toplam {bulunanAdet} tane Armstrong sayýsý bulundu.";
                lblSonuc.ForeColor = Color.DarkGreen;
            }
            else
            {
                // Geçersiz giriþ yapýldýysa uyarý verelim
                MessageBox.Show("Lütfen geçerli tam sayýlar giriniz!", "Giriþ Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Armstrong kontrolü yapan yardýmcý fonksiyon
        private bool IsArmstrong(long sayi)
        {
            if (sayi < 0) return false;

            string sayiMetin = sayi.ToString();
            int basamakSayisi = sayiMetin.Length;
            long toplam = 0;
            long geciciSayi = sayi;

            while (geciciSayi > 0)
            {
                long basamak = geciciSayi % 10;
                // Her basamaðýn, toplam basamak sayýsý kadar kuvvetini alýp ekliyoruz
                toplam += (long)Math.Pow(basamak, basamakSayisi);
                geciciSayi /= 10;
            }

            return toplam == sayi;
        }
    }
}