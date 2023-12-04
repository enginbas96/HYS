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
            kullaniciBtn.Location = new Point(253, 303);
            kullaniciBtn.Name = "kullaniciBtn";
            kullaniciBtn.Size = new Size(224, 101);
            kullaniciBtn.TabIndex = 2;
            kullaniciBtn.Text = "Kullanıcı İşlemleri";
            kullaniciBtn.UseVisualStyleBackColor = true;
            // 
            // hastaBtn
            // 
            hastaBtn.Location = new Point(253, 57);
            hastaBtn.Name = "hastaBtn";
            hastaBtn.Size = new Size(224, 101);
            hastaBtn.TabIndex = 0;
            hastaBtn.Text = "Hasta İşlemleri";
            hastaBtn.UseVisualStyleBackColor = true;
            // 
            // randevularBtn
            // 
            randevularBtn.Location = new Point(253, 177);
            randevularBtn.Name = "randevularBtn";
            randevularBtn.Size = new Size(224, 101);
            randevularBtn.TabIndex = 3;
            randevularBtn.Text = "Randevularım";
            randevularBtn.UseVisualStyleBackColor = true;
            // 
            // geriBtn
            // 
            geriBtn.Location = new Point(603, 57);
            geriBtn.Name = "geriBtn";
            geriBtn.Size = new Size(94, 29);
            geriBtn.TabIndex = 4;
            geriBtn.Text = "Geri Buton";
            geriBtn.UseVisualStyleBackColor = true;
            // 
            // yardimBtn
            // 
            yardimBtn.Location = new Point(618, 109);
            yardimBtn.Name = "yardimBtn";
            yardimBtn.Size = new Size(88, 49);
            yardimBtn.TabIndex = 5;
            yardimBtn.Text = "Yardım";
            yardimBtn.UseVisualStyleBackColor = true;
            // 
            // cikisBtn
            // 
            cikisBtn.Location = new Point(620, 191);
            cikisBtn.Name = "cikisBtn";
            cikisBtn.Size = new Size(92, 31);
            cikisBtn.TabIndex = 6;
            cikisBtn.Text = "Çıkış Buton";
            cikisBtn.UseVisualStyleBackColor = true;
            // 
            // doktorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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