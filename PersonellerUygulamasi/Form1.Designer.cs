namespace PersonellerUygulamasi
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
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.txtPerAd = new System.Windows.Forms.TextBox();
            this.txtPerSoyad = new System.Windows.Forms.TextBox();
            this.txtPerID = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(506, 68);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(171, 23);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "PERSONEL EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personel ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yaş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şehir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Maaş";
            // 
            // Btn_sil
            // 
            this.Btn_sil.Location = new System.Drawing.Point(506, 97);
            this.Btn_sil.Name = "Btn_sil";
            this.Btn_sil.Size = new System.Drawing.Size(171, 23);
            this.Btn_sil.TabIndex = 8;
            this.Btn_sil.Text = "PERSONEL SİL";
            this.Btn_sil.UseVisualStyleBackColor = true;
            this.Btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(506, 127);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(171, 23);
            this.btn_Guncelle.TabIndex = 9;
            this.btn_Guncelle.Text = "PERSONEL GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // txtPerAd
            // 
            this.txtPerAd.Location = new System.Drawing.Point(256, 68);
            this.txtPerAd.Name = "txtPerAd";
            this.txtPerAd.Size = new System.Drawing.Size(100, 20);
            this.txtPerAd.TabIndex = 2;
            // 
            // txtPerSoyad
            // 
            this.txtPerSoyad.Location = new System.Drawing.Point(256, 100);
            this.txtPerSoyad.Name = "txtPerSoyad";
            this.txtPerSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtPerSoyad.TabIndex = 3;
            // 
            // txtPerID
            // 
            this.txtPerID.Location = new System.Drawing.Point(256, 33);
            this.txtPerID.Name = "txtPerID";
            this.txtPerID.Size = new System.Drawing.Size(100, 20);
            this.txtPerID.TabIndex = 1;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(256, 136);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 20);
            this.txtYas.TabIndex = 4;
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(256, 162);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 20);
            this.txtSehir.TabIndex = 5;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(256, 189);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 20);
            this.txtMaas.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(966, 218);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PersonellerUygulamasi.Properties.Resources.redGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtPerID);
            this.Controls.Add(this.txtPerSoyad);
            this.Controls.Add(this.txtPerAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.Btn_sil);
            this.Controls.Add(this.btn_Ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.TextBox txtPerAd;
        private System.Windows.Forms.TextBox txtPerSoyad;
        private System.Windows.Forms.TextBox txtPerID;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

