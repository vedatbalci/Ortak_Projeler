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
using System.Xml;
using System.Xml.Linq;

namespace frm_Telefon_Rehberi_Ajanda
{
    public partial class frmtelefonrehberi : Form
    {
        public frmtelefonrehberi()
        {
            InitializeComponent();
        }
        private void Ara()
        {
            //try
            //{
                if (rdbİsim.Checked)
                {
                    con.Open();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da = new SqlDataAdapter("Select * from Kisiler Where ad LIKE '%" + txtAra.Text + "%'", con);

                    dataGridView1.DataSource = dt;
                    da.Fill(dt);
                    da.Dispose();
                    con.Close();
                }
                if (rdbSoyad.Checked)
                {
                    con.Open();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da = new SqlDataAdapter("Select * from Kisiler Where soyad LIKE '%" + txtAra.Text + "%'", con);

                    dataGridView1.DataSource = dt;
                    da.Fill(dt);
                    da.Dispose();
                    con.Close();
                }
                if (rdbtelefon.Checked)
                {
                    con.Open();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da = new SqlDataAdapter("Select * from Kisiler Where telefonno LIKE '%" + txtAra.Text + "%'", con);

                    dataGridView1.DataSource = dt;
                    da.Fill(dt);
                    da.Dispose();
                    con.Close();
                }
                if (rdbİs.Checked)
                {
                    con.Open();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da = new SqlDataAdapter("Select * from Kisiler Where isno LIKE '%" + txtAra.Text + "%'", con);

                    dataGridView1.DataSource = dt;
                    da.Fill(dt);
                    da.Dispose();
                    con.Close();
                }
                if (rdbDogum.Checked)
                {
                    con.Open();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da = new SqlDataAdapter("Select * from Kisiler Where dogumtarihi LIKE '%" + txtAra.Text + "%'", con);

                    dataGridView1.DataSource = dt;
                    da.Fill(dt);
                    da.Dispose();
                    con.Close();
                }
                if (rdbCinsiyet.Checked)
                {
                    con.Open();
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da = new SqlDataAdapter("Select * from Kisiler Where Cinsiyet LIKE '%" + txtAra.Text + "%'", con);

                    dataGridView1.DataSource = dt;
                    da.Fill(dt);
                    da.Dispose();
                    con.Close();
                }


              
            //}
            //catch (Exception)
            //{
            //    // MessageBox.Show("Uyarı","Lütfen Program_Ara nın yanindaki yazı yazma yerine sağ tıklayıp bir ayar seçiniz !!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //}
        }
        XmlDocument xdoc = new XmlDocument();
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8J65VLQ\MSSQLSERVER2017;Initial Catalog=telefon_rehberi_ajanda;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        string hava = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
        private string silinecekSatir;
        #region Okul Baglantisi
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8J65VLQ\MSSQLSERVER2017;Initial Catalog=telefon_rehberi_ajanda;Integrated Security=True");
        #endregion
        #region Ev Baglantisi
        SqlConnection con = new SqlConnection(@"Data Source=ODABILGISAYARı;Initial Catalog=telefon_rehberi_ajanda;Integrated Security=True");
        #endregion
        void KayitlariListele()
        {
            try
            {
                listBox1.Visible = false;
                dataGridView1.Visible = true;
                //dataGridView1.Rows.Clear();
                //dataGridView1.Columns.Clear();



                con.Open();
                DataTable dt = new DataTable();
                da = new SqlDataAdapter("Select * from Kisiler Order By Id,ad,soyad,telefonno,isno,dogumtarihi,Cinsiyet ASC", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                da.Dispose();
                con.Close();
            }
            catch (Exception)
            { }
        }
        private void frmtelefonrehberi_Load(object sender, EventArgs e)
        {
            KayitlariListele();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAJanda_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiris frm = new frmGiris();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Visible = false;
                listBox1.Visible = true;

                XmlDocument xml = new XmlDocument();
                xml.Load(hava);
                XmlElement document = xml.DocumentElement;
                XmlNodeList nodeList = document.SelectNodes("sehirler");
                CreateParams create = new CreateParams();

                foreach (XmlNode node in nodeList)
                {
                    string ili = node["ili"].InnerText;
                    string durum = node["Durum"].InnerText;
                    string sicaklik = node["Mak"].InnerText;
                    DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();

                    row.Cells[0].Value = ili;
                    row.Cells[1].Value = durum;
                    row.Cells[2].Value = sicaklik;
                    dataGridView2.Rows.Add();
                    //    }
                    //}
                    //catch (Exception)
                    //{
                    //    MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Ediniz");
                    //}
                    string url = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
                    xdoc.Load(url);
                    XmlNodeList secilenil = xdoc.DocumentElement.SelectNodes("sehirler");
                    foreach (XmlNode istanbul in secilenil)
                    {
                        string ili1 = istanbul.SelectSingleNode("ili").InnerText;
                        if (ili == "HATAY")
                        {
                            string Durum = istanbul.SelectSingleNode("Durum").InnerText;
                            string Mak = istanbul.SelectSingleNode("Mak").InnerText;
                            listBox1.Items.Add(ili1);
                            listBox1.Items.Add(Durum);
                            listBox1.Items.Add(Mak);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uyarı","Lütfen internet bağlantınızı kontrol ediniz !!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBox1.Visible = false;
                dataGridView1.Visible = true;
                KayitlariListele();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmtelefonrehberi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                KayitlariListele();

            }
        }

        private void button1_Cli(object sender, EventArgs e)
        {
            KayitlariListele();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Kisiler Set ad=@ad,soyad=@soyad,telefonno=@no,isno=@is,dogumtarihi=@tarih,Cinsiyet=@si where Id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "", con);
                // cmd.Parameters.AddWithValue("@ProgramDosyasi", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@ad", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@soyad", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@no", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                cmd.Parameters.AddWithValue("@is", dataGridView1.CurrentRow.Cells[4].Value.ToString());
                cmd.Parameters.AddWithValue("@tarih", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                cmd.Parameters.AddWithValue("@si", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                cmd.ExecuteNonQuery();

                con.Close();
                //con.Dispose();
                KayitlariListele();
                con.Close();

                //MessageBox.Show("Kişi Güncellendi", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception hata)
            {

                MessageBox.Show("Lütfen Elle Yeni Kişi Ekleme butonuna tıklayınız !!!", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click1(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Kisiler (ad,soyad,telefonno,isno,dogumtarihi,Cinsiyet) VALUES (@ad,@soyad,@telno,@is,@dgmtarihi,@cins)", con);
            // cmd.Parameters.AddWithValue("@ProgramDosyasi", dataGridView1.CurrentRow.Cells[1].Value.ToString());

            cmd.Parameters.AddWithValue("@ad", "");
            cmd.Parameters.AddWithValue("@soyad", "");
            cmd.Parameters.AddWithValue("@telno", "");
            cmd.Parameters.AddWithValue("@is", "");
            cmd.Parameters.AddWithValue("@dgmtarihi", "");
            cmd.Parameters.AddWithValue("@cins", "");
            cmd.ExecuteNonQuery();
            con.Close();
            //con.Dispose();
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            KayitlariListele();
            con.Close();

            this.Cursor = Cursors.Arrow;

            MessageBox.Show("Yeni Kişi Kaydı Yapıldı...", "Kaydet İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception hata)
            //{
            //    MessageBox.Show(hata.Message);
            //}
        }

        private void button1_Clidsdasdas(object sender, EventArgs e)
        {
            try
            {
                DialogResult sor;
                sor = MessageBox.Show(silinecekSatir + "isimli Kisiler slimek isteğinize emin misiniz ?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (sor == DialogResult.OK)
                {

                    using (var cmd = new SqlCommand(@"delete from Kisiler where Id=@Id", con))
                    {
                        cmd.Parameters.Add("@Id", SqlDbType.Int);

                        con.Open();

                        for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                        {
                            cmd.Parameters["@Id"].Value = dataGridView1.SelectedRows[i].Cells["Id"].Value;
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                    }

                    KayitlariListele();
                    MessageBox.Show(silinecekSatir + " İsimli kişi Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception hata)
            {
                hata.Message.ToString();

            }
        }

        private void button1_Clidsdasdassdasd(object sender, EventArgs e)
        {
            frmRadyo frm = new frmRadyo();
            frm.Show();
        }

        private void button1_Clidsdasdassdasdsadas(object sender, EventArgs e)
        {
            Ara();
        }

        private void btnAJanda_Click222(object sender, EventArgs e)
        {
            frmAjanda frm = new frmAjanda();
            frm.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToLongTimeString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmtelefonrehberi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
