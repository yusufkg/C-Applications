namespace SesliSessizHarfBulmaApp
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
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.rbSesli = new System.Windows.Forms.RadioButton();
            this.rbSessiz = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lSonuc = new System.Windows.Forms.Label();
            this.lKelime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime";
            // 
            // tbKelime
            // 
            this.tbKelime.Location = new System.Drawing.Point(74, 10);
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(228, 20);
            this.tbKelime.TabIndex = 1;
            this.tbKelime.TextChanged += new System.EventHandler(this.tbKelime_TextChanged);
            // 
            // rbSesli
            // 
            this.rbSesli.AutoSize = true;
            this.rbSesli.Checked = true;
            this.rbSesli.Location = new System.Drawing.Point(16, 57);
            this.rbSesli.Name = "rbSesli";
            this.rbSesli.Size = new System.Drawing.Size(47, 17);
            this.rbSesli.TabIndex = 2;
            this.rbSesli.TabStop = true;
            this.rbSesli.Text = "Sesli";
            this.rbSesli.UseVisualStyleBackColor = true;
            // 
            // rbSessiz
            // 
            this.rbSessiz.AutoSize = true;
            this.rbSessiz.Location = new System.Drawing.Point(74, 57);
            this.rbSessiz.Name = "rbSessiz";
            this.rbSessiz.Size = new System.Drawing.Size(55, 17);
            this.rbSessiz.TabIndex = 3;
            this.rbSessiz.TabStop = true;
            this.rbSessiz.Text = "Sessiz";
            this.rbSessiz.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(16, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lSonuc
            // 
            this.lSonuc.AutoSize = true;
            this.lSonuc.Location = new System.Drawing.Point(13, 137);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(40, 13);
            this.lSonuc.TabIndex = 5;
            this.lSonuc.Text = "lSonuc";
            // 
            // lKelime
            // 
            this.lKelime.AutoSize = true;
            this.lKelime.Location = new System.Drawing.Point(319, 13);
            this.lKelime.Name = "lKelime";
            this.lKelime.Size = new System.Drawing.Size(40, 13);
            this.lKelime.TabIndex = 6;
            this.lKelime.Text = "lKelime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lKelime);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbSessiz);
            this.Controls.Add(this.rbSesli);
            this.Controls.Add(this.tbKelime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SesliSessizApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKelime;
        private System.Windows.Forms.RadioButton rbSesli;
        private System.Windows.Forms.RadioButton rbSessiz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.Label lKelime;
    }
}

