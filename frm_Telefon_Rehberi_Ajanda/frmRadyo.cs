using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_Telefon_Rehberi_Ajanda
{
    public partial class frmRadyo : Form
    {
        public frmRadyo()
        {
            InitializeComponent();
        }

        private void frmRadyo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (radioButton2.Checked == true)
            {
                axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/30/";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (radioButton3.Checked == true)
            {
                axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/25/";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (radioButton4.Checked == true)
            {
                axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/33/;?type=http&nocache=23345";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (radioButton4.Checked == true)
            {
                axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/33/;?type=http&nocache=23345";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (radioButton5.Checked == true)
            {
                axWindowsMediaPlayer1.URL = "http://yayin1.yayindakiler.com:3016/renk";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Uyarı", "Lütfen bir radyo kanalı seçiniz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
