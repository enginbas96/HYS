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
            randevularimData = new DataGridView();
            label1 = new Label();
            geriBtn = new Button();
            yardimBtn = new Button();
            tcLbl = new Label();
            tcText = new TextBox();
            sorgulaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)randevularimData).BeginInit();
            SuspendLayout();
            // 
            // randevularimData
            // 
            randevularimData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            randevularimData.Location = new Point(12, 116);
            randevularimData.Name = "randevularimData";
            randevularimData.RowHeadersWidth = 51;
            randevularimData.RowTemplate.Height = 29;
            randevularimData.Size = new Size(387, 174);
            randevularimData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 1;
            label1.Text = "Randevularım";
            // 
            // geriBtn
            // 
            geriBtn.Location = new Point(305, 312);
            geriBtn.Name = "geriBtn";
            geriBtn.Size = new Size(94, 29);
            geriBtn.TabIndex = 3;
            geriBtn.Text = "Geri";
            geriBtn.UseVisualStyleBackColor = true;
            // 
            // yardimBtn
            // 
            yardimBtn.Location = new Point(205, 312);
            yardimBtn.Name = "yardimBtn";
            yardimBtn.Size = new Size(94, 29);
            yardimBtn.TabIndex = 4;
            yardimBtn.Text = "Yardım";
            yardimBtn.UseVisualStyleBackColor = true;
            // 
            // tcLbl
            // 
            tcLbl.AutoSize = true;
            tcLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tcLbl.Location = new Point(12, 18);
            tcLbl.Name = "tcLbl";
            tcLbl.Size = new Size(47, 28);
            tcLbl.TabIndex = 4;
            tcLbl.Text = "TC : ";
            // 
            // tcText
            // 
            tcText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tcText.Location = new Point(65, 15);
            tcText.Name = "tcText";
            tcText.Size = new Size(229, 34);
            tcText.TabIndex = 1;
            // 
            // sorgulaBtn
            // 
            sorgulaBtn.Location = new Point(305, 17);
            sorgulaBtn.Name = "sorgulaBtn";
            sorgulaBtn.Size = new Size(94, 29);
            sorgulaBtn.TabIndex = 2;
            sorgulaBtn.Text = "Sorgula";
            sorgulaBtn.UseVisualStyleBackColor = true;
            // 
            // doktorRandevular
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 359);
            Controls.Add(sorgulaBtn);
            Controls.Add(tcText);
            Controls.Add(tcLbl);
            Controls.Add(yardimBtn);
            Controls.Add(geriBtn);
            Controls.Add(label1);
            Controls.Add(randevularimData);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "doktorRandevular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevularım";
            ((System.ComponentModel.ISupportInitialize)randevularimData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView randevularimData;
        private Label label1;
        private Button geriBtn;
        private Button yardimBtn;
        private Label tcLbl;
        private TextBox tcText;
        private Button sorgulaBtn;
    }
}