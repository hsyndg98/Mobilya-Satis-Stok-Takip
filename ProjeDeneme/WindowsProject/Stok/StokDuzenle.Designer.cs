namespace ProjeDeneme
{
    partial class StokDuzenle
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
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.urunidTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.miktarTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.islemComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.urunturTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kategoriTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // markaTextBox
            // 
            this.markaTextBox.Location = new System.Drawing.Point(139, 204);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(139, 22);
            this.markaTextBox.TabIndex = 14;
            // 
            // urunidTextBox
            // 
            this.urunidTextBox.Location = new System.Drawing.Point(139, 84);
            this.urunidTextBox.Name = "urunidTextBox";
            this.urunidTextBox.Size = new System.Drawing.Size(139, 22);
            this.urunidTextBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(652, 397);
            this.dataGridView1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ürün Markası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stok ID";
            // 
            // miktarTextBox
            // 
            this.miktarTextBox.Location = new System.Drawing.Point(139, 244);
            this.miktarTextBox.Name = "miktarTextBox";
            this.miktarTextBox.Size = new System.Drawing.Size(139, 22);
            this.miktarTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stok Miktarı";
            // 
            // kaydetButton
            // 
            this.kaydetButton.Location = new System.Drawing.Point(46, 369);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(246, 40);
            this.kaydetButton.TabIndex = 19;
            this.kaydetButton.Text = "KAYDET";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click_1);
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.Location = new System.Drawing.Point(139, 284);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(139, 22);
            this.fiyatTextBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Birim Fiyatı";
            // 
            // islemComboBox
            // 
            this.islemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.islemComboBox.FormattingEnabled = true;
            this.islemComboBox.Items.AddRange(new object[] {
            "Stok Ekle",
            "Stok Sil",
            "Stok Güncelle"});
            this.islemComboBox.Location = new System.Drawing.Point(139, 44);
            this.islemComboBox.Name = "islemComboBox";
            this.islemComboBox.Size = new System.Drawing.Size(139, 24);
            this.islemComboBox.TabIndex = 22;
            this.islemComboBox.SelectedIndexChanged += new System.EventHandler(this.islemComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Yapılacak İşlem";
            // 
            // urunturTextBox
            // 
            this.urunturTextBox.Location = new System.Drawing.Point(139, 164);
            this.urunturTextBox.Name = "urunturTextBox";
            this.urunturTextBox.Size = new System.Drawing.Size(139, 22);
            this.urunturTextBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ürün Türü";
            // 
            // kategoriTextBox
            // 
            this.kategoriTextBox.Location = new System.Drawing.Point(139, 124);
            this.kategoriTextBox.Name = "kategoriTextBox";
            this.kategoriTextBox.Size = new System.Drawing.Size(139, 22);
            this.kategoriTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kategori";
            // 
            // StokDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 464);
            this.Controls.Add(this.kategoriTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urunturTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.islemComboBox);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.miktarTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.markaTextBox);
            this.Controls.Add(this.urunidTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "StokDuzenle";
            this.Text = "StokDuzenle";
            this.Load += new System.EventHandler(this.StokDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.TextBox urunidTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox miktarTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox islemComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox urunturTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kategoriTextBox;
        private System.Windows.Forms.Label label2;
    }
}