using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videooyunyönetimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FavoriOyunlariYukle();
            OyunculariYukle();

        }
        private void FavoriOyunlariYukle()
        {
            using SqlConnection conn = new SqlConnection("server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security =sspi");
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Oyunlar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbFavoriOyun.DisplayMember = "Ad";
                cmbFavoriOyun.ValueMember = "OyunID";
                cmbFavoriOyun.DataSource = dt;
            }
        }

        private void OyunculariYukle()
        {
            using SqlConnection conn = new SqlConnection("server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security =sspi");
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Oyuncular", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbOyuncular.DisplayMember = "Ad";
                cmbOyuncular.ValueMember = "OyuncuID";
                cmbOyuncular.DataSource = dt;
            }
        }

        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security=sspi"))
            {
                conn.Open();

                // Oyuncu ekleme + ID alma
                SqlCommand cmd = new SqlCommand("INSERT INTO Oyuncular (Ad, FavoriOyunID) VALUES (@Ad, @FavoriOyunID); SELECT SCOPE_IDENTITY();", conn);
                cmd.Parameters.AddWithValue("@Ad", txtOyuncuAdi.Text);
                cmd.Parameters.AddWithValue("@FavoriOyunID", cmbFavoriOyun.SelectedValue);
                int yeniOyuncuID = Convert.ToInt32(cmd.ExecuteScalar());

                // Koleksiyon oluşturma
                SqlCommand koleksiyonCmd = new SqlCommand("INSERT INTO Koleksiyonlar (OyuncuID) VALUES (@OyuncuID)", conn);
                koleksiyonCmd.Parameters.AddWithValue("@OyuncuID", yeniOyuncuID);
                koleksiyonCmd.ExecuteNonQuery();

                MessageBox.Show("Oyuncu ve koleksiyonu başarıyla eklendi!");
                OyunculariYukle(); // ComboBox'ı güncelle
            }
        }

        private void btnKoleksiyonuGoster_Click(object sender, EventArgs e)
        {
            int oyuncuId = Convert.ToInt32(cmbOyuncular.SelectedValue);
            KoleksiyonuGoster(oyuncuId);
        }
        private void KoleksiyonuGoster(int oyuncuId)
        {
            using SqlConnection conn = new SqlConnection("server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security =sspi");
            {
                conn.Open();
                string sql = @"
            SELECT O.Ad, O.Tur, O.Platform
            FROM KoleksiyonOyunlari KO
            JOIN Oyunlar O ON KO.OyunID = O.OyunID
            JOIN Koleksiyonlar K ON KO.KoleksiyonID = K.KoleksiyonID
            WHERE K.OyuncuID = @OyuncuID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OyuncuID", oyuncuId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKoleksiyon.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }

        private void dgvKoleksiyon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
