
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lbMarka = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbKapiSayisi = new System.Windows.Forms.Label();
            this.lbBeygirGucu = new System.Windows.Forms.Label();
            this.lbArabaTuru = new System.Windows.Forms.Label();
            this.lbMaksimumHiz = new System.Windows.Forms.Label();
            this.lbCekis = new System.Windows.Forms.Label();
            this.lb100 = new System.Windows.Forms.Label();
            this.lbAgirlik = new System.Windows.Forms.Label();
            this.lbMotorHacmi = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.ddlKapiSayisi = new System.Windows.Forms.ComboBox();
            this.nudHp = new System.Windows.Forms.NumericUpDown();
            this.bKaydet = new System.Windows.Forms.Button();
            this.bGoster = new System.Windows.Forms.Button();
            this.ddlArabaTuru = new System.Windows.Forms.ComboBox();
            this.ddlCekis = new System.Windows.Forms.ComboBox();
            this.tbMaksimumHiz = new System.Windows.Forms.TextBox();
            this.tbHizlanma = new System.Windows.Forms.TextBox();
            this.tbAgirlik = new System.Windows.Forms.TextBox();
            this.tbMotorHacmi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMarka
            // 
            this.lbMarka.AutoSize = true;
            this.lbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarka.Location = new System.Drawing.Point(12, 9);
            this.lbMarka.Name = "lbMarka";
            this.lbMarka.Size = new System.Drawing.Size(72, 25);
            this.lbMarka.TabIndex = 100;
            this.lbMarka.Text = "Marka";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.Location = new System.Drawing.Point(12, 34);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(71, 25);
            this.lbModel.TabIndex = 101;
            this.lbModel.Text = "Model";
            // 
            // lbKapiSayisi
            // 
            this.lbKapiSayisi.AutoSize = true;
            this.lbKapiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKapiSayisi.Location = new System.Drawing.Point(12, 59);
            this.lbKapiSayisi.Name = "lbKapiSayisi";
            this.lbKapiSayisi.Size = new System.Drawing.Size(119, 25);
            this.lbKapiSayisi.TabIndex = 102;
            this.lbKapiSayisi.Text = "Kapı Sayısı";
            // 
            // lbBeygirGucu
            // 
            this.lbBeygirGucu.AutoSize = true;
            this.lbBeygirGucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeygirGucu.Location = new System.Drawing.Point(12, 84);
            this.lbBeygirGucu.Name = "lbBeygirGucu";
            this.lbBeygirGucu.Size = new System.Drawing.Size(130, 25);
            this.lbBeygirGucu.TabIndex = 103;
            this.lbBeygirGucu.Text = "Beygir Gücü";
            // 
            // lbArabaTuru
            // 
            this.lbArabaTuru.AutoSize = true;
            this.lbArabaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArabaTuru.Location = new System.Drawing.Point(12, 109);
            this.lbArabaTuru.Name = "lbArabaTuru";
            this.lbArabaTuru.Size = new System.Drawing.Size(119, 25);
            this.lbArabaTuru.TabIndex = 104;
            this.lbArabaTuru.Text = "Araba Türü";
            // 
            // lbMaksimumHiz
            // 
            this.lbMaksimumHiz.AutoSize = true;
            this.lbMaksimumHiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaksimumHiz.Location = new System.Drawing.Point(12, 134);
            this.lbMaksimumHiz.Name = "lbMaksimumHiz";
            this.lbMaksimumHiz.Size = new System.Drawing.Size(152, 25);
            this.lbMaksimumHiz.TabIndex = 105;
            this.lbMaksimumHiz.Text = "Maksimum Hız";
            // 
            // lbCekis
            // 
            this.lbCekis.AutoSize = true;
            this.lbCekis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCekis.Location = new System.Drawing.Point(12, 159);
            this.lbCekis.Name = "lbCekis";
            this.lbCekis.Size = new System.Drawing.Size(66, 25);
            this.lbCekis.TabIndex = 106;
            this.lbCekis.Text = "Çekiş";
            // 
            // lb100
            // 
            this.lb100.AutoSize = true;
            this.lb100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb100.Location = new System.Drawing.Point(12, 184);
            this.lb100.Name = "lb100";
            this.lb100.Size = new System.Drawing.Size(171, 25);
            this.lb100.TabIndex = 107;
            this.lb100.Text = "0\'dan 100\'e (sn.)";
            // 
            // lbAgirlik
            // 
            this.lbAgirlik.AutoSize = true;
            this.lbAgirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgirlik.Location = new System.Drawing.Point(12, 209);
            this.lbAgirlik.Name = "lbAgirlik";
            this.lbAgirlik.Size = new System.Drawing.Size(71, 25);
            this.lbAgirlik.TabIndex = 108;
            this.lbAgirlik.Text = "Ağırlık";
            // 
            // lbMotorHacmi
            // 
            this.lbMotorHacmi.AutoSize = true;
            this.lbMotorHacmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotorHacmi.Location = new System.Drawing.Point(12, 234);
            this.lbMotorHacmi.Name = "lbMotorHacmi";
            this.lbMotorHacmi.Size = new System.Drawing.Size(193, 25);
            this.lbMotorHacmi.TabIndex = 109;
            this.lbMotorHacmi.Text = "Motor Hacmi (cm3)";
            // 
            // tbMarka
            // 
            this.tbMarka.BackColor = System.Drawing.Color.White;
            this.tbMarka.Location = new System.Drawing.Point(232, 14);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(471, 20);
            this.tbMarka.TabIndex = 0;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(232, 39);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(471, 20);
            this.tbModel.TabIndex = 1;
            // 
            // ddlKapiSayisi
            // 
            this.ddlKapiSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKapiSayisi.FormattingEnabled = true;
            this.ddlKapiSayisi.Items.AddRange(new object[] {
            "İki Kapılı",
            "Üç Kapılı",
            "Beş Kapılı"});
            this.ddlKapiSayisi.Location = new System.Drawing.Point(232, 63);
            this.ddlKapiSayisi.Name = "ddlKapiSayisi";
            this.ddlKapiSayisi.Size = new System.Drawing.Size(121, 21);
            this.ddlKapiSayisi.TabIndex = 2;
            // 
            // nudHp
            // 
            this.nudHp.Location = new System.Drawing.Point(232, 89);
            this.nudHp.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudHp.Name = "nudHp";
            this.nudHp.Size = new System.Drawing.Size(120, 20);
            this.nudHp.TabIndex = 3;
            // 
            // bKaydet
            // 
            this.bKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bKaydet.Location = new System.Drawing.Point(336, 339);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(223, 68);
            this.bKaydet.TabIndex = 26;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = false;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // bGoster
            // 
            this.bGoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bGoster.Location = new System.Drawing.Point(565, 339);
            this.bGoster.Name = "bGoster";
            this.bGoster.Size = new System.Drawing.Size(223, 68);
            this.bGoster.TabIndex = 27;
            this.bGoster.Text = "Göster";
            this.bGoster.UseVisualStyleBackColor = false;
            this.bGoster.Click += new System.EventHandler(this.bGoster_Click);
            // 
            // ddlArabaTuru
            // 
            this.ddlArabaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlArabaTuru.FormattingEnabled = true;
            this.ddlArabaTuru.Items.AddRange(new object[] {
            "Motosiklet",
            "Otomobil",
            "Minibüs",
            "Otobüs",
            "Kamyon",
            "Tır"});
            this.ddlArabaTuru.Location = new System.Drawing.Point(232, 113);
            this.ddlArabaTuru.Name = "ddlArabaTuru";
            this.ddlArabaTuru.Size = new System.Drawing.Size(121, 21);
            this.ddlArabaTuru.TabIndex = 4;
            // 
            // ddlCekis
            // 
            this.ddlCekis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCekis.FormattingEnabled = true;
            this.ddlCekis.Items.AddRange(new object[] {
            "Önden Çekişli",
            "Arkadan Çekişli",
            "Dört Çeker"});
            this.ddlCekis.Location = new System.Drawing.Point(232, 163);
            this.ddlCekis.Name = "ddlCekis";
            this.ddlCekis.Size = new System.Drawing.Size(121, 21);
            this.ddlCekis.TabIndex = 6;
            // 
            // tbMaksimumHiz
            // 
            this.tbMaksimumHiz.Location = new System.Drawing.Point(232, 139);
            this.tbMaksimumHiz.Name = "tbMaksimumHiz";
            this.tbMaksimumHiz.Size = new System.Drawing.Size(471, 20);
            this.tbMaksimumHiz.TabIndex = 5;
            // 
            // tbHizlanma
            // 
            this.tbHizlanma.Location = new System.Drawing.Point(232, 189);
            this.tbHizlanma.Name = "tbHizlanma";
            this.tbHizlanma.Size = new System.Drawing.Size(471, 20);
            this.tbHizlanma.TabIndex = 7;
            // 
            // tbAgirlik
            // 
            this.tbAgirlik.Location = new System.Drawing.Point(232, 214);
            this.tbAgirlik.Name = "tbAgirlik";
            this.tbAgirlik.Size = new System.Drawing.Size(471, 20);
            this.tbAgirlik.TabIndex = 8;
            // 
            // tbMotorHacmi
            // 
            this.tbMotorHacmi.Location = new System.Drawing.Point(232, 239);
            this.tbMotorHacmi.Name = "tbMotorHacmi";
            this.tbMotorHacmi.Size = new System.Drawing.Size(471, 20);
            this.tbMotorHacmi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "Not: Ondalıklı verileri girmek için Virgül(,) kullanınız.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMotorHacmi);
            this.Controls.Add(this.tbAgirlik);
            this.Controls.Add(this.tbHizlanma);
            this.Controls.Add(this.tbMaksimumHiz);
            this.Controls.Add(this.ddlCekis);
            this.Controls.Add(this.ddlArabaTuru);
            this.Controls.Add(this.bGoster);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.nudHp);
            this.Controls.Add(this.ddlKapiSayisi);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.lbMotorHacmi);
            this.Controls.Add(this.lbAgirlik);
            this.Controls.Add(this.lb100);
            this.Controls.Add(this.lbCekis);
            this.Controls.Add(this.lbMaksimumHiz);
            this.Controls.Add(this.lbArabaTuru);
            this.Controls.Add(this.lbBeygirGucu);
            this.Controls.Add(this.lbKapiSayisi);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.lbMarka);
            this.Name = "Form1";
            this.Text = "Araba Sınıfı Özellikleri";
            ((System.ComponentModel.ISupportInitialize)(this.nudHp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMarka;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbKapiSayisi;
        private System.Windows.Forms.Label lbBeygirGucu;
        private System.Windows.Forms.Label lbArabaTuru;
        private System.Windows.Forms.Label lbMaksimumHiz;
        private System.Windows.Forms.Label lbCekis;
        private System.Windows.Forms.Label lb100;
        private System.Windows.Forms.Label lbAgirlik;
        private System.Windows.Forms.Label lbMotorHacmi;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.ComboBox ddlKapiSayisi;
        private System.Windows.Forms.NumericUpDown nudHp;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.Button bGoster;
        private System.Windows.Forms.ComboBox ddlArabaTuru;
        private System.Windows.Forms.ComboBox ddlCekis;
        private System.Windows.Forms.TextBox tbMaksimumHiz;
        private System.Windows.Forms.TextBox tbHizlanma;
        private System.Windows.Forms.TextBox tbAgirlik;
        private System.Windows.Forms.TextBox tbMotorHacmi;
        private System.Windows.Forms.Label label1;
    }
}

