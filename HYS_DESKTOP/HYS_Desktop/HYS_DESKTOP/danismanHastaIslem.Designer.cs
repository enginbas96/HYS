namespace HYS_DESKTOP
{
    partial class danismanHastaIslem
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
            tcText = new TextBox();
            tcLbl = new Label();
            sorgulaBtn = new Button();
            silBtn = new Button();
            guncelleBtn = new Button();
            adLbl = new Label();
            adText = new TextBox();
            label1 = new Label();
            soyadText = new TextBox();
            label2 = new Label();
            telefonText = new TextBox();
            dogumTarihi = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            erkekRB = new RadioButton();
            kadinRB = new RadioButton();
            kaydetBtn = new Button();
            SuspendLayout();
            // 
            // tcText
            // 
            tcText.Location = new Point(78, 35);
            tcText.Name = "tcText";
            tcText.Size = new Size(125, 27);
            tcText.TabIndex = 0;
            // 
            // tcLbl
            // 
            tcLbl.AutoSize = true;
            tcLbl.Location = new Point(36, 38);
            tcLbl.Name = "tcLbl";
            tcLbl.Size = new Size(36, 20);
            tcLbl.TabIndex = 1;
            tcLbl.Text = "TC : ";
            // 
            // sorgulaBtn
            // 
            sorgulaBtn.Location = new Point(209, 34);
            sorgulaBtn.Name = "sorgulaBtn";
            sorgulaBtn.Size = new Size(94, 29);
            sorgulaBtn.TabIndex = 2;
            sorgulaBtn.Text = "Sorgula";
            sorgulaBtn.UseVisualStyleBackColor = true;
            // 
            // silBtn
            // 
            silBtn.Location = new Point(320, 34);
            silBtn.Name = "silBtn";
            silBtn.Size = new Size(133, 34);
            silBtn.TabIndex = 3;
            silBtn.Text = "Sil Button";
            silBtn.UseVisualStyleBackColor = true;
            // 
            // guncelleBtn
            // 
            guncelleBtn.Location = new Point(82, 385);
            guncelleBtn.Name = "guncelleBtn";
            guncelleBtn.Size = new Size(121, 36);
            guncelleBtn.TabIndex = 4;
            guncelleBtn.Text = "Güncelle";
            guncelleBtn.UseVisualStyleBackColor = true;
            // 
            // adLbl
            // 
            adLbl.AutoSize = true;
            adLbl.Location = new Point(94, 121);
            adLbl.Name = "adLbl";
            adLbl.Size = new Size(39, 20);
            adLbl.TabIndex = 6;
            adLbl.Text = "Ad : ";
            // 
            // adText
            // 
            adText.Location = new Point(139, 118);
            adText.Name = "adText";
            adText.Size = new Size(125, 27);
            adText.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 167);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 8;
            label1.Text = "Soyad : ";
            // 
            // soyadText
            // 
            soyadText.Location = new Point(139, 164);
            soyadText.Name = "soyadText";
            soyadText.Size = new Size(125, 27);
            soyadText.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 212);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 10;
            label2.Text = "Telefon : ";
            // 
            // telefonText
            // 
            telefonText.Location = new Point(139, 209);
            telefonText.Name = "telefonText";
            telefonText.Size = new Size(125, 27);
            telefonText.TabIndex = 9;
            // 
            // dogumTarihi
            // 
            dogumTarihi.Location = new Point(139, 254);
            dogumTarihi.Name = "dogumTarihi";
            dogumTarihi.Size = new Size(220, 27);
            dogumTarihi.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 259);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 12;
            label3.Text = "Doğum Yılı : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 307);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 13;
            label4.Text = "Cinsiyet : ";
            // 
            // erkekRB
            // 
            erkekRB.AutoSize = true;
            erkekRB.Location = new Point(158, 305);
            erkekRB.Name = "erkekRB";
            erkekRB.Size = new Size(65, 24);
            erkekRB.TabIndex = 14;
            erkekRB.TabStop = true;
            erkekRB.Text = "Erkek";
            erkekRB.UseVisualStyleBackColor = true;
            // 
            // kadinRB
            // 
            kadinRB.AutoSize = true;
            kadinRB.Location = new Point(242, 305);
            kadinRB.Name = "kadinRB";
            kadinRB.Size = new Size(68, 24);
            kadinRB.TabIndex = 15;
            kadinRB.TabStop = true;
            kadinRB.Text = "Kadın";
            kadinRB.UseVisualStyleBackColor = true;
            // 
            // kaydetBtn
            // 
            kaydetBtn.Location = new Point(227, 378);
            kaydetBtn.Name = "kaydetBtn";
            kaydetBtn.Size = new Size(132, 43);
            kaydetBtn.TabIndex = 16;
            kaydetBtn.Text = "Kaydet";
            kaydetBtn.UseVisualStyleBackColor = true;
            // 
            // danismanHastaIslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kaydetBtn);
            Controls.Add(kadinRB);
            Controls.Add(erkekRB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dogumTarihi);
            Controls.Add(label2);
            Controls.Add(telefonText);
            Controls.Add(label1);
            Controls.Add(soyadText);
            Controls.Add(adLbl);
            Controls.Add(adText);
            Controls.Add(guncelleBtn);
            Controls.Add(silBtn);
            Controls.Add(sorgulaBtn);
            Controls.Add(tcLbl);
            Controls.Add(tcText);
            Name = "danismanHastaIslem";
            Text = "Hasta İşlem Formu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tcText;
        private Label tcLbl;
        private Button sorgulaBtn;
        private Button silBtn;
        private Button guncelleBtn;
        private Label adLbl;
        private TextBox adText;
        private Label label1;
        private TextBox soyadText;
        private Label label2;
        private TextBox telefonText;
        private DateTimePicker dogumTarihi;
        private Label label3;
        private Label label4;
        private RadioButton erkekRB;
        private RadioButton kadinRB;
        private Button kaydetBtn;
    }
}