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
            Stat dataset = new Stat();
            int max = 0;
            double spread = 0;
            string numbers = "";

           
            try
            {
                int n = Convert.ToInt16(tbxEnterNum.Text);
                TestNumber test = new TestNumber();
                if (test.testNum(n))
                {
                    numbers = dataset.GenerateNumbers(Convert.ToInt16(n));
                    max = dataset.getMax();
                    spread = dataset.getDeviation();
                    spread = Math.Round(spread, 2);
                    string success = "The max value is: " + max + "\nThe spread is:" + spread + "\nThe values are: " + numbers;
                    
                    MessageBox.Show(success);
                }
                else
                {
                    string fail = "Incorrect: Value must be between 5 and 20";
                    MessageBox.Show(fail);
                }
                    
                
                   
            }
            catch (FormatException exp)
            {
                string fail = "Incorrect Format: Integers only";
                MessageBox.Show(fail);
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
