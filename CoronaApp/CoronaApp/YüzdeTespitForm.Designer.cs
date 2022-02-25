namespace CoronaApp
{
    partial class YüzdeTespitForm
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
            this.tbAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBogazAgrisi = new System.Windows.Forms.CheckBox();
            this.cbOksuruk = new System.Windows.Forms.CheckBox();
            this.cbAtes = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.gbRapor = new System.Windows.Forms.GroupBox();
            this.rtbRapor = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gbRapor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAdSoyad
            // 
            this.tbAdSoyad.Location = new System.Drawing.Point(83, 2);
            this.tbAdSoyad.Name = "tbAdSoyad";
            this.tbAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.tbAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // cbBogazAgrisi
            // 
            this.cbBogazAgrisi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbBogazAgrisi.Location = new System.Drawing.Point(12, 74);
            this.cbBogazAgrisi.Name = "cbBogazAgrisi";
            this.cbBogazAgrisi.Size = new System.Drawing.Size(84, 18);
            this.cbBogazAgrisi.TabIndex = 5;
            this.cbBogazAgrisi.Text = "Boğaz Ağrısı";
            this.cbBogazAgrisi.UseVisualStyleBackColor = true;
            // 
            // cbOksuruk
            // 
            this.cbOksuruk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOksuruk.Location = new System.Drawing.Point(12, 51);
            this.cbOksuruk.Name = "cbOksuruk";
            this.cbOksuruk.Size = new System.Drawing.Size(84, 17);
            this.cbOksuruk.TabIndex = 4;
            this.cbOksuruk.Text = "Öksürük";
            this.cbOksuruk.UseVisualStyleBackColor = true;
            // 
            // cbAtes
            // 
            this.cbAtes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAtes.Location = new System.Drawing.Point(12, 28);
            this.cbAtes.Name = "cbAtes";
            this.cbAtes.Size = new System.Drawing.Size(84, 17);
            this.cbAtes.TabIndex = 3;
            this.cbAtes.Text = "Ateş";
            this.cbAtes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tespit Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.Location = new System.Drawing.Point(15, 129);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(230, 186);
            this.lbSonuc.TabIndex = 8;
            // 
            // gbRapor
            // 
            this.gbRapor.Controls.Add(this.rtbRapor);
            this.gbRapor.Location = new System.Drawing.Point(273, 9);
            this.gbRapor.Name = "gbRapor";
            this.gbRapor.Size = new System.Drawing.Size(427, 306);
            this.gbRapor.TabIndex = 9;
            this.gbRapor.TabStop = false;
            this.gbRapor.Text = "Rapor";
            this.gbRapor.Visible = false;
            // 
            // rtbRapor
            // 
            this.rtbRapor.Location = new System.Drawing.Point(12, 19);
            this.rtbRapor.Name = "rtbRapor";
            this.rtbRapor.Size = new System.Drawing.Size(415, 281);
            this.rtbRapor.TabIndex = 0;
            this.rtbRapor.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Rapor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // YüzdeTespitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gbRapor);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbBogazAgrisi);
            this.Controls.Add(this.cbOksuruk);
            this.Controls.Add(this.cbAtes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdSoyad);
            this.Name = "YüzdeTespitForm";
            this.Text = "Yüzde Tespit";
            this.gbRapor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbBogazAgrisi;
        private System.Windows.Forms.CheckBox cbOksuruk;
        private System.Windows.Forms.CheckBox cbAtes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.GroupBox gbRapor;
        private System.Windows.Forms.RichTextBox rtbRapor;
        private System.Windows.Forms.Button button3;
    }
}