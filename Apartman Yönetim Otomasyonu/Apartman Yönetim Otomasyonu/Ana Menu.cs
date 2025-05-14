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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F9EHAF8;Initial Catalog=Apartman_Yonetim;Integrated Security=True");
        Kiraci_İslemleri frm = new Kiraci_İslemleri();
        Admin_Paneli pnl = new Admin_Paneli();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
               conn.Open();//bağlantıyı aç
            }
            SqlCommand command = new SqlCommand("select Kiracı_Ad , Kiracı_Sifre from Kiraci where Kiracı_Ad=@k_ad and Kiracı_Sifre=@k_sifre", conn);//Sqldeki Kiracı Tablosundan Kiracı adı ve şifresini @k_ad ve @k_sifre değişkenleriyle eşit olup olmadığına bakıyoruz
            command.Parameters.AddWithValue("@k_ad", textBox1.Text);//@k_ad değişkeni verileri textbox1 alacak ve sqlcommand kısmında @k_ad yerine textbox1 deki veriyi yazacak
            command.Parameters.AddWithValue("@k_sifre",textBox2.Text);
            command.ExecuteNonQuery();//kodu Çalıştır
            SqlDataReader reader = command.ExecuteReader();//Kodu Oku
            if (reader.HasRows)//Bilgilerin uyuşup uyuşmadığını kontrol et
            {
                MessageBox.Show("Giriş Başarılı");//mesaj ver
                frm.Show();//Kiracı işlemleri formunu aç
                frm.TextBoxValue = textBox1.Text;
                frm.TextBox2Value=textBox2.Text;
            }
            else
            {
                MessageBox.Show("Giriş Hatalı Tekrar Deneyin");
            }

            conn.Close();//bağlantıyı kapat
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)//bağlantı açık değilse
            {
                conn.Open();//bağlantıyı aç
            }
            SqlCommand cmd = new SqlCommand("select Kod_Adi , Admin_Sifre from Admin where Kod_Adi=@a_ad and Admin_Sifre=@a_sifre", conn);//Sqldeki Kiracı Tablosundan Kiracı adı ve şifresini @k_ad ve @k_sifre değişkenleriyle eşit olup olmadığına bakıyoruz
            cmd.Parameters.AddWithValue("@a_ad", textBox3.Text);//@k_ad değişkeni verileri textbox1 alacak ve sqlcommand kısmında @k_ad yerine textbox1 deki veriyi yazacak
            cmd.Parameters.AddWithValue("@a_sifre", textBox4.Text);
            cmd.ExecuteNonQuery();//kodu Çalıştır
            SqlDataReader read = cmd.ExecuteReader();//Kodu Oku
            if (read.HasRows)//Bilgilerin uyuşup uyuşmadığını kontrol et
            {
                MessageBox.Show("Giriş Başarılı");//mesaj ver
                pnl.Show();//Kiracı işlemleri formunu aç
            }
            else
            {
                MessageBox.Show("Giriş Hatalı Tekrar Deneyin");
            }

            conn.Close();//bağlantıyı kapat
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Location = new Point(214 , 94);
            groupBox2.Visible = false;
            groupBox1.Size = new Size(246, 174);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox2.Location = new Point(214, 94);
            groupBox1 .Visible = false;
            groupBox2.Size = new Size(269, 174);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

