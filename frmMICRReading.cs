using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GdPicture14;

namespace MICR
{
    public partial class frmMICRReading : Form
    {
        public frmMICRReading()
        {
            InitializeComponent();
        }
         private void MICRReading_Load(object sender, EventArgs e)
        {

            LicenseManager oLicenseManager = new LicenseManager();
            oLicenseManager.RegisterKEY("211883860501001421116010749430779");
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void btnReadMicr_Click(object sender, EventArgs e)
        {
            DetectMICR BankMICR = new DetectMICR();
            Dictionary<string, byte[]> files = new Dictionary<string, byte[]>();
         
            char[] charsToTrim = { 'A', 'B' ,'C','D'};  

            foreach (string fileName in Directory.GetFiles(txtPath.Text))
            {

                string VMicr = BankMICR.DetectMICRLine(fileName);
                Application.DoEvents();
                if (VMicr.Length == 36)
                {
                    int rowId = dgvMICR.Rows.Add();


                    DataGridViewRow row = dgvMICR.Rows[rowId];
                    
                    var AccountNo = VMicr.Substring(18, 13).ToString().Trim(charsToTrim);
                    var Mask = "####-######-##-#";
                   
                  
                    row.Cells[0].Value = VMicr.Substring(13, 4).ToString();
                    row.Cells[1].Value = VMicr.Substring(1,8).ToString();
                    row.Cells[2].Value = WithMask(AccountNo, Mask);
                    row.Cells[3].Value = VMicr.Substring(32, 3).ToString();
                    row.Cells[4].Value = Path.GetFileName(fileName);
                   
                    



                }


            }
            }
        
        public static string WithMask(string s, string mask)
        {
            var slen = Math.Min(s.Length, mask.Length);
            var charArray = new char[mask.Length];
            var sPos = s.Length - 1;
            for (var i = mask.Length - 1; i >= 0 && sPos >= 0; )
                if (mask[i] == '#') charArray[i--] = s[sPos--];
                else
                    charArray[i] = mask[i--];
            return new string(charArray);

        }
    }
}
