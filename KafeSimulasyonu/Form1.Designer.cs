namespace KafeSimulasyonu
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
            this.btnMusteriOlustur = new System.Windows.Forms.Button();
            this.cbMenuler = new System.Windows.Forms.ComboBox();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnBarista3 = new System.Windows.Forms.Button();
            this.btnBarista1 = new System.Windows.Forms.Button();
            this.btnBarista2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMusteriOlustur
            // 
            this.btnMusteriOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriOlustur.Location = new System.Drawing.Point(1020, 433);
            this.btnMusteriOlustur.Name = "btnMusteriOlustur";
            this.btnMusteriOlustur.Size = new System.Drawing.Size(261, 76);
            this.btnMusteriOlustur.TabIndex = 6;
            this.btnMusteriOlustur.Text = "Müşteri Oluştur";
            this.btnMusteriOlustur.UseVisualStyleBackColor = true;
            this.btnMusteriOlustur.Click += new System.EventHandler(this.btnMusteriOlustur_Click);
            // 
            // cbMenuler
            // 
            this.cbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuler.FormattingEnabled = true;
            this.cbMenuler.Location = new System.Drawing.Point(1020, 378);
            this.cbMenuler.Name = "cbMenuler";
            this.cbMenuler.Size = new System.Drawing.Size(261, 24);
            this.cbMenuler.TabIndex = 7;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisVer.Location = new System.Drawing.Point(1020, 541);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(261, 75);
            this.btnSiparisVer.TabIndex = 9;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KafeSimulasyonu.Properties.Resources.starbucks;
            this.pictureBox1.Location = new System.Drawing.Point(1020, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::KafeSimulasyonu.Properties.Resources.ArkaPlan;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnKasa);
            this.panel1.Controls.Add(this.btnBarista3);
            this.panel1.Controls.Add(this.btnBarista1);
            this.panel1.Controls.Add(this.btnBarista2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 700);
            this.panel1.TabIndex = 8;
            // 
            // btnKasa
            // 
            this.btnKasa.BackColor = System.Drawing.SystemColors.Control;
            this.btnKasa.BackgroundImage = global::KafeSimulasyonu.Properties.Resources.person5;
            this.btnKasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKasa.Location = new System.Drawing.Point(666, 122);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(60, 65);
            this.btnKasa.TabIndex = 5;
            this.btnKasa.UseVisualStyleBackColor = false;
            // 
            // btnBarista3
            // 
            this.btnBarista3.BackColor = System.Drawing.SystemColors.Control;
            this.btnBarista3.BackgroundImage = global::KafeSimulasyonu.Properties.Resources.person7;
            this.btnBarista3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBarista3.Location = new System.Drawing.Point(328, 122);
            this.btnBarista3.Name = "btnBarista3";
            this.btnBarista3.Size = new System.Drawing.Size(60, 65);
            this.btnBarista3.TabIndex = 4;
            this.btnBarista3.UseVisualStyleBackColor = false;
            // 
            // btnBarista1
            // 
            this.btnBarista1.BackColor = System.Drawing.SystemColors.Control;
            this.btnBarista1.BackgroundImage = global::KafeSimulasyonu.Properties.Resources.person5;
            this.btnBarista1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBarista1.Location = new System.Drawing.Point(526, 86);
            this.btnBarista1.Name = "btnBarista1";
            this.btnBarista1.Size = new System.Drawing.Size(60, 65);
            this.btnBarista1.TabIndex = 2;
            this.btnBarista1.UseVisualStyleBackColor = false;
            // 
            // btnBarista2
            // 
            this.btnBarista2.BackColor = System.Drawing.SystemColors.Control;
            this.btnBarista2.BackgroundImage = global::KafeSimulasyonu.Properties.Resources.person7;
            this.btnBarista2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBarista2.Location = new System.Drawing.Point(427, 122);
            this.btnBarista2.Name = "btnBarista2";
            this.btnBarista2.Size = new System.Drawing.Size(60, 65);
            this.btnBarista2.TabIndex = 3;
            this.btnBarista2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1191, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "İçecekler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbMenuler);
            this.Controls.Add(this.btnMusteriOlustur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Starbucks Sipariş Simülasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMusteriOlustur;
        private System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBarista1;
        public System.Windows.Forms.Button btnBarista2;
        public System.Windows.Forms.Button btnKasa;
        public System.Windows.Forms.Button btnBarista3;
    }
}

