using System;
using System.Windows.Forms;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;

namespace FinalProject
{
    public partial class addM : Form
    {

        bool bloodTestFlag = false;
        bool OkFlag = false;
        bool errFlag = false;
        int i = main.GetRangeOfRow();
        _Application excel = new _Excel.Application();
        public Workbook wb;
        public Worksheet ws;
        string sFileName;
        int iRow, iCol = 2;

        public addM()
        {
            InitializeComponent();
        }

        private void addM_Load(object sender, EventArgs e)
        {

            //TITLE
            main.WriteCell(0, 0, "ID");
            main.WriteCell(0, 1, "NAME");
            main.WriteCell(0, 2, "AGE");
            main.WriteCell(0, 3, "SEX");
            main.WriteCell(0, 4, "WEIGTH");

            main.WriteCell(0, 5, "SMOKE");
            main.WriteCell(0, 6, "EASTERN");
            main.WriteCell(0, 7, "VOMITING");
            main.WriteCell(0, 8, "PREGNANC");
            main.WriteCell(0, 9, "ETHIOPIAN");
            main.WriteCell(0, 10, "MEDICINE");
            main.WriteCell(0, 11, "BLOOD");
            main.WriteCell(0, 12, "FEVER");


            main.WriteCell(0, 13, "WBC");
            main.WriteCell(0, 14, "Neut");
            main.WriteCell(0, 15, "Lymph:");
            main.WriteCell(0, 16, "RBC");
            main.WriteCell(0, 17, "HCT");
            main.WriteCell(0, 18, "Urea");
            main.WriteCell(0, 19, "Hb");
            main.WriteCell(0, 20, "Crtn");
            main.WriteCell(0, 21, "Iron");
            main.WriteCell(0, 22, "HDL");
            main.WriteCell(0, 23, "AP");

            main.WriteCell(0, 24, "Diagnosis");
            main.WriteCell(0, 25, "Recommendation");

            main.wb.Save();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            writePersonalQ();
            bloodTestFlag = true;
            AddBloodTest f2 = new AddBloodTest();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while(checkValid() == false && OkFlag==false)
                writePersonalQ();
            

            if (bloodTestFlag == false)
            {
                MessageBox.Show("Please enter blood test first");
            }

            else if (OkFlag)
            {
                this.Close(); 
            }
            
        }

        public bool checkValid() {
            bool validFlag = false;
            if (ageM.Text.Length > 0)
                if (Convert.ToInt32(ageM.Text) > 120 || Convert.ToInt32(ageM.Text) < 0)
                {
                    MessageBox.Show("Age must to be in range 0-120!");
                    validFlag = true;
                    ageM.Clear();
                   
                }

            if (nameM.Text.Length > 0)
                if ((nameM.Text).Length > 20 || (ageM.Text).Length < 0)
                {
                    MessageBox.Show("Name must to be in range 0-20!");
                    validFlag = true;
                    nameM.Clear();

                }

            return validFlag; // if true - not OK

        }

        public void writePersonalQ()
        {
            //personal data
            main.WriteCell(i, 0, idM.Text);
            main.WriteCell(i, 1, nameM.Text);
            main.WriteCell(i, 2, ageM.Text);
            main.WriteCell(i, 3, sexM.Text);
            main.WriteCell(i, 4, weigthM.Text);

            //additional questions
            if (yes1.Checked == true)
                main.WriteCell(i, 5, "yes");
            else main.WriteCell(i, 5, "no");
            if (yes2.Checked == true)
                main.WriteCell(i, 6, "yes");
            else main.WriteCell(i, 6, "no");
            if (yes3.Checked == true)
                main.WriteCell(i, 7, "yes");
            else main.WriteCell(i, 7, "no");
            if (yes4.Checked == true)
                main.WriteCell(i, 8, "yes");
            else main.WriteCell(i, 8, "no");
            if (yes5.Checked == true)
                main.WriteCell(i, 9, "yes");
            else main.WriteCell(i, 9, "no");
            if (yes6.Checked == true)
                main.WriteCell(i, 10, "yes");
            else main.WriteCell(i, 10, "no");
            if (yes7.Checked == true)
                main.WriteCell(i, 11, "yes");
            else main.WriteCell(i, 11, "no");
            if (yes8.Checked == true)
                main.WriteCell(i, 12, "yes");
            else main.WriteCell(i, 12, "no");
            if(checkValid()==false)
                OkFlag = true;
            main.wb.Save();
        
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //writePersonalQ();
            bloodTestFlag = true;

            try
            {
                openFileDialog1.Title = "Excel File to Edit";
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sFileName = openFileDialog1.FileName;
                }
                if (sFileName.Trim() != "")
                {
                    readExcel(sFileName);
                }
                //bloodTestFlag = true;
               
                MessageBox.Show("Blood tests were successfully added");
            }
            catch
            {
                MessageBox.Show("Please choose correct blood test file");
                //this.Close();
            }
        }

        private void readExcel(string sFile)
        {
            wb = excel.Workbooks.Open(sFile);
            ws = wb.Worksheets[1];
            main.WriteCell(i, 13, ws.Cells[2, 1].Value2.ToString());
            main.WriteCell(i, 14, ws.Cells[2, 2].Value2.ToString() + "%");
            main.WriteCell(i, 15, ws.Cells[2, 3].Value2.ToString() + "%");
            main.WriteCell(i, 16, ws.Cells[2, 4].Value2.ToString());
            main.WriteCell(i, 17, ws.Cells[2, 5].Value2.ToString() + "%");
            main.WriteCell(i, 18, ws.Cells[2, 6].Value2.ToString() );
            main.WriteCell(i, 19, ws.Cells[2, 7].Value2.ToString());
            main.WriteCell(i, 20, ws.Cells[2, 8].Value2.ToString());
            main.WriteCell(i, 21, ws.Cells[2, 9].Value2.ToString());
            main.WriteCell(i, 22, ws.Cells[2, 10].Value2.ToString());
            main.WriteCell(i, 23, ws.Cells[2, 11].Value2.ToString());
            main.wb.Save();
            wb.Close();
            excel.Quit();
        }

    }



}

