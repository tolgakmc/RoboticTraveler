namespace RoboticTraveler
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.RightCornerXTxt = new System.Windows.Forms.TextBox();
            this.RightCornerLbl = new System.Windows.Forms.Label();
            this.SecondLettersLbl = new System.Windows.Forms.Label();
            this.SecondLocLbl = new System.Windows.Forms.Label();
            this.FirstLettersLbl = new System.Windows.Forms.Label();
            this.FirstLocLbl = new System.Windows.Forms.Label();
            this.SecondLettersTxt = new System.Windows.Forms.TextBox();
            this.SecondLocXTxt = new System.Windows.Forms.TextBox();
            this.FirstLettersTxt = new System.Windows.Forms.TextBox();
            this.FirstLocXTxt = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.RightCornerYTxt = new System.Windows.Forms.TextBox();
            this.FirstLocYTxt = new System.Windows.Forms.TextBox();
            this.SecondLocYTxt = new System.Windows.Forms.TextBox();
            this.FirstLocCmb = new System.Windows.Forms.ComboBox();
            this.SecondLocCmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RightCornerXTxt
            // 
            this.RightCornerXTxt.Location = new System.Drawing.Point(218, 60);
            this.RightCornerXTxt.Name = "RightCornerXTxt";
            this.RightCornerXTxt.Size = new System.Drawing.Size(32, 20);
            this.RightCornerXTxt.TabIndex = 0;
            this.RightCornerXTxt.TextChanged += new System.EventHandler(this.RightCornerXTxt_TextChanged);
            // 
            // RightCornerLbl
            // 
            this.RightCornerLbl.AllowDrop = true;
            this.RightCornerLbl.AutoSize = true;
            this.RightCornerLbl.Location = new System.Drawing.Point(27, 63);
            this.RightCornerLbl.Name = "RightCornerLbl";
            this.RightCornerLbl.Size = new System.Drawing.Size(158, 13);
            this.RightCornerLbl.TabIndex = 1;
            this.RightCornerLbl.Text = "Sağ Üst Köşe Koordinatları: (x,y)";
            // 
            // SecondLettersLbl
            // 
            this.SecondLettersLbl.AllowDrop = true;
            this.SecondLettersLbl.AutoSize = true;
            this.SecondLettersLbl.Location = new System.Drawing.Point(27, 194);
            this.SecondLettersLbl.Name = "SecondLettersLbl";
            this.SecondLettersLbl.Size = new System.Drawing.Size(188, 13);
            this.SecondLettersLbl.TabIndex = 2;
            this.SecondLettersLbl.Text = "İkinci Gezgin İçin Harf Katarı: (L, R, M)";
            // 
            // SecondLocLbl
            // 
            this.SecondLocLbl.AllowDrop = true;
            this.SecondLocLbl.AutoSize = true;
            this.SecondLocLbl.Location = new System.Drawing.Point(27, 163);
            this.SecondLocLbl.Name = "SecondLocLbl";
            this.SecondLocLbl.Size = new System.Drawing.Size(163, 13);
            this.SecondLocLbl.TabIndex = 3;
            this.SecondLocLbl.Text = "İkinci Gezginin Konumu: (x,y,yön)";
            // 
            // FirstLettersLbl
            // 
            this.FirstLettersLbl.AllowDrop = true;
            this.FirstLettersLbl.AutoSize = true;
            this.FirstLettersLbl.Location = new System.Drawing.Point(27, 131);
            this.FirstLettersLbl.Name = "FirstLettersLbl";
            this.FirstLettersLbl.Size = new System.Drawing.Size(170, 13);
            this.FirstLettersLbl.TabIndex = 4;
            this.FirstLettersLbl.Text = "İlk Gezgini İçin Harf Katarı: (L,R,M)";
            // 
            // FirstLocLbl
            // 
            this.FirstLocLbl.AllowDrop = true;
            this.FirstLocLbl.AutoSize = true;
            this.FirstLocLbl.Location = new System.Drawing.Point(27, 98);
            this.FirstLocLbl.Name = "FirstLocLbl";
            this.FirstLocLbl.Size = new System.Drawing.Size(149, 13);
            this.FirstLocLbl.TabIndex = 5;
            this.FirstLocLbl.Text = "İlk Gezginin Konumu: (x,y,yön)";
            // 
            // SecondLettersTxt
            // 
            this.SecondLettersTxt.Location = new System.Drawing.Point(218, 191);
            this.SecondLettersTxt.Name = "SecondLettersTxt";
            this.SecondLettersTxt.Size = new System.Drawing.Size(175, 20);
            this.SecondLettersTxt.TabIndex = 6;
            this.SecondLettersTxt.TextChanged += new System.EventHandler(this.SecondLettersTxt_TextChanged);
            // 
            // SecondLocXTxt
            // 
            this.SecondLocXTxt.Location = new System.Drawing.Point(218, 160);
            this.SecondLocXTxt.Name = "SecondLocXTxt";
            this.SecondLocXTxt.Size = new System.Drawing.Size(32, 20);
            this.SecondLocXTxt.TabIndex = 7;
            this.SecondLocXTxt.TextChanged += new System.EventHandler(this.SecondLocXTxt_TextChanged);
            // 
            // FirstLettersTxt
            // 
            this.FirstLettersTxt.Location = new System.Drawing.Point(218, 128);
            this.FirstLettersTxt.Name = "FirstLettersTxt";
            this.FirstLettersTxt.Size = new System.Drawing.Size(175, 20);
            this.FirstLettersTxt.TabIndex = 8;
            this.FirstLettersTxt.TextChanged += new System.EventHandler(this.FirstLettersTxt_TextChanged);
            // 
            // FirstLocXTxt
            // 
            this.FirstLocXTxt.Location = new System.Drawing.Point(218, 95);
            this.FirstLocXTxt.Name = "FirstLocXTxt";
            this.FirstLocXTxt.Size = new System.Drawing.Size(32, 20);
            this.FirstLocXTxt.TabIndex = 9;
            this.FirstLocXTxt.TextChanged += new System.EventHandler(this.FirstLocXTxt_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(156, 244);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(87, 25);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Başlat";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RightCornerYTxt
            // 
            this.RightCornerYTxt.Location = new System.Drawing.Point(256, 60);
            this.RightCornerYTxt.Name = "RightCornerYTxt";
            this.RightCornerYTxt.Size = new System.Drawing.Size(32, 20);
            this.RightCornerYTxt.TabIndex = 11;
            this.RightCornerYTxt.TextChanged += new System.EventHandler(this.RightCornerYTxt_TextChanged);
            // 
            // FirstLocYTxt
            // 
            this.FirstLocYTxt.Location = new System.Drawing.Point(256, 96);
            this.FirstLocYTxt.Name = "FirstLocYTxt";
            this.FirstLocYTxt.Size = new System.Drawing.Size(32, 20);
            this.FirstLocYTxt.TabIndex = 12;
            this.FirstLocYTxt.TextChanged += new System.EventHandler(this.FirstLocYTxt_TextChanged);
            // 
            // SecondLocYTxt
            // 
            this.SecondLocYTxt.Location = new System.Drawing.Point(256, 160);
            this.SecondLocYTxt.Name = "SecondLocYTxt";
            this.SecondLocYTxt.Size = new System.Drawing.Size(32, 20);
            this.SecondLocYTxt.TabIndex = 14;
            this.SecondLocYTxt.TextChanged += new System.EventHandler(this.SecondLocYTxt_TextChanged);
            // 
            // FirstLocCmb
            // 
            this.FirstLocCmb.AllowDrop = true;
            this.FirstLocCmb.FormattingEnabled = true;
            this.FirstLocCmb.Location = new System.Drawing.Point(294, 95);
            this.FirstLocCmb.Name = "FirstLocCmb";
            this.FirstLocCmb.Size = new System.Drawing.Size(44, 21);
            this.FirstLocCmb.TabIndex = 16;
            // 
            // SecondLocCmb
            // 
            this.SecondLocCmb.FormattingEnabled = true;
            this.SecondLocCmb.Location = new System.Drawing.Point(294, 159);
            this.SecondLocCmb.Name = "SecondLocCmb";
            this.SecondLocCmb.Size = new System.Drawing.Size(44, 21);
            this.SecondLocCmb.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 320);
            this.Controls.Add(this.SecondLocCmb);
            this.Controls.Add(this.FirstLocCmb);
            this.Controls.Add(this.SecondLocYTxt);
            this.Controls.Add(this.FirstLocYTxt);
            this.Controls.Add(this.RightCornerYTxt);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.FirstLocXTxt);
            this.Controls.Add(this.FirstLettersTxt);
            this.Controls.Add(this.SecondLocXTxt);
            this.Controls.Add(this.SecondLettersTxt);
            this.Controls.Add(this.FirstLocLbl);
            this.Controls.Add(this.FirstLettersLbl);
            this.Controls.Add(this.SecondLocLbl);
            this.Controls.Add(this.SecondLettersLbl);
            this.Controls.Add(this.RightCornerLbl);
            this.Controls.Add(this.RightCornerXTxt);
            this.Name = "Form1";
            this.Text = "Robotik Gezgin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RightCornerXTxt;
        private System.Windows.Forms.Label RightCornerLbl;
        private System.Windows.Forms.Label SecondLettersLbl;
        private System.Windows.Forms.Label SecondLocLbl;
        private System.Windows.Forms.Label FirstLettersLbl;
        private System.Windows.Forms.Label FirstLocLbl;
        private System.Windows.Forms.TextBox SecondLettersTxt;
        private System.Windows.Forms.TextBox SecondLocXTxt;
        private System.Windows.Forms.TextBox FirstLettersTxt;
        private System.Windows.Forms.TextBox FirstLocXTxt;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox RightCornerYTxt;
        private System.Windows.Forms.TextBox FirstLocYTxt;
        private System.Windows.Forms.TextBox SecondLocYTxt;
        private System.Windows.Forms.ComboBox FirstLocCmb;
        private System.Windows.Forms.ComboBox SecondLocCmb;
    }
}

