﻿using System;
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
            if (radioButton1.Checked==true)
            {
                
                
            }
            else
            {
                MessageBox.Show("Uyarı", "Lütfen bir radyo kanalı seçiniz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            axWindowsMediaPlayer1.URL = "https://www.harsitvadisi.com/guncel-radyo-url-adresleri.html#:~:text=https%3A//trkvz-radyolar.ercdn.net/ahaberradyo/playlist.m3u8";
            axWindowsMediaPlayer1.Ctlcontrols.play();
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
    }
}
