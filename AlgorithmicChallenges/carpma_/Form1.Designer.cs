namespace çarpmaçalışma
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
            btnHesapla = new Button();
            txtSayi = new TextBox();
            lblSonuc = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHesapla
            // 
            btnHesapla.Font = new Font("Sitka Banner", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnHesapla.ForeColor = Color.Maroon;
            btnHesapla.Location = new Point(106, 187);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(150, 63);
            btnHesapla.TabIndex = 0;
            btnHesapla.Text = "ÇARP";
            btnHesapla.TextAlign = ContentAlignment.BottomCenter;
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtSayi
            // 
            txtSayi.Font = new Font("Sitka Banner", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSayi.ForeColor = Color.Maroon;
            txtSayi.Location = new Point(247, 107);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(200, 54);
            txtSayi.TabIndex = 1;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Sitka Banner", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSonuc.ForeColor = Color.RosyBrown;
            lblSonuc.Location = new Point(106, 289);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(438, 53);
            lblSonuc.TabIndex = 2;
            lblSonuc.Text = "Sayının basamakları çarpımı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(106, 107);
            label1.Name = "label1";
            label1.Size = new Size(135, 53);
            label1.TabIndex = 3;
            label1.Text = "Sayınız:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblSonuc);
            Controls.Add(txtSayi);
            Controls.Add(btnHesapla);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHesapla;
        private TextBox txtSayi;
        private Label lblSonuc;
        private Label label1;
    }
}
