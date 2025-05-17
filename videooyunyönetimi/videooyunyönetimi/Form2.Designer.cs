namespace videooyunyönetimi
{
    partial class Form2
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
            txtOyuncuAdi = new TextBox();
            cmbFavoriOyun = new ComboBox();
            btnOyuncuEkle = new Button();
            cmbOyuncular = new ComboBox();
            btnKoleksiyonuGoster = new Button();
            dgvKoleksiyon = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKoleksiyon).BeginInit();
            SuspendLayout();
            // 
            // txtOyuncuAdi
            // 
            txtOyuncuAdi.Location = new Point(145, 11);
            txtOyuncuAdi.Name = "txtOyuncuAdi";
            txtOyuncuAdi.Size = new Size(151, 27);
            txtOyuncuAdi.TabIndex = 0;
            // 
            // cmbFavoriOyun
            // 
            cmbFavoriOyun.FormattingEnabled = true;
            cmbFavoriOyun.Location = new Point(145, 54);
            cmbFavoriOyun.Name = "cmbFavoriOyun";
            cmbFavoriOyun.Size = new Size(151, 28);
            cmbFavoriOyun.TabIndex = 1;
            // 
            // btnOyuncuEkle
            // 
            btnOyuncuEkle.BackColor = Color.FromArgb(0, 192, 192);
            btnOyuncuEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOyuncuEkle.Location = new Point(122, 88);
            btnOyuncuEkle.Name = "btnOyuncuEkle";
            btnOyuncuEkle.Size = new Size(129, 42);
            btnOyuncuEkle.TabIndex = 2;
            btnOyuncuEkle.Text = "Oyuncu Ekle";
            btnOyuncuEkle.UseVisualStyleBackColor = false;
            btnOyuncuEkle.Click += btnOyuncuEkle_Click;
            // 
            // cmbOyuncular
            // 
            cmbOyuncular.FormattingEnabled = true;
            cmbOyuncular.Location = new Point(630, 30);
            cmbOyuncular.Name = "cmbOyuncular";
            cmbOyuncular.Size = new Size(151, 28);
            cmbOyuncular.TabIndex = 3;
            // 
            // btnKoleksiyonuGoster
            // 
            btnKoleksiyonuGoster.BackColor = Color.FromArgb(0, 192, 192);
            btnKoleksiyonuGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKoleksiyonuGoster.Location = new Point(522, 103);
            btnKoleksiyonuGoster.Name = "btnKoleksiyonuGoster";
            btnKoleksiyonuGoster.Size = new Size(177, 42);
            btnKoleksiyonuGoster.TabIndex = 4;
            btnKoleksiyonuGoster.Text = "Koleksiyonu göster";
            btnKoleksiyonuGoster.UseVisualStyleBackColor = false;
            btnKoleksiyonuGoster.Click += btnKoleksiyonuGoster_Click;
            // 
            // dgvKoleksiyon
            // 
            dgvKoleksiyon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKoleksiyon.Location = new Point(176, 160);
            dgvKoleksiyon.Name = "dgvKoleksiyon";
            dgvKoleksiyon.RowHeadersWidth = 51;
            dgvKoleksiyon.Size = new Size(523, 212);
            dgvKoleksiyon.TabIndex = 5;
            dgvKoleksiyon.CellContentClick += dgvKoleksiyon_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(47, 18);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 6;
            label1.Text = "Oyuncu Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(47, 62);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 7;
            label2.Text = "\tFavori oyun ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(362, 33);
            label3.Name = "label3";
            label3.Size = new Size(262, 20);
            label3.TabIndex = 8;
            label3.Text = "Koleksiyonu görüntülenecek oyuncu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 137);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 9;
            label4.Text = "Koleksiyondaki oyunlar";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Location = new Point(584, 378);
            button1.Name = "button1";
            button1.Size = new Size(209, 29);
            button1.TabIndex = 10;
            button1.Text = "Oyun Ekleme sayfasına dön";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.Location = new Point(584, 413);
            button2.Name = "button2";
            button2.Size = new Size(209, 29);
            button2.TabIndex = 11;
            button2.Text = "Kolekssiyona Oyun Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 255);
            button3.Location = new Point(584, 448);
            button3.Name = "button3";
            button3.Size = new Size(209, 29);
            button3.TabIndex = 12;
            button3.Text = "Oyun değerlendirme";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(804, 487);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvKoleksiyon);
            Controls.Add(btnKoleksiyonuGoster);
            Controls.Add(cmbOyuncular);
            Controls.Add(btnOyuncuEkle);
            Controls.Add(cmbFavoriOyun);
            Controls.Add(txtOyuncuAdi);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKoleksiyon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOyuncuAdi;
        private ComboBox cmbFavoriOyun;
        private Button btnOyuncuEkle;
        private ComboBox cmbOyuncular;
        private Button btnKoleksiyonuGoster;
        private DataGridView dgvKoleksiyon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}