
namespace ZarAtmaOyunu
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
            this.buttonOyuncuBir = new System.Windows.Forms.Button();
            this.buttonOyuncu2 = new System.Windows.Forms.Button();
            this.textBoxOyuncubir = new System.Windows.Forms.TextBox();
            this.Oyuncu1Ad = new System.Windows.Forms.Label();
            this.buttonAd1 = new System.Windows.Forms.Button();
            this.Oyuncu2Ad = new System.Windows.Forms.Label();
            this.textBoxOyuncuIki = new System.Windows.Forms.TextBox();
            this.Oyuncu2Add = new System.Windows.Forms.Button();
            this.kazanan = new System.Windows.Forms.Label();
            this.KazananAd = new System.Windows.Forms.Label();
            this.label1Zar = new System.Windows.Forms.Label();
            this.label2Zar = new System.Windows.Forms.Label();
            this.buttonBahis1 = new System.Windows.Forms.Button();
            this.buttonBahis2 = new System.Windows.Forms.Button();
            this.labelKaybeden = new System.Windows.Forms.Label();
            this.labelBakiye1 = new System.Windows.Forms.Label();
            this.labelBakiye2 = new System.Windows.Forms.Label();
            this.labelBahis1 = new System.Windows.Forms.Label();
            this.labelBahis2 = new System.Windows.Forms.Label();
            this.textBoxBahis1 = new System.Windows.Forms.TextBox();
            this.textBoxBahis2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOyuncuBir
            // 
            this.buttonOyuncuBir.Location = new System.Drawing.Point(30, 197);
            this.buttonOyuncuBir.Name = "buttonOyuncuBir";
            this.buttonOyuncuBir.Size = new System.Drawing.Size(79, 35);
            this.buttonOyuncuBir.TabIndex = 0;
            this.buttonOyuncuBir.Text = "Player 1 Play";
            this.buttonOyuncuBir.UseVisualStyleBackColor = true;
            this.buttonOyuncuBir.Click += new System.EventHandler(this.buttonOyuncuBir_Click);
            // 
            // buttonOyuncu2
            // 
            this.buttonOyuncu2.Enabled = false;
            this.buttonOyuncu2.Location = new System.Drawing.Point(398, 197);
            this.buttonOyuncu2.Name = "buttonOyuncu2";
            this.buttonOyuncu2.Size = new System.Drawing.Size(78, 35);
            this.buttonOyuncu2.TabIndex = 1;
            this.buttonOyuncu2.Text = "Player 2 Play";
            this.buttonOyuncu2.UseVisualStyleBackColor = true;
            this.buttonOyuncu2.Click += new System.EventHandler(this.buttonOyuncu2_Click);
            // 
            // textBoxOyuncubir
            // 
            this.textBoxOyuncubir.Location = new System.Drawing.Point(117, 86);
            this.textBoxOyuncubir.Name = "textBoxOyuncubir";
            this.textBoxOyuncubir.Size = new System.Drawing.Size(100, 20);
            this.textBoxOyuncubir.TabIndex = 2;
            // 
            // Oyuncu1Ad
            // 
            this.Oyuncu1Ad.AutoSize = true;
            this.Oyuncu1Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Oyuncu1Ad.Location = new System.Drawing.Point(30, 178);
            this.Oyuncu1Ad.Name = "Oyuncu1Ad";
            this.Oyuncu1Ad.Size = new System.Drawing.Size(0, 13);
            this.Oyuncu1Ad.TabIndex = 3;
            // 
            // buttonAd1
            // 
            this.buttonAd1.Location = new System.Drawing.Point(223, 86);
            this.buttonAd1.Name = "buttonAd1";
            this.buttonAd1.Size = new System.Drawing.Size(75, 23);
            this.buttonAd1.TabIndex = 4;
            this.buttonAd1.Text = "Add Player 1 ";
            this.buttonAd1.UseVisualStyleBackColor = true;
            this.buttonAd1.Click += new System.EventHandler(this.buttonAd1_Click);
            // 
            // Oyuncu2Ad
            // 
            this.Oyuncu2Ad.AutoSize = true;
            this.Oyuncu2Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Oyuncu2Ad.Location = new System.Drawing.Point(395, 178);
            this.Oyuncu2Ad.Name = "Oyuncu2Ad";
            this.Oyuncu2Ad.Size = new System.Drawing.Size(0, 13);
            this.Oyuncu2Ad.TabIndex = 5;
            // 
            // textBoxOyuncuIki
            // 
            this.textBoxOyuncuIki.Location = new System.Drawing.Point(117, 112);
            this.textBoxOyuncuIki.Name = "textBoxOyuncuIki";
            this.textBoxOyuncuIki.Size = new System.Drawing.Size(100, 20);
            this.textBoxOyuncuIki.TabIndex = 6;
            // 
            // Oyuncu2Add
            // 
            this.Oyuncu2Add.Location = new System.Drawing.Point(223, 112);
            this.Oyuncu2Add.Name = "Oyuncu2Add";
            this.Oyuncu2Add.Size = new System.Drawing.Size(75, 23);
            this.Oyuncu2Add.TabIndex = 7;
            this.Oyuncu2Add.Text = "Add Player 2";
            this.Oyuncu2Add.UseVisualStyleBackColor = true;
            this.Oyuncu2Add.Click += new System.EventHandler(this.Oyuncu2Add_Click);
            // 
            // kazanan
            // 
            this.kazanan.AutoSize = true;
            this.kazanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kazanan.Location = new System.Drawing.Point(189, 263);
            this.kazanan.Name = "kazanan";
            this.kazanan.Size = new System.Drawing.Size(56, 15);
            this.kazanan.TabIndex = 8;
            this.kazanan.Text = "Winner:";
            // 
            // KazananAd
            // 
            this.KazananAd.AutoSize = true;
            this.KazananAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KazananAd.Location = new System.Drawing.Point(113, 283);
            this.KazananAd.Name = "KazananAd";
            this.KazananAd.Size = new System.Drawing.Size(0, 24);
            this.KazananAd.TabIndex = 9;
            // 
            // label1Zar
            // 
            this.label1Zar.AutoSize = true;
            this.label1Zar.Location = new System.Drawing.Point(30, 235);
            this.label1Zar.Name = "label1Zar";
            this.label1Zar.Size = new System.Drawing.Size(0, 13);
            this.label1Zar.TabIndex = 10;
            // 
            // label2Zar
            // 
            this.label2Zar.AutoSize = true;
            this.label2Zar.Location = new System.Drawing.Point(406, 235);
            this.label2Zar.Name = "label2Zar";
            this.label2Zar.Size = new System.Drawing.Size(0, 13);
            this.label2Zar.TabIndex = 11;
            // 
            // buttonBahis1
            // 
            this.buttonBahis1.Enabled = false;
            this.buttonBahis1.Location = new System.Drawing.Point(349, 86);
            this.buttonBahis1.Name = "buttonBahis1";
            this.buttonBahis1.Size = new System.Drawing.Size(75, 23);
            this.buttonBahis1.TabIndex = 12;
            this.buttonBahis1.Text = "Bet";
            this.buttonBahis1.UseVisualStyleBackColor = true;
            this.buttonBahis1.Click += new System.EventHandler(this.buttonBahis1_Click);
            // 
            // buttonBahis2
            // 
            this.buttonBahis2.Enabled = false;
            this.buttonBahis2.Location = new System.Drawing.Point(349, 112);
            this.buttonBahis2.Name = "buttonBahis2";
            this.buttonBahis2.Size = new System.Drawing.Size(75, 23);
            this.buttonBahis2.TabIndex = 13;
            this.buttonBahis2.Text = "Bet";
            this.buttonBahis2.UseVisualStyleBackColor = true;
            this.buttonBahis2.Click += new System.EventHandler(this.buttonBahis2_Click);
            // 
            // labelKaybeden
            // 
            this.labelKaybeden.AutoSize = true;
            this.labelKaybeden.Location = new System.Drawing.Point(230, 355);
            this.labelKaybeden.Name = "labelKaybeden";
            this.labelKaybeden.Size = new System.Drawing.Size(0, 13);
            this.labelKaybeden.TabIndex = 14;
            // 
            // labelBakiye1
            // 
            this.labelBakiye1.AutoSize = true;
            this.labelBakiye1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBakiye1.Location = new System.Drawing.Point(30, 152);
            this.labelBakiye1.Name = "labelBakiye1";
            this.labelBakiye1.Size = new System.Drawing.Size(0, 13);
            this.labelBakiye1.TabIndex = 15;
            // 
            // labelBakiye2
            // 
            this.labelBakiye2.AutoSize = true;
            this.labelBakiye2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBakiye2.Location = new System.Drawing.Point(395, 152);
            this.labelBakiye2.Name = "labelBakiye2";
            this.labelBakiye2.Size = new System.Drawing.Size(0, 13);
            this.labelBakiye2.TabIndex = 16;
            // 
            // labelBahis1
            // 
            this.labelBahis1.AutoSize = true;
            this.labelBahis1.Location = new System.Drawing.Point(430, 86);
            this.labelBahis1.Name = "labelBahis1";
            this.labelBahis1.Size = new System.Drawing.Size(0, 13);
            this.labelBahis1.TabIndex = 17;
            // 
            // labelBahis2
            // 
            this.labelBahis2.AutoSize = true;
            this.labelBahis2.Location = new System.Drawing.Point(430, 122);
            this.labelBahis2.Name = "labelBahis2";
            this.labelBahis2.Size = new System.Drawing.Size(0, 13);
            this.labelBahis2.TabIndex = 18;
            // 
            // textBoxBahis1
            // 
            this.textBoxBahis1.Location = new System.Drawing.Point(301, 86);
            this.textBoxBahis1.Name = "textBoxBahis1";
            this.textBoxBahis1.Size = new System.Drawing.Size(42, 20);
            this.textBoxBahis1.TabIndex = 19;
            // 
            // textBoxBahis2
            // 
            this.textBoxBahis2.Location = new System.Drawing.Point(301, 112);
            this.textBoxBahis2.Name = "textBoxBahis2";
            this.textBoxBahis2.Size = new System.Drawing.Size(42, 20);
            this.textBoxBahis2.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(528, 416);
            this.Controls.Add(this.textBoxBahis2);
            this.Controls.Add(this.textBoxBahis1);
            this.Controls.Add(this.labelBahis2);
            this.Controls.Add(this.labelBahis1);
            this.Controls.Add(this.labelBakiye2);
            this.Controls.Add(this.labelBakiye1);
            this.Controls.Add(this.labelKaybeden);
            this.Controls.Add(this.buttonBahis2);
            this.Controls.Add(this.buttonBahis1);
            this.Controls.Add(this.label2Zar);
            this.Controls.Add(this.label1Zar);
            this.Controls.Add(this.KazananAd);
            this.Controls.Add(this.kazanan);
            this.Controls.Add(this.Oyuncu2Add);
            this.Controls.Add(this.textBoxOyuncuIki);
            this.Controls.Add(this.Oyuncu2Ad);
            this.Controls.Add(this.buttonAd1);
            this.Controls.Add(this.Oyuncu1Ad);
            this.Controls.Add(this.textBoxOyuncubir);
            this.Controls.Add(this.buttonOyuncu2);
            this.Controls.Add(this.buttonOyuncuBir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOyuncuBir;
        private System.Windows.Forms.Button buttonOyuncu2;
        private System.Windows.Forms.TextBox textBoxOyuncubir;
        private System.Windows.Forms.Label Oyuncu1Ad;
        private System.Windows.Forms.Button buttonAd1;
        private System.Windows.Forms.Label Oyuncu2Ad;
        private System.Windows.Forms.TextBox textBoxOyuncuIki;
        private System.Windows.Forms.Button Oyuncu2Add;
        private System.Windows.Forms.Label kazanan;
        private System.Windows.Forms.Label KazananAd;
        private System.Windows.Forms.Label label1Zar;
        private System.Windows.Forms.Label label2Zar;
        private System.Windows.Forms.Button buttonBahis1;
        private System.Windows.Forms.Button buttonBahis2;
        private System.Windows.Forms.Label labelKaybeden;
        private System.Windows.Forms.Label labelBakiye1;
        private System.Windows.Forms.Label labelBakiye2;
        private System.Windows.Forms.Label labelBahis1;
        private System.Windows.Forms.Label labelBahis2;
        private System.Windows.Forms.TextBox textBoxBahis1;
        private System.Windows.Forms.TextBox textBoxBahis2;
    }
}

