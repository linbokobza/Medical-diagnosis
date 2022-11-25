using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AddBloodTest : Form
    {
        static int i = 0;
        public AddBloodTest()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            i=main.GetRangeOfRow()-1;
            //personal data
            main.WriteCell(i, 13, WBC1.Text);
            main.WriteCell(i, 14, Neut2.Text + "%");
            main.WriteCell(i, 15, Lymph3.Text + "%");
            main.WriteCell(i, 16, RBC4.Text);
            main.WriteCell(i, 17, HCT5.Text + "%");
            main.WriteCell(i, 18, Urea6.Text );
            main.WriteCell(i, 19, Hb7.Text);
            main.WriteCell(i, 20, Crtn8.Text );
            main.WriteCell(i, 21, Iron9.Text);
            main.WriteCell(i, 22, HDL10.Text);
            main.WriteCell(i, 23, AP11.Text);
            main.wb.Save();
            this.Close();
           
        }
    }
}
