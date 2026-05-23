namespace armstrong3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBaslangic = new TextBox();
            txtBitis = new TextBox();
            btnHesapla = new Button();
            lstSonuclar = new ListBox();
            lblSonuc = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtBaslangic
            // 
            txtBaslangic.BackColor = Color.SeaShell;
            txtBaslangic.Location = new Point(39, 91);
            txtBaslangic.Name = "txtBaslangic";
            txtBaslangic.Size = new Size(200, 39);
            txtBaslangic.TabIndex = 0;
            // 
            // txtBitis
            // 
            txtBitis.BackColor = Color.SeaShell;
            txtBitis.Location = new Point(269, 91);
            txtBitis.Name = "txtBitis";
            txtBitis.Size = new Size(200, 39);
            txtBitis.TabIndex = 1;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.RosyBrown;
            btnHesapla.Font = new Font("Sylfaen", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnHesapla.Location = new Point(524, 84);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(150, 46);
            btnHesapla.TabIndex = 2;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lstSonuclar
            // 
            lstSonuclar.BackColor = Color.MistyRose;
            lstSonuclar.Font = new Font("Sylfaen", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstSonuclar.ForeColor = SystemColors.WindowText;
            lstSonuclar.FormattingEnabled = true;
            lstSonuclar.ItemHeight = 48;
            lstSonuclar.Location = new Point(524, 311);
            lstSonuclar.Name = "lstSonuclar";
            lstSonuclar.Size = new Size(306, 148);
            lstSonuclar.TabIndex = 3;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Sylfaen", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSonuc.ForeColor = Color.MistyRose;
            lblSonuc.Location = new Point(39, 155);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(124, 48);
            lblSonuc.TabIndex = 4;
            lblSonuc.Text = "Sonuç:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(257, 48);
            label1.TabIndex = 5;
            label1.Text = "Sayıları giriniz:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(881, 512);
            Controls.Add(label1);
            Controls.Add(lblSonuc);
            Controls.Add(lstSonuclar);
            Controls.Add(btnHesapla);
            Controls.Add(txtBitis);
            Controls.Add(txtBaslangic);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBaslangic;
        private TextBox txtBitis;
        private Button btnHesapla;
        private ListBox lstSonuclar;
        private Label lblSonuc;
        private Label label1;
    }
}
