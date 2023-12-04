namespace HYS_DESKTOP
{
    partial class doktorHastaIslem
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
            tcLbl = new Label();
            sevkEtBtn = new LinkLabel();
            sikayetBtn = new LinkLabel();
            ilaclarList = new ListBox();
            tcText = new TextBox();
            sorgulaBtn = new Button();
            ilacEkleBtn = new Button();
            ilaclarCB = new ComboBox();
            geriBtn = new Button();
            kaydetBtn = new Button();
            SuspendLayout();
            // 
            // tcLbl
            // 
            tcLbl.AutoSize = true;
            tcLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tcLbl.Location = new Point(12, 28);
            tcLbl.Name = "tcLbl";
            tcLbl.Size = new Size(47, 28);
            tcLbl.TabIndex = 1111;
            tcLbl.Text = "TC : ";
            // 
            // sevkEtBtn
            // 
            sevkEtBtn.AutoSize = true;
            sevkEtBtn.Location = new Point(65, 308);
            sevkEtBtn.Name = "sevkEtBtn";
            sevkEtBtn.Size = new Size(111, 20);
            sevkEtBtn.TabIndex = 7;
            sevkEtBtn.TabStop = true;
            sevkEtBtn.Text = "Hastayı sevk Et ";
            // 
            // sikayetBtn
            // 
            sikayetBtn.AutoSize = true;
            sikayetBtn.Location = new Point(233, 308);
            sikayetBtn.Name = "sikayetBtn";
            sikayetBtn.Size = new Size(124, 20);
            sikayetBtn.TabIndex = 8;
            sikayetBtn.TabStop = true;
            sikayetBtn.Text = "Hastayı şikayet et";
            // 
            // ilaclarList
            // 
            ilaclarList.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ilaclarList.FormattingEnabled = true;
            ilaclarList.ItemHeight = 23;
            ilaclarList.Location = new Point(65, 147);
            ilaclarList.Name = "ilaclarList";
            ilaclarList.Size = new Size(292, 142);
            ilaclarList.TabIndex = 5;
            // 
            // tcText
            // 
            tcText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tcText.Location = new Point(65, 25);
            tcText.Name = "tcText";
            tcText.Size = new Size(173, 34);
            tcText.TabIndex = 1;
            // 
            // sorgulaBtn
            // 
            sorgulaBtn.Location = new Point(262, 28);
            sorgulaBtn.Name = "sorgulaBtn";
            sorgulaBtn.Size = new Size(95, 29);
            sorgulaBtn.TabIndex = 2;
            sorgulaBtn.Text = "Sorgula";
            sorgulaBtn.UseVisualStyleBackColor = true;
            // 
            // ilacEkleBtn
            // 
            ilacEkleBtn.Location = new Point(262, 89);
            ilacEkleBtn.Name = "ilacEkleBtn";
            ilacEkleBtn.Size = new Size(95, 33);
            ilacEkleBtn.TabIndex = 4;
            ilacEkleBtn.Text = "İlaç Ekle";
            ilacEkleBtn.UseVisualStyleBackColor = true;
            // 
            // ilaclarCB
            // 
            ilaclarCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ilaclarCB.FormattingEnabled = true;
            ilaclarCB.Location = new Point(65, 85);
            ilaclarCB.Name = "ilaclarCB";
            ilaclarCB.Size = new Size(173, 36);
            ilaclarCB.TabIndex = 3;
            // 
            // geriBtn
            // 
            geriBtn.Location = new Point(255, 362);
            geriBtn.Name = "geriBtn";
            geriBtn.Size = new Size(102, 29);
            geriBtn.TabIndex = 9;
            geriBtn.Text = "Geri";
            geriBtn.UseVisualStyleBackColor = true;
            // 
            // kaydetBtn
            // 
            kaydetBtn.Location = new Point(65, 362);
            kaydetBtn.Name = "kaydetBtn";
            kaydetBtn.Size = new Size(102, 29);
            kaydetBtn.TabIndex = 6;
            kaydetBtn.Text = "Kaydet";
            kaydetBtn.UseVisualStyleBackColor = true;
            // 
            // doktorHastaIslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 408);
            Controls.Add(kaydetBtn);
            Controls.Add(geriBtn);
            Controls.Add(ilaclarCB);
            Controls.Add(ilacEkleBtn);
            Controls.Add(sorgulaBtn);
            Controls.Add(tcText);
            Controls.Add(ilaclarList);
            Controls.Add(sikayetBtn);
            Controls.Add(sevkEtBtn);
            Controls.Add(tcLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "doktorHastaIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta İşlem Formu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tcLbl;
        private LinkLabel sevkEtBtn;
        private LinkLabel sikayetBtn;
        private ListBox ilaclarList;
        private TextBox tcText;
        private Button sorgulaBtn;
        private Button ilacEkleBtn;
        private ComboBox ilaclarCB;
        private Button geriBtn;
        private Button kaydetBtn;
    }
}