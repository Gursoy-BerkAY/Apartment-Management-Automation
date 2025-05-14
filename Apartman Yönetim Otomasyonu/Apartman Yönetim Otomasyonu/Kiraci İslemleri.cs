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

namespace Apartman_Yönetim_Otomasyonu
{
    public partial class Kiraci_İslemleri : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F9EHAF8;Initial Catalog=Apartman_Yonetim;Integrated Security=True");

        public Kiraci_İslemleri()
        {
            InitializeComponent();
        }
        public string TextBox2Value
        {

            get
            {
                return
                    textBox7.Text;
            }
            set
            {
                textBox7.Text = value;
            }
        }
        public string TextBoxValue
        {

            get
            {
                return
                    textBox1.Text;
            }
            set {textBox1.Text = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand cmd = new SqlCommand("select * from Bina",conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }

            SqlCommand cmd = new SqlCommand("select c.Kapıcı , c.merdiven_temizlikcisi , k.Odenen_Kira from Calisanlar c cross join Kiraci k",conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource= dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand command = new SqlCommand("select count(*) from Kiraci where Kiracı_Ad=@k_ad and Kiracı_Sifre=@k_sifre", conn);//Sqldeki Kiracı Tablosundan Kiracı adı ve şifresini @k_ad ve @k_sifre değişkenleriyle eşit olup olmadığına bakıyoruz
            command.Parameters.AddWithValue("@k_ad", textBox1.Text);//@k_ad değişkeni verileri textbox1 alacak ve sqlcommand kısmında @k_ad yerine textbox1 deki veriyi yazacak
            command.Parameters.AddWithValue("@k_sifre", textBox7.Text);
            int count=(int)command.ExecuteScalar();
            if (count > 0)
            {
                

                SqlCommand cmd = new SqlCommand("select * from Kiraci where Kiracı_Ad=@k_ad", conn);
                cmd.Parameters.AddWithValue("@k_ad",textBox1.Text);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count>0)
                {
                    textBox1.Text = dt.Rows[0]["Kiracı_Ad"].ToString();
                    textBox7.Text = dt.Rows[0]["Kiracı_Sifre"].ToString();
                    textBox3.Text = dt.Rows[0]["Kiracı_TC"].ToString();
                    textBox4.Text = dt.Rows[0]["Kiracı_Tel"].ToString();
                    textBox5.Text = dt.Rows[0]["Daire_No"].ToString();
                    textBox6.Text = dt.Rows[0]["Odenen_Kira"].ToString();
                    textBox2.Text = dt.Rows[0]["Kiracı_Soyad"].ToString();
                    
                }
            }
            

            conn.Close();//bağlantıyı kapat
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Kiraci_İslemleri_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
