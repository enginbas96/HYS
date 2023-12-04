namespace HYS_DESKTOP
{
    partial class girisForm
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
            girisBtn = new Button();
            tclbl = new Label();
            sifrelbl = new Label();
            tcText = new TextBox();
            sifreText = new TextBox();
            SuspendLayout();
            // 
            // girisBtn
            // 
            girisBtn.Location = new Point(255, 271);
            girisBtn.Name = "girisBtn";
            girisBtn.Size = new Size(259, 79);
            girisBtn.TabIndex = 3;
            girisBtn.Text = "Giriş Yap";
            girisBtn.UseVisualStyleBackColor = true;
            // 
            // tclbl
            // 
            tclbl.AutoSize = true;
            tclbl.Location = new Point(255, 126);
            tclbl.Name = "tclbl";
            tclbl.Size = new Size(36, 20);
            tclbl.TabIndex = 111;
            tclbl.Text = "TC : ";
            // 
            // sifrelbl
            // 
            sifrelbl.AutoSize = true;
            sifrelbl.Location = new Point(241, 176);
            sifrelbl.Name = "sifrelbl";
            sifrelbl.Size = new Size(50, 20);
            sifrelbl.TabIndex = 211;
            sifrelbl.Text = "Şifre : ";
            // 
            // tcText
            // 
            tcText.Location = new Point(297, 123);
            tcText.Name = "tcText";
            tcText.Size = new Size(217, 27);
            tcText.TabIndex = 1;
            // 
            // sifreText
            // 
            sifreText.Location = new Point(297, 173);
            sifreText.Name = "sifreText";
            sifreText.Size = new Size(217, 27);
            sifreText.TabIndex = 2;
            // 
            // girisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sifreText);
            Controls.Add(tcText);
            Controls.Add(sifrelbl);
            Controls.Add(tclbl);
            Controls.Add(girisBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "girisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Formu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button girisBtn;
        private Label tclbl;
        private Label sifrelbl;
        private TextBox tcText;
        private TextBox sifreText;
    }
}