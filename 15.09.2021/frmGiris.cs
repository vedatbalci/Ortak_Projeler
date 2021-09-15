using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frm_Telefon_Rehberi_Ajanda
{
    public partial class frmGiris : Form
    {
        //Provider=SQLNCLI11;Data Source=DESKTOP-8J65VLQ\MSSQLSERVER2017;Integrated Security=SSPI;Initial Catalog=telefon_rehberi_ajanda
        //Data Source=DESKTOP-8J65VLQ\MSSQLSERVER2017;Initial Catalog=telefon_rehberi_ajanda;Integrated Security=True
        public frmGiris()
        {
            InitializeComponent();
        }
        //OdaBilgisayarı
        #region Okul Baglantisi
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8J65VLQ\MSSQLSERVER2017;Initial Catalog=telefon_rehberi_ajanda;Integrated Security=True");
        #endregion
        #region Ev Baglantisi
      //  SqlConnection con = new SqlConnection(@"Data Source=ODABILGISAYARı;Initial Catalog=telefon_rehberi_ajanda;Integrated Security=True");
        #endregion
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source = "D:\bilişim dersi nesne tabanlı\frmProgramAcma\programlar.mdb"





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //try
            //{
            con.Open();
            string sql = "Select * from Sifreler where Adi=@adi AND Sifresi=@sifresi";

            SqlParameter sql1 = new SqlParameter("adi", txtKullaniciAdi.Text.Trim());
            SqlParameter sql2 = new SqlParameter("sifresi", txtSifre.Text.Trim());
            SqlCommand komut = new SqlCommand(sql, con);
            komut.Parameters.Add(sql1);
            komut.Parameters.Add(sql2);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                frmtelefonrehberi frm = new frmtelefonrehberi();
                frm.Show();

                this.Hide();
                con.Open();
                
                SqlCommand cmd1 = new SqlCommand("insert into kayitliSifreler (KulAdi,Sifre) values (@adi,@si)", con);
                cmd1.Parameters.AddWithValue("@adi", txtKullaniciAdi.Text.ToString());
                cmd1.Parameters.AddWithValue("@si", txtSifre.Text.ToString());
                cmd1.ExecuteNonQuery();
                con.Close();




            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız !");
            }

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Hatalı Giriş Yaptınız !");
            //}



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Şifreyi Göster";
                //karakteri göster.
                txtSifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                checkBox1.Text = "Şifreyi Gizle";
                txtSifre.PasswordChar = '*';
            }
        }

        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSifre.Select();

            }



        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.Select();
                btnGiris.Select();
            }
        }

        private void btnGiris_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged11(object sender, EventArgs e)
        {


        }

        private void frmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
