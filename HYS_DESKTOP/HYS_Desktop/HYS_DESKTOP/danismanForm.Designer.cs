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
            cikisBtn = new Button();
            yardimBtn = new Button();
            geriBtn = new Button();
            SuspendLayout();
            // 
            // hastaKayitBtn
            // 
            hastaKayitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hastaKayitBtn.Location = new Point(76, 77);
            hastaKayitBtn.Name = "hastaKayitBtn";
            hastaKayitBtn.Size = new Size(163, 67);
            hastaKayitBtn.TabIndex = 1;
            hastaKayitBtn.Text = "Hasta Kayıt İşlemleri";
            hastaKayitBtn.UseVisualStyleBackColor = true;
            // 
            // randevuBtn
            // 
            randevuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            randevuBtn.Location = new Point(76, 167);
            randevuBtn.Name = "randevuBtn";
            randevuBtn.Size = new Size(163, 67);
            randevuBtn.TabIndex = 2;
            randevuBtn.Text = "Randevu İşlemleri";
            randevuBtn.UseVisualStyleBackColor = true;
            // 
            // kullaniciBtn
            // 
            kullaniciBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kullaniciBtn.Location = new Point(76, 257);
            kullaniciBtn.Name = "kullaniciBtn";
            kullaniciBtn.Size = new Size(163, 67);
            kullaniciBtn.TabIndex = 3;
            kullaniciBtn.Text = "Kullanıcı İşlemleri";
            kullaniciBtn.UseVisualStyleBackColor = true;
            // 
            // cikisBtn
            // 
            cikisBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cikisBtn.Location = new Point(212, 12);
            cikisBtn.Name = "cikisBtn";
            cikisBtn.Size = new Size(94, 40);
            cikisBtn.TabIndex = 5;
            cikisBtn.Text = "Çıkış Buton";
            cikisBtn.UseVisualStyleBackColor = true;
            // 
            // yardimBtn
            // 
            yardimBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yardimBtn.Location = new Point(12, 12);
            yardimBtn.Name = "yardimBtn";
            yardimBtn.Size = new Size(94, 40);
            yardimBtn.TabIndex = 6;
            yardimBtn.Text = "Yardım";
            yardimBtn.UseVisualStyleBackColor = true;
            // 
            // geriBtn
            // 
            geriBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            geriBtn.Location = new Point(112, 12);
            geriBtn.Name = "geriBtn";
            geriBtn.Size = new Size(94, 40);
            geriBtn.TabIndex = 4;
            geriBtn.Text = "Geri Buton";
            geriBtn.UseVisualStyleBackColor = true;
            // 
            // danismanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 341);
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
        private Button cikisBtn;
        private Button yardimBtn;
        private Button geriBtn;
    }
}