namespace HYS_DESKTOP
{
    partial class doktorRandevular
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
            randevularData = new DataGridView();
            label1 = new Label();
            geriBtn = new Button();
            yardimBtn = new Button();
            tcLbl = new Label();
            tcText = new TextBox();
            sorgulaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)randevularData).BeginInit();
            SuspendLayout();
            // 
            // randevularData
            // 
            randevularData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            randevularData.Location = new Point(12, 264);
            randevularData.Name = "randevularData";
            randevularData.RowHeadersWidth = 51;
            randevularData.RowTemplate.Height = 29;
            randevularData.Size = new Size(490, 174);
            randevularData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 241);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Randevularım";
            // 
            // geriBtn
            // 
            geriBtn.Location = new Point(694, 336);
            geriBtn.Name = "geriBtn";
            geriBtn.Size = new Size(94, 29);
            geriBtn.TabIndex = 2;
            geriBtn.Text = "Geri";
            geriBtn.UseVisualStyleBackColor = true;
            // 
            // yardimBtn
            // 
            yardimBtn.Location = new Point(695, 388);
            yardimBtn.Name = "yardimBtn";
            yardimBtn.Size = new Size(94, 29);
            yardimBtn.TabIndex = 3;
            yardimBtn.Text = "Yardım";
            yardimBtn.UseVisualStyleBackColor = true;
            // 
            // tcLbl
            // 
            tcLbl.AutoSize = true;
            tcLbl.Location = new Point(31, 29);
            tcLbl.Name = "tcLbl";
            tcLbl.Size = new Size(36, 20);
            tcLbl.TabIndex = 4;
            tcLbl.Text = "TC : ";
            // 
            // tcText
            // 
            tcText.Location = new Point(73, 26);
            tcText.Name = "tcText";
            tcText.Size = new Size(229, 27);
            tcText.TabIndex = 5;
            // 
            // sorgulaBtn
            // 
            sorgulaBtn.Location = new Point(308, 25);
            sorgulaBtn.Name = "sorgulaBtn";
            sorgulaBtn.Size = new Size(94, 29);
            sorgulaBtn.TabIndex = 6;
            sorgulaBtn.Text = "Sorgula";
            sorgulaBtn.UseVisualStyleBackColor = true;
            // 
            // doktorRandevular
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sorgulaBtn);
            Controls.Add(tcText);
            Controls.Add(tcLbl);
            Controls.Add(yardimBtn);
            Controls.Add(geriBtn);
            Controls.Add(label1);
            Controls.Add(randevularData);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "doktorRandevular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevularım";
            ((System.ComponentModel.ISupportInitialize)randevularData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView randevularData;
        private Label label1;
        private Button geriBtn;
        private Button yardimBtn;
        private Label tcLbl;
        private TextBox tcText;
        private Button sorgulaBtn;
    }
}