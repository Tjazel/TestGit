using MetroFramework;
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
    public partial class frm_Denieke_Bio : MetroForm
    {
        public frm_Denieke_Bio()
        {
            InitializeComponent();
        }

        private void mbtn_Calculate_Max_Click(object sender, EventArgs e)
        {
            //Call a class with method to generate n random numbers, on which the max will be calculated.
            feature_denieke calculations = new feature_denieke();
            string numbers = calculations.GenerateNumbers(Convert.ToInt16(mtxbEnter_Number.Text));
            int max = calculations.getMax();
            MessageBox.Show("The max value is: " + max + "\nThe values are: " + numbers);
        }
    }
}
