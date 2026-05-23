namespace daire_çapı_bulma
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

        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            int alan;
            int pi = 3;
            r = Convert.ToInt32(textBox1.Text);
            alan = pi * r * r;
            label2.Text = "Bu dairenin alanı = " + alan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r;
            int cevre;
            int pi = 3;
            r = Convert.ToInt32(textBox1.Text);
            cevre = 2 * pi * r;
            label3.Text = "Bu dairenin çevresi = " + cevre; 
        }
    }
}
