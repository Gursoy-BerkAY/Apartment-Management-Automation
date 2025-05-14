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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Apartman_Yönetim_Otomasyonu
{
    public partial class Admin_Kiracı_İslemleri : Form
    {
        public Admin_Kiracı_İslemleri()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F9EHAF8;Initial Catalog=Apartman_Yonetim;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand cmd = new SqlCommand("insert into Kiraci values('"+textBox1.Text+ "','"+textBox2.Text+ "','"+textBox3.Text+ "','"+textBox4.Text+ "','"+textBox5.Text+ "','"+textBox6.Text+"','"+textBox7.Text+"')", conn);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("select * from Kiraci", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();//bağlantıyı kapat
            
        }

        private void Admin_Kiracı_İslemleri_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand cmd1 = new SqlCommand("select * from Calisanlar ",conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;

            
            // TODO: Bu kod satırı 'apartman_YonetimDataSet1.Kiraci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kiraciTableAdapter.Fill(this.apartman_YonetimDataSet1.Kiraci);
            // TODO: Bu kod satırı 'apartman_YonetimDataSet1.Kiraci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kiraciTableAdapter.Fill(this.apartman_YonetimDataSet1.Kiraci);
            // TODO: Bu kod satırı 'apartman_YonetimDataSet1.Calisanlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            conn.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand cmd = new SqlCommand("delete from Kiraci where Kiracı_ID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() +"'",conn);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("select * from Kiraci", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();//bağlantıyı kapat

           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand cmd = new SqlCommand("update Kiraci set Kiracı_Ad='" + textBox1.Text + "',Kiracı_Soyad='" + textBox2.Text + "',Kiracı_TC='" + textBox3.Text + "',Kiracı_Tel='" + textBox4.Text + "',Daire_No='" + textBox5.Text + "',Odenen_Kira='" + textBox6.Text + "',Kiracı_Sifre='" + textBox7.Text + "' where Kiracı_ID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() +"'", conn);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("select * from Kiraci", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();//bağlantıyı kapat

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand calisan = new SqlCommand("update Calisanlar set merdiven_temizlikcisi=@merd , Kapıcı=@kapı", conn);
            calisan.Parameters.AddWithValue("@kapı",textBox9.Text);
            calisan.Parameters.AddWithValue("@merd",textBox8.Text);
            calisan.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand("select * from Calisanlar", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox9.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
