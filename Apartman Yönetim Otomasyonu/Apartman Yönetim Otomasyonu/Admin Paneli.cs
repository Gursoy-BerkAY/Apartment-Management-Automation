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
    public partial class Admin_Paneli : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F9EHAF8;Initial Catalog=Apartman_Yonetim;Integrated Security=True");

        public Admin_Paneli()
        {
            InitializeComponent();
        }
        Admin_Kiracı_İslemleri frm=new Admin_Kiracı_İslemleri();
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand cmd = new SqlCommand("select * from Admin",conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();//bağlantıyı kapat
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand cmd = new SqlCommand("insert into Admin values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')",conn);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("select * from Admin", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();//bağlantıyı kapat
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand cmd = new SqlCommand("delete from Admin where Admin_ID=@ıd", conn);
            cmd.Parameters.AddWithValue("@ıd",int.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("select * from Admin", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();//bağlantıyı kapat
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand cmd = new SqlCommand("update Admin set Admin_Ad_Soyad=@ads , Kod_Adi=@kad , Admin_Sifre=@sifre where Admin_ID=@ıd", conn);
            cmd.Parameters.AddWithValue("@ıd", int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            cmd.Parameters.AddWithValue("@ads",textBox1.Text);
            cmd.Parameters.AddWithValue("@kad",textBox2.Text);
            cmd.Parameters.AddWithValue("@sifre",textBox3.Text);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("select * from Admin", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();//bağlantıyı kapat
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
