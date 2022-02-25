namespace BilgisayarApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.bOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHafiza = new System.Windows.Forms.NumericUpDown();
            this.tbHiz = new System.Windows.Forms.TextBox();
            this.tbHafiza = new System.Windows.Forms.Label();
            this.tbEkran = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSuSogutma = new System.Windows.Forms.CheckBox();
            this.dtpUretimTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlBilgisayarTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHafiza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 111;
            this.label1.Text = "Marka";
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(184, 18);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(537, 30);
            this.tbMarka.TabIndex = 0;
            // 
            // bOlustur
            // 
            this.bOlustur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bOlustur.Location = new System.Drawing.Point(184, 349);
            this.bOlustur.Name = "bOlustur";
            this.bOlustur.Size = new System.Drawing.Size(147, 39);
            this.bOlustur.TabIndex = 8;
            this.bOlustur.Text = "Oluştur";
            this.bOlustur.UseVisualStyleBackColor = true;
            this.bOlustur.Click += new System.EventHandler(this.bOlustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 31);
            this.label2.TabIndex = 112;
            this.label2.Text = "Model";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(184, 62);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(537, 30);
            this.tbModel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 31);
            this.label3.TabIndex = 113;
            this.label3.Text = "Hız";
            // 
            // nudHafiza
            // 
            this.nudHafiza.Location = new System.Drawing.Point(184, 147);
            this.nudHafiza.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudHafiza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHafiza.Name = "nudHafiza";
            this.nudHafiza.Size = new System.Drawing.Size(131, 30);
            this.nudHafiza.TabIndex = 3;
            this.nudHafiza.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // tbHiz
            // 
            this.tbHiz.Location = new System.Drawing.Point(184, 102);
            this.tbHiz.Name = "tbHiz";
            this.tbHiz.Size = new System.Drawing.Size(537, 30);
            this.tbHiz.TabIndex = 2;
            // 
            // tbHafiza
            // 
            this.tbHafiza.AutoSize = true;
            this.tbHafiza.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbHafiza.Location = new System.Drawing.Point(20, 144);
            this.tbHafiza.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.tbHafiza.Name = "tbHafiza";
            this.tbHafiza.Size = new System.Drawing.Size(84, 31);
            this.tbHafiza.TabIndex = 114;
            this.tbHafiza.Text = "Hafiza";
            // 
            // tbEkran
            // 
            this.tbEkran.Location = new System.Drawing.Point(184, 188);
            this.tbEkran.Name = "tbEkran";
            this.tbEkran.Size = new System.Drawing.Size(537, 30);
            this.tbEkran.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 31);
            this.label5.TabIndex = 114;
            this.label5.Text = "Ekran";
            // 
            // cbSuSogutma
            // 
            this.cbSuSogutma.AutoSize = true;
            this.cbSuSogutma.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSuSogutma.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSuSogutma.Location = new System.Drawing.Point(16, 226);
            this.cbSuSogutma.Name = "cbSuSogutma";
            this.cbSuSogutma.Size = new System.Drawing.Size(180, 34);
            this.cbSuSogutma.TabIndex = 115;
            this.cbSuSogutma.Text = "Su Soğutma   ";
            this.cbSuSogutma.UseVisualStyleBackColor = true;
            // 
            // dtpUretimTarih
            // 
            this.dtpUretimTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUretimTarih.Location = new System.Drawing.Point(184, 262);
            this.dtpUretimTarih.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpUretimTarih.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpUretimTarih.Name = "dtpUretimTarih";
            this.dtpUretimTarih.Size = new System.Drawing.Size(228, 30);
            this.dtpUretimTarih.TabIndex = 6;
            this.dtpUretimTarih.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 31);
            this.label4.TabIndex = 116;
            this.label4.Text = "Üretim Tarihi";
            // 
            // ddlBilgisayarTipi
            // 
            this.ddlBilgisayarTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlBilgisayarTipi.FormattingEnabled = true;
            this.ddlBilgisayarTipi.Items.AddRange(new object[] {
            "Sunucu",
            "Dizüstü",
            "Masaüstü"});
            this.ddlBilgisayarTipi.Location = new System.Drawing.Point(184, 309);
            this.ddlBilgisayarTipi.Name = "ddlBilgisayarTipi";
            this.ddlBilgisayarTipi.Size = new System.Drawing.Size(131, 31);
            this.ddlBilgisayarTipi.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 307);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 31);
            this.label6.TabIndex = 117;
            this.label6.Text = "Tipi";
            // 
            // bGoster
            // 
            this.bGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bGoster.Location = new System.Drawing.Point(408, 349);
            this.bGoster.Name = "bGoster";
            this.bGoster.Size = new System.Drawing.Size(147, 39);
            this.bGoster.TabIndex = 118;
            this.bGoster.Text = "Göster";
            this.bGoster.UseVisualStyleBackColor = true;
            this.bGoster.Click += new System.EventHandler(this.bGoster_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bOlustur;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 400);
            this.Controls.Add(this.bGoster);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlBilgisayarTipi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpUretimTarih);
            this.Controls.Add(this.cbSuSogutma);
            this.Controls.Add(this.tbHafiza);
            this.Controls.Add(this.nudHafiza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEkran);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHiz);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bOlustur);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "BilgisayarApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHafiza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.Button bOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHafiza;
        private System.Windows.Forms.TextBox tbHiz;
        private System.Windows.Forms.Label tbHafiza;
        private System.Windows.Forms.TextBox tbEkran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbSuSogutma;
        private System.Windows.Forms.DateTimePicker dtpUretimTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlBilgisayarTipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bGoster;
    }
}

