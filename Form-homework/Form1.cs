using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_homework
{
    public partial class Form1 : Form
    {   

        public Form1()
        {
            InitializeComponent();
            

        }

        private void btn_nameAndDate_Click(object sender, EventArgs e)
        {
            var name = "Tadas;";
            DateTime date = DateTime.Now;
            richTextBox_nameAndDate.Text = name + " "+ date;
        }

        private void richTextBox_nameAndDate_TextChanged(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------
        private void btn_nprintNameTenTimes_Click(object sender, EventArgs e)
        {
            var name = "Tadas";
            for (int i = 0; i < 10; i++)
            {
                richTextBox_displayNameTenTimes.AppendText($"\r\n{i + 1} {name}");
            }
            
        }

        private void richTextBox_displayNameTenTimes_TextChanged(object sender, EventArgs e)
        {

        }
        //--------------------------------------------------------------------------------------
        private void richTextBox_oddOrEvenNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_oddOrEven_Click(object sender, EventArgs e)
        {
           
            
            
            if (Convert.ToInt32(richTextBox_oddOrEvenNumber.Text) % 2 == 0)
            {
                richTextBox_oddOrEvenNumber.Text = "Number is even";
            }
            else 
            {
                richTextBox_oddOrEvenNumber.Text = "Number is odd";
            }          
        }

        //--------------------------------------------------------------
        
        private void txb_firstSemester_TextChanged(object sender, EventArgs e)
        {
            var semesterOne= Convert.ToInt32(txb_firstSemester.Text);
        }

        private void tbx_secondSemester_TextChanged(object sender, EventArgs e)
        {
            var semesterTwo = tbx_secondSemester.Text;
        }

        private void tbx_thirdSemester_TextChanged(object sender, EventArgs e)
        {
            var semesterThree = tbx_thirdSemester.Text; 
        }
        private void tbx_semesterMedian_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_calculateMedian_Click(object sender, EventArgs e)
        {
            var median = (Convert.ToDouble(((TextBox)txb_firstSemester).Text) + Convert.ToDouble(((TextBox)tbx_secondSemester).Text) + Convert.ToDouble(((TextBox)tbx_thirdSemester).Text)) / 3;
            tbx_semesterMedian.Text = median.ToString();
        }
        //---------------------------------------------------------------------
        private void tbx_celcius_TextChanged(object sender, EventArgs e)
        {
            var temp_celcius = Convert.ToInt32(tbx_celcius.Text);
        }

        private void btn_celciusToFarenheit_Click(object sender, EventArgs e)
        {
            var temp_fahrenheit = (Convert.ToInt32(tbx_celcius.Text) * 9) / 5 + 32;
            tbx_fahrenheit.Text= Convert.ToString(temp_fahrenheit);
        }

        private void tbx_fahrenheit_TextChanged(object sender, EventArgs e)
        {
            
        }
        //----------------------------------------------------------
        private void tbx_weight_TextChanged(object sender, EventArgs e)
        {
            var kgs = Convert.ToInt32(tbx_weight.Text);
        }

        private void tbx_height_TextChanged(object sender, EventArgs e)
        {
            var meters = Convert.ToDouble(tbx_height.Text)/ 100;
        }

        private void btn_kmi_Click(object sender, EventArgs e)
        {
            var kmi = (Convert.ToInt32(tbx_weight.Text) / (Convert.ToDouble(tbx_height.Text) / 100) * (Convert.ToDouble(tbx_height.Text) / 100));
            rch_kmi.Text = kmi.ToString();
        }
        
        private void rch_kmi_TextChanged(object sender, EventArgs e)
        {
            
        }

        //--------------------------------------------------------------------

    }
}
