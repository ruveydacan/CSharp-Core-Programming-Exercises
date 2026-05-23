using System.Runtime.InteropServices;

namespace asal_çalışma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int sayac = 2;
            int sonuc = 1;
            while (sayac < x)
            {
                sonuc = x % sayac;
                if (sonuc == 0)
                {
                    MessageBox.Show("Girilen sayı asal sayı değildir");
                    sayac = x;
                }
                sayac = sayac + 1;
            }
            if (sonuc != 0)
            {
                MessageBox.Show("Girilen sayı asal sayıdır");
            }
        }
    }
}
