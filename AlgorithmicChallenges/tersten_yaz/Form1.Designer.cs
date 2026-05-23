namespace terstenyaz
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
            lblSonuc = new Label();
            txtSayi = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = SystemColors.ControlDark;
            btnHesapla.Font = new Font("Corbel", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHesapla.ForeColor = SystemColors.ActiveCaptionText;
            btnHesapla.Location = new Point(278, 115);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(148, 117);
            btnHesapla.TabIndex = 0;
            btnHesapla.Text = "terse çevir";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Corbel", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSonuc.Location = new Point(42, 273);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(126, 45);
            lblSonuc.TabIndex = 1;
            lblSonuc.Text = "Sonuç:";
            // 
            // txtSayi
            // 
            txtSayi.BackColor = SystemColors.HotTrack;
            txtSayi.Font = new Font("Corbel", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSayi.ForeColor = SystemColors.HighlightText;
            txtSayi.Location = new Point(278, 43);
            txtSayi.Name = "txtSayi";
            txtSayi.Size = new Size(148, 53);
            txtSayi.TabIndex = 2;
            txtSayi.TextChanged += txtSayi_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 46);
            label1.Name = "label1";
            label1.Size = new Size(230, 45);
            label1.TabIndex = 3;
            label1.Text = "Sayıyı giriniz:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtSayi);
            Controls.Add(lblSonuc);
            Controls.Add(btnHesapla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHesapla;
        private Label lblSonuc;
        private TextBox txtSayi;
        private Label label1;
    }
}
