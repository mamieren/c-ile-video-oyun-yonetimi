using System.Data;
using System.Data.SqlClient;

namespace videooyunyönetimi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OyunlariListele()
        {
            using SqlConnection conn = new SqlConnection("server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security =sspi");
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Oyunlar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOyunlar.DataSource = dt;
            }
        }


        private void btnOyunEkle_Click(object sender, EventArgs e)
        {
            string oyunAdi = txtOyunAdi.Text;
            string tur = cmbTur.SelectedItem.ToString();
            string platform = cmbPlatform.SelectedItem.ToString();

            if (string.IsNullOrEmpty(oyunAdi) || string.IsNullOrEmpty(tur) || string.IsNullOrEmpty(platform))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            using SqlConnection conn = new SqlConnection("server=DESKTOP-3M4E4P0;initial catalog=videooyun;integrated security =sspi");
            {
                conn.Open();
                string query = "INSERT INTO Oyunlar (Ad, Tur, Platform) VALUES (@Ad, @Tur, @Platform)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ad", oyunAdi);
                cmd.Parameters.AddWithValue("@Tur", tur);
                cmd.Parameters.AddWithValue("@Platform", platform);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Oyun başarıyla eklendi!");
                OyunlariListele();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
