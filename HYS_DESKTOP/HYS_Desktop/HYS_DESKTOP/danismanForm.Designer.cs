namespace HYS_DESKTOP
{
    partial class danismanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hastaKayitBtn = new Button();
            randevuBtn = new Button();
            kullaniciBtn = new Button();
            geriBtn = new Button();
            yardimBtn = new Button();
            cikisBtn = new Button();
            SuspendLayout();
            // 
            // hastaKayitBtn
            // 
            hastaKayitBtn.Location = new Point(86, 12);
            hastaKayitBtn.Name = "hastaKayitBtn";
            hastaKayitBtn.Size = new Size(232, 84);
            hastaKayitBtn.TabIndex = 1;
            hastaKayitBtn.Text = "Hasta Kayıt İşlemleri";
            hastaKayitBtn.UseVisualStyleBackColor = true;
            // 
            // randevuBtn
            // 
            randevuBtn.Location = new Point(86, 102);
            randevuBtn.Name = "randevuBtn";
            randevuBtn.Size = new Size(232, 84);
            randevuBtn.TabIndex = 2;
            randevuBtn.Text = "Randevu İşlemleri";
            randevuBtn.UseVisualStyleBackColor = true;
            // 
            // kullaniciBtn
            // 
            kullaniciBtn.Location = new Point(86, 192);
            kullaniciBtn.Name = "kullaniciBtn";
            kullaniciBtn.Size = new Size(232, 84);
            kullaniciBtn.TabIndex = 3;
            kullaniciBtn.Text = "Kullanıcı İşlemleri";
            kullaniciBtn.UseVisualStyleBackColor = true;
            // 
            // geriBtn
            // 
            geriBtn.Location = new Point(556, 63);
            geriBtn.Name = "geriBtn";
            geriBtn.Size = new Size(94, 29);
            geriBtn.TabIndex = 4;
            geriBtn.Text = "Geri Buton";
            geriBtn.UseVisualStyleBackColor = true;
            // 
            // yardimBtn
            // 
            yardimBtn.Location = new Point(554, 125);
            yardimBtn.Name = "yardimBtn";
            yardimBtn.Size = new Size(111, 43);
            yardimBtn.TabIndex = 5;
            yardimBtn.Text = "Yardım Buton";
            yardimBtn.UseVisualStyleBackColor = true;
            // 
            // cikisBtn
            // 
            cikisBtn.Location = new Point(535, 191);
            cikisBtn.Name = "cikisBtn";
            cikisBtn.Size = new Size(113, 40);
            cikisBtn.TabIndex = 6;
            cikisBtn.Text = "Çıkış Buton";
            cikisBtn.UseVisualStyleBackColor = true;
            // 
            // danismanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cikisBtn);
            Controls.Add(yardimBtn);
            Controls.Add(geriBtn);
            Controls.Add(kullaniciBtn);
            Controls.Add(randevuBtn);
            Controls.Add(hastaKayitBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "danismanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danışman İşlem Formu";
            ResumeLayout(false);
        }

        #endregion

        private Button hastaKayitBtn;
        private Button randevuBtn;
        private Button kullaniciBtn;
        private Button geriBtn;
        private Button yardimBtn;
        private Button cikisBtn;
    }
}