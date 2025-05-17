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
    public partial class Form4 : Form
    {
        string connectionString = "server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security=sspi";

        public Form4()
        {
            InitializeComponent();
        }


        private void DegerlendirmeleriYukle()
        {
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security=sspi"))
            {
                conn.Open();
                string sql = @"SELECT D.DegerlendirmeID, O.Ad AS Oyun, Oy.Ad AS Oyuncu, D.Puan
                       FROM Degerlendirmeler D
                       JOIN Oyunlar O ON D.OyunID = O.OyunID
                       JOIN Oyuncular Oy ON D.OyuncuID = Oy.OyuncuID";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPuanlar.DataSource = dt;
            }
        }


        private void btnPuanVer_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security=sspi"))
            {
                conn.Open();
                string sql = @"INSERT INTO Degerlendirmeler (OyuncuID, OyunID, Puan)
                       VALUES (@OyuncuID, @OyunID, @Puan)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OyuncuID", cmbOyuncu.SelectedValue);
                cmd.Parameters.AddWithValue("@OyunID", cmbOyun.SelectedValue);
                cmd.Parameters.AddWithValue("@Puan", (int)nudPuan.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Puan başarıyla kaydedildi!");
                DegerlendirmeleriYukle();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da1 = new SqlDataAdapter("SELECT OyuncuID, Ad FROM Oyuncular", connectionString);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cmbOyuncu.DisplayMember = "Ad";
            cmbOyuncu.ValueMember = "OyuncuID";
            cmbOyuncu.DataSource = dt1;


            SqlDataAdapter da2 = new SqlDataAdapter("SELECT OyunID, Ad FROM Oyunlar", connectionString);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbOyun.DisplayMember = "Ad";
            cmbOyun.ValueMember = "OyunID";
            cmbOyun.DataSource = dt2;

            DegerlendirmeleriYukle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
