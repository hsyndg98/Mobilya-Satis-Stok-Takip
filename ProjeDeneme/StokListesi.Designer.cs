namespace ProjeDeneme
{
    partial class StokListesi
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
            this.stoklisteDataGridView = new System.Windows.Forms.DataGridView();
            this.stokidTextBox = new System.Windows.Forms.TextBox();
            this.kategoriTextBox = new System.Windows.Forms.TextBox();
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.stokListelebutton = new System.Windows.Forms.Button();
            this.hepsiListeleButton = new System.Windows.Forms.Button();
            this.urunturTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stoklisteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Markası";
            // 
            // stoklisteDataGridView
            // 
            this.stoklisteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stoklisteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stoklisteDataGridView.Location = new System.Drawing.Point(299, 12);
            this.stoklisteDataGridView.Name = "stoklisteDataGridView";
            this.stoklisteDataGridView.RowHeadersWidth = 51;
            this.stoklisteDataGridView.RowTemplate.Height = 24;
            this.stoklisteDataGridView.Size = new System.Drawing.Size(652, 343);
            this.stoklisteDataGridView.TabIndex = 3;
            // 
            // stokidTextBox
            // 
            this.stokidTextBox.Location = new System.Drawing.Point(114, 25);
            this.stokidTextBox.Name = "stokidTextBox";
            this.stokidTextBox.Size = new System.Drawing.Size(139, 22);
            this.stokidTextBox.TabIndex = 4;
            // 
            // kategoriTextBox
            // 
            this.kategoriTextBox.Location = new System.Drawing.Point(114, 72);
            this.kategoriTextBox.Name = "kategoriTextBox";
            this.kategoriTextBox.Size = new System.Drawing.Size(139, 22);
            this.kategoriTextBox.TabIndex = 5;
            // 
            // markaTextBox
            // 
            this.markaTextBox.Location = new System.Drawing.Point(114, 166);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(139, 22);
            this.markaTextBox.TabIndex = 6;
            // 
            // stokListelebutton
            // 
            this.stokListelebutton.Location = new System.Drawing.Point(28, 223);
            this.stokListelebutton.Name = "stokListelebutton";
            this.stokListelebutton.Size = new System.Drawing.Size(225, 49);
            this.stokListelebutton.TabIndex = 7;
            this.stokListelebutton.Text = "Stok Listele";
            this.stokListelebutton.UseVisualStyleBackColor = true;
            this.stokListelebutton.Click += new System.EventHandler(this.stokListelebutton_Click);
            // 
            // hepsiListeleButton
            // 
            this.hepsiListeleButton.Location = new System.Drawing.Point(28, 291);
            this.hepsiListeleButton.Name = "hepsiListeleButton";
            this.hepsiListeleButton.Size = new System.Drawing.Size(225, 49);
            this.hepsiListeleButton.TabIndex = 8;
            this.hepsiListeleButton.Text = "Hepsini Göster";
            this.hepsiListeleButton.UseVisualStyleBackColor = true;
            this.hepsiListeleButton.Click += new System.EventHandler(this.hepsiListeleButton_Click);
            // 
            // urunturTextBox
            // 
            this.urunturTextBox.Location = new System.Drawing.Point(114, 119);
            this.urunturTextBox.Name = "urunturTextBox";
            this.urunturTextBox.Size = new System.Drawing.Size(139, 22);
            this.urunturTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mobilya Tür";
            // 
            // StokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 367);
            this.Controls.Add(this.urunturTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hepsiListeleButton);
            this.Controls.Add(this.stokListelebutton);
            this.Controls.Add(this.markaTextBox);
            this.Controls.Add(this.kategoriTextBox);
            this.Controls.Add(this.stokidTextBox);
            this.Controls.Add(this.stoklisteDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StokListesi";
            this.Text = "StokListesi";
            this.Load += new System.EventHandler(this.StokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stoklisteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView stoklisteDataGridView;
        private System.Windows.Forms.TextBox stokidTextBox;
        private System.Windows.Forms.TextBox kategoriTextBox;
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.Button stokListelebutton;
        private System.Windows.Forms.Button hepsiListeleButton;
        private System.Windows.Forms.TextBox urunturTextBox;
        private System.Windows.Forms.Label label4;
    }
}