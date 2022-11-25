using System;
using System.Windows.Forms;
using _Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;

namespace FinalProject
{

    public partial class Form1 : Form
    {
        String path = Path.GetFullPath(@"finalP.xlsx");
        _Application excel = new _Excel.Application();
        public static Workbook wb;
        public static Worksheet ws;
        static int i = 0;
        int flag = -1;

        public Form1()
        {
            InitializeComponent();
            wb = excel.Workbooks.Open(this.path);
            ws = wb.Worksheets[1];

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool logonFlag = false;
            for (int i = 0; i < GetRangeOfRow(); i++)
            {
                if (Readcell(i, 1) == username.Text)
                    if (Readcell(i, 2) == password.Text)
                    {
                        wb.Close();
                        Hide();
                        logonFlag = true;
                        main f2 = new main();
                        f2.ShowDialog(); // Shows main
                    }
            }
            if (logonFlag == false)
                MessageBox.Show("username or password are incorrect ");

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            signIn f2 = new signIn();
            f2.ShowDialog(); // Shows signIn

        }

        public static void WriteData(string id, string name, string pass)
        {
            WriteCell(i, 0, id);
            WriteCell(i, 1, name);
            WriteCell(i, 2, pass);
            i++;
            wb.Save();

        }
    

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

    //    public static void WriteCell(int i, int j, string s)
    //    {
    //        try
    //        {
    //            i++;
    //            j++;
    //            ws.Cells[i, j].Value2 = s;
    //        }
    //        catch 
    //        {
    //           MessageBox.Show("unable to write to the file");
    //        }

    //    }

    //    public static int GetRange()
    //    {
    //        return wb.Sheets.Count;
    //    }

    //    public static int GetRangeOfRow()
    //    {
    //        try
    //        {
    //            return ws.UsedRange.Rows.Count;
    //        }
    //        catch
    //        {
    //            MessageBox.Show("unable to get the rows of the file");
    //            return -1;
    //        }

    //    }
    //    public static string Readcell(int i, int j)
    //    {
    //        try
    //        {
    //            i++;
    //            j++;
    //            if (ws.Cells[i, j].Value2 != null)
    //                return (ws.Cells[i, j].Value2).ToString();
    //            else return "";
    //        }
    //        catch
    //        {
    //            MessageBox.Show("unable to read the cell");
    //            return null;
    //        }

    //    }
    //}

