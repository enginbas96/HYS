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
            tcLbl = new Label();
            sifreLbl = new Label();
            tcText = new TextBox();
            sifreText = new TextBox();
            SuspendLayout();
            // 
            // girisBtn
            // 
            girisBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            girisBtn.Location = new Point(211, 212);
            girisBtn.Name = "girisBtn";
            girisBtn.Size = new Size(161, 60);
            girisBtn.TabIndex = 3;
            girisBtn.Text = "Giriş Yap";
            girisBtn.UseVisualStyleBackColor = true;
            // 
            // tcLbl
            // 
            tcLbl.AutoSize = true;
            tcLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tcLbl.Location = new Point(142, 102);
            tcLbl.Name = "tcLbl";
            tcLbl.Size = new Size(47, 28);
            tcLbl.TabIndex = 111;
            tcLbl.Text = "TC : ";
            // 
            // sifreLbl
            // 
            sifreLbl.AutoSize = true;
            sifreLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sifreLbl.Location = new Point(124, 149);
            sifreLbl.Name = "sifreLbl";
            sifreLbl.Size = new Size(65, 28);
            sifreLbl.TabIndex = 211;
            sifreLbl.Text = "Şifre : ";
            // 
            // tcText
            // 
            tcText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tcText.Location = new Point(195, 99);
            tcText.Name = "tcText";
            tcText.Size = new Size(189, 34);
            tcText.TabIndex = 1;
            // 
            // sifreText
            // 
            sifreText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sifreText.Location = new Point(195, 146);
            sifreText.Name = "sifreText";
            sifreText.Size = new Size(189, 34);
            sifreText.TabIndex = 2;
            // 
            // girisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 353);
            Controls.Add(sifreText);
            Controls.Add(tcText);
            Controls.Add(sifreLbl);
            Controls.Add(tcLbl);
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
        private Label tcLbl;
        private Label sifreLbl;
        private TextBox tcText;
        private TextBox sifreText;
    }
}