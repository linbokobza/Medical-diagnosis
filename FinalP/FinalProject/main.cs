using System;

using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;

namespace FinalProject
{
    public partial class main : Form
    {
        String path = Path.GetFullPath("Client.xlsx");
        _Application excel = new _Excel.Application();
        public static Workbook wb;
        public static Worksheet ws;
        static int num_doctors = 0, i = 0;

        public main()
        {
            InitializeComponent();
            wb = excel.Workbooks.Open(this.path);
            ws = wb.Worksheets[1];
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            addM f2 = new addM();
            f2.ShowDialog(); // Shows addM
        }

        private void btnDiag_Click_1(object sender, EventArgs e)
        {
            diagnosis f2 = new diagnosis();
            f2.ShowDialog();
        }

        private void btnQus_Click(object sender, EventArgs e)
        {
            wb.Close();
            //Form1.wb.Close();
            if (diagnosis.wb != null)
                diagnosis.wb.Close();
            this.Close();
            Environment.Exit(0);
        }
        public static void WriteData(string id, string name, string pass)
        {
            WriteCell(i, 0, id);
            WriteCell(i, 1, name);
            WriteCell(i, 2, pass);
            i++;
            wb.Save();

        }

        //public static void WriteCell(int i, int j, string s)
        //{
        //    try
        //    {
        //        i++;
        //        j++;
        //        ws.Cells[i, j].Value2 = s;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("unable to write to the file");
        //    }

        //}

        //public static int GetRange()
        //{
        //    return wb.Sheets.Count;
        //}

        //public static int GetRangeOfRow()
        //{
        //    try
        //    {
        //        return ws.UsedRange.Rows.Count;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("unable to get the rows of the file");
        //        return -1;
        //    }

        //}
        //public static string Readcell(int i, int j)
        //{
        //    try
        //    {
        //        i++;
        //        j++;
        //        if (ws.Cells[i, j].Value2 != null)
        //            return (ws.Cells[i, j].Value2).ToString();
        //        else return "";
        //    }
        //    catch
        //    {
        //        MessageBox.Show("unable to read the cell");
        //        return null;
        //    }


        public static void WriteCell(int i, int j, string s)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;
        }

        public static int GetRange()
        {
            return wb.Sheets.Count;
        }

        public static int GetRangeOfRow()
        {
            return ws.UsedRange.Rows.Count;
        }

        public static string Readcell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return (ws.Cells[i, j].Value2).ToString();
            else return "";
        }
    }

}
