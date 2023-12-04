namespace HYS_DESKTOP
{
    partial class doktorForm
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
            kullaniciBtn = new Button();
            hastaBtn = new Button();
            randevularBtn = new Button();
            geriBtn = new Button();
            yardimBtn = new Button();
            cikisBtn = new Button();
            SuspendLayout();
            // 
            // kullaniciBtn
            // 
            kullaniciBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kullaniciBtn.Location = new Point(78, 228);
            kullaniciBtn.Name = "kullaniciBtn";
            kullaniciBtn.Size = new Size(163, 67);
            kullaniciBtn.TabIndex = 3;
            kullaniciBtn.Text = "Kullanıcı İşlemleri";
            kullaniciBtn.UseVisualStyleBackColor = true;
            // 
            // hastaBtn
            // 
            hastaBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hastaBtn.Location = new Point(78, 82);
            hastaBtn.Name = "hastaBtn";
            hastaBtn.Size = new Size(163, 67);
            hastaBtn.TabIndex = 1;
            hastaBtn.Text = "Hasta İşlemleri";
            hastaBtn.UseVisualStyleBackColor = true;
            // 
            // randevularBtn
            // 
            randevularBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            randevularBtn.Location = new Point(78, 155);
            randevularBtn.Name = "randevularBtn";
            randevularBtn.Size = new Size(163, 67);
            randevularBtn.TabIndex = 2;
            randevularBtn.Text = "Randevularım";
            randevularBtn.UseVisualStyleBackColor = true;
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
            // doktorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 318);
            Controls.Add(cikisBtn);
            Controls.Add(yardimBtn);
            Controls.Add(geriBtn);
            Controls.Add(randevularBtn);
            Controls.Add(hastaBtn);
            Controls.Add(kullaniciBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "doktorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor İşlem Formu";
            ResumeLayout(false);
        }

        #endregion

        private Button kullaniciBtn;
        private Button hastaBtn;
        private Button randevularBtn;
        private Button geriBtn;
        private Button yardimBtn;
        private Button cikisBtn;
    }
}