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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            OyunculariYukle();
            OyunlariYukle();

        }
        private void OyunlariYukle()
        {
            using SqlConnection conn = new SqlConnection("server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security =sspi");
            {
                conn.Open();
                string sql = "SELECT OyunID, Ad FROM Oyunlar";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbOyunlar.DataSource = dt;
                cmbOyunlar.DisplayMember = "Ad";
                cmbOyunlar.ValueMember = "OyunID";
            }
        }
        private void OyunculariYukle()
        {
            using SqlConnection conn = new SqlConnection("server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security =sspi");
            {
                conn.Open();
                string sql = "SELECT OyuncuID, Ad FROM Oyuncular";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbOyuncular.DataSource = dt;
                cmbOyuncular.DisplayMember = "Ad";
                cmbOyuncular.ValueMember = "OyuncuID";
            }
        }

        private void btnKoleksiyonaEkle_Click(object sender, EventArgs e)
        {
            int oyuncuId = Convert.ToInt32(cmbOyuncular.SelectedValue);
            int oyunId = Convert.ToInt32(cmbOyunlar.SelectedValue);

            using SqlConnection conn = new SqlConnection("server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security =sspi");
            {
                conn.Open();

                // Oyuncunun KoleksiyonID’sini bul
                string getKoleksiyonSql = "SELECT KoleksiyonID FROM Koleksiyonlar WHERE OyuncuID = @OyuncuID";
                SqlCommand getCmd = new SqlCommand(getKoleksiyonSql, conn);
                getCmd.Parameters.AddWithValue("@OyuncuID", oyuncuId);
                object result = getCmd.ExecuteScalar();

                if (result != null)
                {
                    int koleksiyonId = Convert.ToInt32(result);

                    // Ekleme işlemi
                    string insertSql = "INSERT INTO KoleksiyonOyunlari (KoleksiyonID, OyunID) VALUES (@KID, @OID)";
                    SqlCommand insertCmd = new SqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("@KID", koleksiyonId);
                    insertCmd.Parameters.AddWithValue("@OID", oyunId);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Oyun koleksiyona eklendi.");
                }
                else
                {
                    MessageBox.Show("Bu oyuncuya ait koleksiyon bulunamadı.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
