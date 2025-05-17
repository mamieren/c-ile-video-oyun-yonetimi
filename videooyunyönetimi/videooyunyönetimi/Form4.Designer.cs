namespace videooyunyönetimi
{
    partial class Form4
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
            cmbOyuncu = new ComboBox();
            cmbOyun = new ComboBox();
            nudPuan = new NumericUpDown();
            btnPuanVer = new Button();
            dgvPuanlar = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPuan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPuanlar).BeginInit();
            SuspendLayout();
            // 
            // cmbOyuncu
            // 
            cmbOyuncu.FormattingEnabled = true;
            cmbOyuncu.Location = new Point(286, 22);
            cmbOyuncu.Name = "cmbOyuncu";
            cmbOyuncu.Size = new Size(151, 28);
            cmbOyuncu.TabIndex = 0;
            // 
            // cmbOyun
            // 
            cmbOyun.FormattingEnabled = true;
            cmbOyun.Location = new Point(286, 65);
            cmbOyun.Name = "cmbOyun";
            cmbOyun.Size = new Size(151, 28);
            cmbOyun.TabIndex = 1;
            // 
            // nudPuan
            // 
            nudPuan.Location = new Point(286, 114);
            nudPuan.Name = "nudPuan";
            nudPuan.Size = new Size(150, 27);
            nudPuan.TabIndex = 2;
            // 
            // btnPuanVer
            // 
            btnPuanVer.Location = new Point(286, 162);
            btnPuanVer.Name = "btnPuanVer";
            btnPuanVer.Size = new Size(151, 29);
            btnPuanVer.TabIndex = 3;
            btnPuanVer.Text = "Değerlendir";
            btnPuanVer.UseVisualStyleBackColor = true;
            btnPuanVer.Click += btnPuanVer_Click;
            // 
            // dgvPuanlar
            // 
            dgvPuanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuanlar.Location = new Point(101, 197);
            dgvPuanlar.Name = "dgvPuanlar";
            dgvPuanlar.RowHeadersWidth = 51;
            dgvPuanlar.Size = new Size(556, 188);
            dgvPuanlar.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(366, 391);
            button1.Name = "button1";
            button1.Size = new Size(349, 29);
            button1.TabIndex = 5;
            button1.Text = " Oyuncu Oluşturma ve Koleksiyon Görüntüleme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 25);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 6;
            label1.Text = "Oyuncu seç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 73);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Oyun seç";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 121);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 8;
            label3.Text = "Puan ver";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dgvPuanlar);
            Controls.Add(btnPuanVer);
            Controls.Add(nudPuan);
            Controls.Add(cmbOyun);
            Controls.Add(cmbOyuncu);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)nudPuan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPuanlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOyuncu;
        private ComboBox cmbOyun;
        private NumericUpDown nudPuan;
        private Button btnPuanVer;
        private DataGridView dgvPuanlar;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}