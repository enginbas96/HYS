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
            geriBtn = new Button();
            ilaclarList = new ListBox();
            tcText = new TextBox();
            sorgulaBtn = new Button();
            ilacEkleBtn = new Button();
            ilaclarComboBox = new ComboBox();
            SuspendLayout();
            // 
            // tcLbl
            // 
            tcLbl.AutoSize = true;
            tcLbl.Location = new Point(12, 9);
            tcLbl.Name = "tcLbl";
            tcLbl.Size = new Size(36, 20);
            tcLbl.TabIndex = 0;
            tcLbl.Text = "TC : ";
            // 
            // sevkEtBtn
            // 
            sevkEtBtn.AutoSize = true;
            sevkEtBtn.Location = new Point(54, 305);
            sevkEtBtn.Name = "sevkEtBtn";
            sevkEtBtn.Size = new Size(111, 20);
            sevkEtBtn.TabIndex = 2;
            sevkEtBtn.TabStop = true;
            sevkEtBtn.Text = "Hastayı sevk Et ";
            // 
            // sikayetBtn
            // 
            sikayetBtn.AutoSize = true;
            sikayetBtn.Location = new Point(53, 341);
            sikayetBtn.Name = "sikayetBtn";
            sikayetBtn.Size = new Size(124, 20);
            sikayetBtn.TabIndex = 3;
            sikayetBtn.TabStop = true;
            sikayetBtn.Text = "Hastayı şikayet et";
            // 
            // geriBtn
            // 
            geriBtn.Location = new Point(694, 12);
            geriBtn.Name = "geriBtn";
            geriBtn.Size = new Size(94, 29);
            geriBtn.TabIndex = 4;
            geriBtn.Text = "geri buton";
            geriBtn.UseVisualStyleBackColor = true;
            // 
            // ilaclarList
            // 
            ilaclarList.FormattingEnabled = true;
            ilaclarList.ItemHeight = 20;
            ilaclarList.Location = new Point(54, 102);
            ilaclarList.Name = "ilaclarList";
            ilaclarList.Size = new Size(191, 164);
            ilaclarList.TabIndex = 5;
            // 
            // tcText
            // 
            tcText.Location = new Point(54, 6);
            tcText.Name = "tcText";
            tcText.Size = new Size(173, 27);
            tcText.TabIndex = 1;
            // 
            // sorgulaBtn
            // 
            sorgulaBtn.Location = new Point(261, 4);
            sorgulaBtn.Name = "sorgulaBtn";
            sorgulaBtn.Size = new Size(95, 29);
            sorgulaBtn.TabIndex = 6;
            sorgulaBtn.Text = "Sorgula";
            sorgulaBtn.UseVisualStyleBackColor = true;
            // 
            // ilacEkleBtn
            // 
            ilacEkleBtn.Location = new Point(231, 50);
            ilacEkleBtn.Name = "ilacEkleBtn";
            ilacEkleBtn.Size = new Size(125, 33);
            ilacEkleBtn.TabIndex = 7;
            ilacEkleBtn.Text = "İlaç Ekle";
            ilacEkleBtn.UseVisualStyleBackColor = true;
            // 
            // ilaclarComboBox
            // 
            ilaclarComboBox.FormattingEnabled = true;
            ilaclarComboBox.Location = new Point(54, 53);
            ilaclarComboBox.Name = "ilaclarComboBox";
            ilaclarComboBox.Size = new Size(155, 28);
            ilaclarComboBox.TabIndex = 8;
            // 
            // doktorHastaIslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ilaclarComboBox);
            Controls.Add(ilacEkleBtn);
            Controls.Add(sorgulaBtn);
            Controls.Add(tcText);
            Controls.Add(ilaclarList);
            Controls.Add(geriBtn);
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
        private Button geriBtn;
        private ListBox ilaclarList;
        private TextBox tcText;
        private Button sorgulaBtn;
        private Button ilacEkleBtn;
        private ComboBox ilaclarComboBox;
    }
}