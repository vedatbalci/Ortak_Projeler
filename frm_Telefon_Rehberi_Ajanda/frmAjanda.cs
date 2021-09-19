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

namespace frm_Telefon_Rehberi_Ajanda
{
    public partial class frmAjanda : Form
    {
        public frmAjanda()
        {
            InitializeComponent();
        }
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        System.Media.SoundPlayer nuzik = new System.Media.SoundPlayer();
        string tarih, saat;

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
            string File1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Alarm01.wav");
           // File.WriteAllBytes(File1, Properties.Resources.Alarm01);
            wmp.URL = File1;
            wmp.controls.play();
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "<istediğiniz isim>.<dosya uzantısı>");
          //  File.WriteAllBytes(fileName, Properties.Resources.Alarm01);
            wmp.URL = fileName;
            wmp.controls.play(); // Sesi çalıştırma
            wmp.controls.stop(); // Sesi durdurma
        }

        private void frmAjanda_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH.mm.ss";
            

        }
    }
}
