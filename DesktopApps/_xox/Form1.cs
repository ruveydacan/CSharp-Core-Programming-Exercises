using System;
using System.Windows.Forms;

namespace xox
{
    public partial class Form1 : Form
    {
        int whichPlayer = 1; // 1 for X, 2 for O

        int tahta1 = 0, tahta2 = 0, tahta3 = 0;
        int tahta4 = 0, tahta5 = 0, tahta6 = 0;
        int tahta7 = 0, tahta8 = 0, tahta9 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void CheckWinner()
        {
            // --- OYUNCU X ÝÇÝN KONTROLLER (1) ---
            // Yatay Kontroller
            if ((tahta1 == 1 && tahta2 == 1 && tahta3 == 1) ||
                (tahta4 == 1 && tahta5 == 1 && tahta6 == 1) ||
                (tahta7 == 1 && tahta8 == 1 && tahta9 == 1) ||
            // Dikey Kontroller
                (tahta1 == 1 && tahta4 == 1 && tahta7 == 1) ||
                (tahta2 == 1 && tahta5 == 1 && tahta8 == 1) ||
                (tahta3 == 1 && tahta6 == 1 && tahta9 == 1) ||
            // Çapraz Kontroller
                (tahta1 == 1 && tahta5 == 1 && tahta9 == 1) ||
                (tahta3 == 1 && tahta5 == 1 && tahta7 == 1))
            {
                MessageBox.Show("Player X wins!!!!!!!!!!!!!!");
                ResetGame();
                return;
            }

            // --- OYUNCU O ÝÇÝN KONTROLLER (2) ---
            // Yatay Kontroller
            if ((tahta1 == 2 && tahta2 == 2 && tahta3 == 2) ||
                (tahta4 == 2 && tahta5 == 2 && tahta6 == 2) ||
                (tahta7 == 2 && tahta8 == 2 && tahta9 == 2) ||
            // Dikey Kontroller
                (tahta1 == 2 && tahta4 == 2 && tahta7 == 2) ||
                (tahta2 == 2 && tahta5 == 2 && tahta8 == 2) ||
                (tahta3 == 2 && tahta6 == 2 && tahta9 == 2) ||
            // Çapraz Kontroller
                (tahta1 == 2 && tahta5 == 2 && tahta9 == 2) ||
                (tahta3 == 2 && tahta5 == 2 && tahta7 == 2))
            {
                MessageBox.Show("Player O wins!!!!!!!!!!!!!!");
                ResetGame();
                return;
            }
        }

        // Biri kazandýktan sonra tahtayý sýfýrlamak için küçük bir metot
        private void ResetGame()
        {
            tahta1 = tahta2 = tahta3 = tahta4 = tahta5 = tahta6 = tahta7 = tahta8 = tahta9 = 0;
            button1.Text = button2.Text = button3.Text = "";
            button4.Text = button5.Text = button6.Text = "";
            button7.Text = button8.Text = button9.Text = "";

            button1.Enabled = button2.Enabled = button3.Enabled = true;
            button4.Enabled = button5.Enabled = button6.Enabled = true;
            button7.Enabled = button8.Enabled = button9.Enabled = true;

            whichPlayer = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (whichPlayer == 1) { button1.Text = "X"; whichPlayer = 2; tahta1 = 1; }
            else { button1.Text = "O"; whichPlayer = 1; tahta1 = 2; }
            button1.Enabled = false;
            CheckWinner(); // <-- Kontrolü buraya ekledik
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (whichPlayer == 1) { button2.Text = "X"; whichPlayer = 2; tahta2 = 1; }
            else { button2.Text = "O"; whichPlayer = 1; tahta2 = 2; }
            button2.Enabled = false;
            CheckWinner(); // <-- Kontrolü buraya ekledik
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (whichPlayer == 1) { button3.Text = "X"; whichPlayer = 2; tahta3 = 1; }
            else { button3.Text = "O"; whichPlayer = 1; tahta3 = 2; }
            button3.Enabled = false;
            CheckWinner(); // <-- Kontrolü buraya ekledik
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (whichPlayer == 1) { button4.Text = "X"; whichPlayer = 2; tahta4 = 1; }
            else { button4.Text = "O"; whichPlayer = 1; tahta4 = 2; }
            button4.Enabled = false;
            CheckWinner(); // <-- Kontrolü buraya ekledik
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (whichPlayer == 1) { button5.Text = "X"; whichPlayer = 2; tahta5 = 1; }
            else { button5.Text = "O"; whichPlayer = 1; tahta5 = 2; }
            button5.Enabled = false;
            CheckWinner(); // <-- Kontrolü buraya ekledik
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (whichPlayer == 1) { button6.Text = "X"; whichPlayer = 2; tahta6 = 1; }
            else { button6.Text = "O"; whichPlayer = 1; tahta6 = 2; }
            button6.Enabled = false;
            CheckWinner(); // <-- Kontrolü buraya ekledik
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (whichPlayer == 1) { button7.Text = "X"; whichPlayer = 2; tahta7 = 1; }
            else { button7.Text = "O"; whichPlayer = 1; tahta7 = 2; }
            button7.Enabled = false;
            CheckWinner(); // <-- Kontrolü buraya ekledik
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (whichPlayer == 1) { button8.Text = "X"; whichPlayer = 2; tahta8 = 1; }
            else { button8.Text = "O"; whichPlayer = 1; tahta8 = 2; }
            button8.Enabled = false;
            CheckWinner(); // <-- Kontrolü buraya ekledik
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (whichPlayer == 1) { button9.Text = "X"; whichPlayer = 2; tahta9 = 1; }
            else { button9.Text = "O"; whichPlayer = 1; tahta9 = 2; }
            button9.Enabled = false;
            CheckWinner(); // <-- Kontrolü buraya ekledik
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}