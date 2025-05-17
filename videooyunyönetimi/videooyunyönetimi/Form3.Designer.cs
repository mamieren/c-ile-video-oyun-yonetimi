namespace videooyunyönetimi
{
    partial class Form3
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
            cmbOyuncular = new ComboBox();
            cmbOyunlar = new ComboBox();
            btnKoleksiyonaEkle = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbOyuncular
            // 
            cmbOyuncular.FormattingEnabled = true;
            cmbOyuncular.Location = new Point(226, 59);
            cmbOyuncular.Name = "cmbOyuncular";
            cmbOyuncular.Size = new Size(151, 28);
            cmbOyuncular.TabIndex = 0;
            // 
            // cmbOyunlar
            // 
            cmbOyunlar.FormattingEnabled = true;
            cmbOyunlar.Location = new Point(225, 16);
            cmbOyunlar.Name = "cmbOyunlar";
            cmbOyunlar.Size = new Size(151, 28);
            cmbOyunlar.TabIndex = 1;
            // 
            // btnKoleksiyonaEkle
            // 
            btnKoleksiyonaEkle.BackColor = Color.FromArgb(0, 192, 192);
            btnKoleksiyonaEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKoleksiyonaEkle.Location = new Point(153, 101);
            btnKoleksiyonaEkle.Name = "btnKoleksiyonaEkle";
            btnKoleksiyonaEkle.Size = new Size(154, 29);
            btnKoleksiyonaEkle.TabIndex = 2;
            btnKoleksiyonaEkle.Text = "Koleyksiyona Ekle";
            btnKoleksiyonaEkle.UseVisualStyleBackColor = false;
            btnKoleksiyonaEkle.Click += btnKoleksiyonaEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(60, 20);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 3;
            label1.Text = "Eklenebilecek oyunlar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(88, 62);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 4;
            label2.Text = "Oyuncuyu seç";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Location = new Point(139, 167);
            button1.Name = "button1";
            button1.Size = new Size(335, 29);
            button1.TabIndex = 5;
            button1.Text = " Oyuncu Oluşturma ve Koleksiyon Görüntüleme";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(477, 201);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKoleksiyonaEkle);
            Controls.Add(cmbOyunlar);
            Controls.Add(cmbOyuncular);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOyuncular;
        private ComboBox cmbOyunlar;
        private Button btnKoleksiyonaEkle;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}