namespace videooyunyönetimi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtOyunAdi = new TextBox();
            cmbTur = new ComboBox();
            cmbPlatform = new ComboBox();
            btnOyunEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvOyunlar = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOyunlar).BeginInit();
            SuspendLayout();
            // 
            // txtOyunAdi
            // 
            txtOyunAdi.Location = new Point(326, 10);
            txtOyunAdi.Name = "txtOyunAdi";
            txtOyunAdi.Size = new Size(125, 27);
            txtOyunAdi.TabIndex = 0;
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Items.AddRange(new object[] { "Aksiyon\"", "Macera", "RPG", "Simülasyon", "Strateji", "Spor", "Yarış", "Korku" });
            cmbTur.Location = new Point(315, 43);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(151, 28);
            cmbTur.TabIndex = 1;
            // 
            // cmbPlatform
            // 
            cmbPlatform.FormattingEnabled = true;
            cmbPlatform.Items.AddRange(new object[] { "PC", "PlayStation", "Xbox", "Nintendo Switch", "Mobil", "Diğer" });
            cmbPlatform.Location = new Point(315, 86);
            cmbPlatform.Name = "cmbPlatform";
            cmbPlatform.Size = new Size(151, 28);
            cmbPlatform.TabIndex = 2;
            // 
            // btnOyunEkle
            // 
            btnOyunEkle.BackColor = Color.FromArgb(0, 192, 192);
            btnOyunEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOyunEkle.Location = new Point(300, 126);
            btnOyunEkle.Name = "btnOyunEkle";
            btnOyunEkle.Size = new Size(151, 38);
            btnOyunEkle.TabIndex = 3;
            btnOyunEkle.Text = "Oyun Ekle";
            btnOyunEkle.UseVisualStyleBackColor = false;
            btnOyunEkle.Click += btnOyunEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(214, 17);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 5;
            label1.Text = "Oyun Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(209, 51);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 6;
            label2.Text = " Oyun türü";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(186, 91);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 7;
            label3.Text = "Oyun platformu";
            // 
            // dgvOyunlar
            // 
            dgvOyunlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOyunlar.Location = new Point(110, 175);
            dgvOyunlar.Name = "dgvOyunlar";
            dgvOyunlar.RowHeadersWidth = 51;
            dgvOyunlar.Size = new Size(491, 188);
            dgvOyunlar.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(326, 369);
            button1.Name = "button1";
            button1.Size = new Size(343, 29);
            button1.TabIndex = 9;
            button1.Text = " Oyuncu Oluşturma ve Koleksiyon Görüntüleme";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(691, 404);
            Controls.Add(button1);
            Controls.Add(dgvOyunlar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOyunEkle);
            Controls.Add(cmbPlatform);
            Controls.Add(cmbTur);
            Controls.Add(txtOyunAdi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOyunlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOyunAdi;
        private ComboBox cmbTur;
        private ComboBox cmbPlatform;
        private Button btnOyunEkle;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvOyunlar;
        private Button button1;
    }
}
