using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Jp_Click(object sender, EventArgs e)
        {
            frm_Jp_Bio frmJp = new frm_Jp_Bio();
            frmJp.Show();
        }

        private void btn_Denieke_Click(object sender, EventArgs e)
        {
            frm_Denieke_Bio frmDenieke = new frm_Denieke_Bio();
            frmDenieke.Show();
             
        }

        private void btn_Louis_Click(object sender, EventArgs e)
        {
            frm_Louis_Bio frmLouis = new frm_Louis_Bio();
            frmLouis.Show();
        }

        private void btn_Braam_Click(object sender, EventArgs e)
        {
            frm_Braam_Bio frmBraam = new frm_Braam_Bio();
            frmBraam.Show();
        }

        private void btn_Tjaart_Click(object sender, EventArgs e)
        {
            frm_Tjaart_Bio frmTjaart = new frm_Tjaart_Bio();
            frmTjaart.Show();
        }

        private void btn_Bernard_Click(object sender, EventArgs e)
        {
            frm_Bernard_Bio frmBernard = new frm_Bernard_Bio();
            frmBernard.Show();
        }
    }
}
