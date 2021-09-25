using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.IO;
using System.Data.SqlClient;

namespace frm_Telefon_Rehberi_Ajanda
{
    public partial class frmAjanda : Form
    {
        public frmAjanda()
        {
            InitializeComponent();
        }
        string silinecekSatir;
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        System.Media.SoundPlayer nuzik = new System.Media.SoundPlayer();
        string tarih, saat;
        #region Okul Baglantisi
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8J65VLQ\MSSQLSERVER2017;Initial Catalog=telefon_rehberi_ajanda;Integrated Security=True");
        #endregion
        #region Ev Baglantisi
        SqlConnection con = new SqlConnection(@"Data Source=ODABILGISAYARı;Initial Catalog=telefon_rehberi_ajanda;Integrated Security=True");
        #endregion
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        void KayitlariListele()
        {
            try
            {

                dataGridView1.Visible = true;
                con.Open();
                DataTable dt = new DataTable();
                da = new SqlDataAdapter("Select * from Ajanda Order By Id,istarihi,iskonusu ASC", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                da.Dispose();
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.ToLongDateString();

             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string File = Properties.Resources.Alarm01.ToString(); 
            //   string File1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Alarm01.wav");
            // File.WriteAllBytes(File1, Properties.Resources.Alarm01);
            //wmp.URL = File1;
            //wmp.controls.play();
            ////string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "<istediğiniz isim>.<dosya uzantısı>");
            //  File.WriteAllBytes(fileName, Properties.Resources.Alarm01);
            //  wmp.URL = ufileName;
            wmp.controls.play(); // Sesi çalıştırma
            wmp.controls.stop(); // Sesi durdurma
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Ajanda (istarihi,iskonusu,issaati) VALUES (@is,@konu,@iş)", con);
            // cmd.Parameters.AddWithValue("@ProgramDosyasi", dataGridView1.CurrentRow.Cells[1].Value.ToString());

            cmd.Parameters.AddWithValue("@is", dateTimePicker1.Text.ToString());            
            cmd.Parameters.AddWithValue("@konu", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@iş", dateTimePicker2.Value.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            //con.Dispose();
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            KayitlariListele();
            con.Close();

            this.Cursor = Cursors.Arrow;

            MessageBox.Show("Yeni İş Kaydı Yapıldı...", "Kaydet İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sor;
                sor = MessageBox.Show(silinecekSatir + " adlı Ajanda kaydını isteğinize emin misiniz ?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (sor == DialogResult.OK)
                {

                    using (var cmd = new SqlCommand(@"delete from Ajanda where Id=@Id", con))
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
                    MessageBox.Show(silinecekSatir + " adlı Ajanda kaydı Silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception hata)
            {
                hata.Message.ToString();

            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click11(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Ajanda Set istarihi=@is,iskonusu=@konu,issaati=@saat where Id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "", con);
            // cmd.Parameters.AddWithValue("@ProgramDosyasi", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@is",dateTimePicker1.Text.ToString());
            cmd.Parameters.AddWithValue("@konu", richTextBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@saat", dateTimePicker2.Value.ToString());
           
            cmd.ExecuteNonQuery();

            con.Close();

            KayitlariListele();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker2.Text = DateTime.Now.ToString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void frmAjanda_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH.mm.ss";
            KayitlariListele();

        }
    }
}
