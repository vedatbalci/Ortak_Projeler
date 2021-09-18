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
    public partial class frmAcilis : Form
    {
        public frmAcilis()
        {
            InitializeComponent();
        }

        private void frmAcilis_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Okul_Şirket_Logosu;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label2.Text = progressBar1.Value.ToString();
            }
            else
            {
                frmGiris frm = new frmGiris();
                frm.Show();
                this.Hide();
                timer1.Enabled = false;
            }
                
        }
    }
}
