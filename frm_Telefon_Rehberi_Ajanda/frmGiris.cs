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
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace frm_Telefon_Rehberi_Ajanda
{
    public partial class frmGiris : Form
    {

        public class INIKaydet
        {
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

            public INIKaydet(string dosyaYolu)
            {
                DOSYAYOLU = dosyaYolu;
            }
            private string DOSYAYOLU = String.Empty;
            public string Varsayilan { get; set; }
            public string Oku(string bolum, string ayaradi)
            {
                Varsayilan = Varsayilan ?? string.Empty;
                StringBuilder StrBuild = new StringBuilder(256);
                GetPrivateProfileString(bolum, ayaradi, Varsayilan, StrBuild, 255, DOSYAYOLU);
                return StrBuild.ToString();
            }
            public long Yaz(string bolum, string ayaradi, string deger)
            {
                return WritePrivateProfileString(bolum, ayaradi, deger, DOSYAYOLU);
            }
        }
        //nsdjksbfseadljkfnsedlfnbwselnıkf
        //Merhaba Arkadaşlar
        //Merhaba Arkadaşlar
        //Provider=SQLNCLI11;Data Source=DESKTOP-8J65VLQ\MSSQLSERVER2017;Integrated Security=SSPI;Initial Catalog=telefon_rehberi_ajanda
        //Data Source=DESKTOP-8J65VLQ\MSSQLSERVER2017;Initial Catalog=telefon_rehberi_ajanda;Integrated Security=True
        public frmGiris()
        //sss
        {
            InitializeComponent();
        }

        //OdaBilgisayarı
        #region Okul Baglantisi
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8J65VLQ\MSSQLSERVER2017;Initial Catalog=telefon_rehberi_ajanda;Integrated Security=True");
        #endregion
        #region Ev Baglantisi
        SqlConnection con = new SqlConnection(@"Data Source=ODABILGISAYARı;Initial Catalog=telefon_rehberi_ajanda;Integrated Security=True");
        #endregion
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source = "D:\bilişim dersi nesne tabanlı\frmProgramAcma\programlar.mdb"





        private void Form1_Load(object sender, EventArgs e)
        {
            INIKaydet ini = new INIKaydet(Application.StartupPath + @"\Ayarlar.ini");
            pictureBox1.BackgroundImage = Properties.Resources.şifre_yöneticisi2;
            if (File.Exists(Application.StartupPath + @"\Ayarlar.ini"))
            {
                txtKullaniciAdi.Text = Convert.ToString(ini.Oku("KullaniciAdi", "textbox1"));

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
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

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız Veya Sunucuya Bağlanılamıyor Lütfen hizmetlerden sunucuy aktif ediniz.!");
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Şifreyi Gizle";

                txtSifre.PasswordChar = '\0';
            }

            else
            {
                checkBox1.Text = "Şifreyi Göster";

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
            INIKaydet ini = new INIKaydet(Application.StartupPath + @"\Ayarlar.ini");



            ini.Yaz("KullaniciAdi", "textbox1", txtKullaniciAdi.Text);

        }
    }
}
