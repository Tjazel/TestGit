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
    public partial class frm_Louis_Bio : MetroForm
    {
        public frm_Louis_Bio()
        {
            InitializeComponent();
        }

        private void frm_Louis_Bio_Load(object sender, EventArgs e)
        {

        }

        private void mbtn_Calculate_Min_Click(object sender, EventArgs e)
        {
            Stat randomNumbers = new Stat();
            try
            {
                string numbers = randomNumbers.GenerateNumbers(Convert.ToInt16(tbxEnterNum.Text));
                int max = randomNumbers.getMax();
                MessageBox.Show("The max value is: " + max + "\nThe values are: " + numbers);
            }
            catch (FormatException exp)
            {
                MessageBox.Show("The number entered must be an integer");
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mtxbEnter_Number_Click(object sender, EventArgs e)
        {

        }
    }
}
