namespace CoronaApp
{
    partial class BelirtiTespitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.nudYas = new System.Windows.Forms.NumericUpDown();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.ddlSehir = new System.Windows.Forms.ComboBox();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBogazAgrisi = new System.Windows.Forms.CheckBox();
            this.cbOksuruk = new System.Windows.Forms.CheckBox();
            this.cbAtes = new System.Windows.Forms.CheckBox();
            this.bTespit = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şehir";
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(111, 39);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(158, 20);
            this.tbAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yaş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tarih";
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(111, 73);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(158, 20);
            this.tbSoyad.TabIndex = 2;
            // 
            // nudYas
            // 
            this.nudYas.Location = new System.Drawing.Point(111, 151);
            this.nudYas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYas.Name = "nudYas";
            this.nudYas.Size = new System.Drawing.Size(120, 20);
            this.nudYas.TabIndex = 4;
            this.nudYas.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(111, 228);
            this.dtpTarih.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 18;
            // 
            // ddlSehir
            // 
            this.ddlSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSehir.FormattingEnabled = true;
            this.ddlSehir.Location = new System.Drawing.Point(111, 106);
            this.ddlSehir.Name = "ddlSehir";
            this.ddlSehir.Size = new System.Drawing.Size(121, 21);
            this.ddlSehir.TabIndex = 19;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Checked = true;
            this.rbKadin.Location = new System.Drawing.Point(111, 191);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 20;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(169, 191);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 21;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.tbSoyad);
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbKadin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ddlSehir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.tbAd);
            this.groupBox1.Controls.Add(this.nudYas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 276);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbBogazAgrisi);
            this.groupBox2.Controls.Add(this.cbOksuruk);
            this.groupBox2.Controls.Add(this.cbAtes);
            this.groupBox2.Location = new System.Drawing.Point(12, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 122);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Belirtiler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cbBogazAgrisi
            // 
            this.cbBogazAgrisi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbBogazAgrisi.Location = new System.Drawing.Point(7, 66);
            this.cbBogazAgrisi.Name = "cbBogazAgrisi";
            this.cbBogazAgrisi.Size = new System.Drawing.Size(84, 18);
            this.cbBogazAgrisi.TabIndex = 2;
            this.cbBogazAgrisi.Text = "Boğaz Ağrısı";
            this.cbBogazAgrisi.UseVisualStyleBackColor = true;
            this.cbBogazAgrisi.CheckedChanged += new System.EventHandler(this.cbBogazAgrisi_CheckedChanged);
            // 
            // cbOksuruk
            // 
            this.cbOksuruk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbOksuruk.Location = new System.Drawing.Point(7, 43);
            this.cbOksuruk.Name = "cbOksuruk";
            this.cbOksuruk.Size = new System.Drawing.Size(84, 17);
            this.cbOksuruk.TabIndex = 1;
            this.cbOksuruk.Text = "Öksürük";
            this.cbOksuruk.UseVisualStyleBackColor = true;
            this.cbOksuruk.CheckedChanged += new System.EventHandler(this.cbOksuruk_CheckedChanged);
            // 
            // cbAtes
            // 
            this.cbAtes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAtes.Location = new System.Drawing.Point(7, 20);
            this.cbAtes.Name = "cbAtes";
            this.cbAtes.Size = new System.Drawing.Size(84, 17);
            this.cbAtes.TabIndex = 0;
            this.cbAtes.Text = "Ateş";
            this.cbAtes.UseVisualStyleBackColor = true;
            this.cbAtes.CheckedChanged += new System.EventHandler(this.cbAtes_CheckedChanged);
            // 
            // bTespit
            // 
            this.bTespit.BackColor = System.Drawing.Color.IndianRed;
            this.bTespit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTespit.Location = new System.Drawing.Point(12, 423);
            this.bTespit.Name = "bTespit";
            this.bTespit.Size = new System.Drawing.Size(162, 43);
            this.bTespit.TabIndex = 24;
            this.bTespit.Text = "Tespit";
            this.bTespit.UseVisualStyleBackColor = false;
            this.bTespit.Click += new System.EventHandler(this.bTespit_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.BackColor = System.Drawing.Color.IndianRed;
            this.bTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTemizle.Location = new System.Drawing.Point(207, 423);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(162, 43);
            this.bTemizle.TabIndex = 25;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = false;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(13, 473);
            this.tbSonuc.Multiline = true;
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.ReadOnly = true;
            this.tbSonuc.Size = new System.Drawing.Size(356, 74);
            this.tbSonuc.TabIndex = 26;
            // 
            // BelirtiTespitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bTespit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BelirtiTespitForm";
            this.Text = "BelirtiTespitForm";
            this.Load += new System.EventHandler(this.BelirtiTespitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.NumericUpDown nudYas;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox ddlSehir;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbBogazAgrisi;
        private System.Windows.Forms.CheckBox cbOksuruk;
        private System.Windows.Forms.CheckBox cbAtes;
        private System.Windows.Forms.Button bTespit;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.TextBox tbSonuc;
    }
}