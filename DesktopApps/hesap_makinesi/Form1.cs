namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        string girilenSayi = "";
        int sayi1 = 0;
        int sonuc = 0;
        int islemTuru = 0;
        //1 toplama, 2 çýkartma, 3 çarpma, 4 bölme
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            girilenSayi += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            girilenSayi += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            girilenSayi += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            girilenSayi += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            girilenSayi += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            girilenSayi += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            girilenSayi += "7";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "9";
            girilenSayi += "9";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "8";
            girilenSayi += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            girilenSayi += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            girilenSayi = "";
            sayi1 = 0;
            sonuc = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            sayi1 = Convert.ToInt32(girilenSayi);
            sonuc += sayi1;
            girilenSayi = "";
            islemTuru = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(girilenSayi);
            if (islemTuru == 1)
            {
                sonuc += sayi1;
            }
            if (islemTuru == 2)
            {
                sonuc -= sayi1;
            }
            if (islemTuru == 3)
            {
                sonuc *= sayi1;
            }
            if (islemTuru == 4)
            {
                sonuc /= sayi1;
            }
            textBox1.Text = sonuc.ToString();
            girilenSayi = sonuc.ToString();
            sonuc = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            sayi1 = Convert.ToInt32(girilenSayi);
            sonuc = sayi1;
            girilenSayi = "";
            islemTuru = 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "x";
            sayi1 = Convert.ToInt32(girilenSayi);
            sonuc = sayi1;
            girilenSayi = "";
            islemTuru = 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            sayi1 = Convert.ToInt32(girilenSayi);
            sonuc = sayi1;
            girilenSayi = "";
            islemTuru = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
