using System;
using System.Linq;
using System.Windows.Forms;
namespace FinalProject

{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
        }

        string errors_username="", errors_password="";
        private void btnSignIn_form_Click_1(object sender, EventArgs e)
        {


            bool passwordFlag = true;
            bool usernameFlag = true;
            int countDigit = 0;
            int countLetters = 0;
            int countSpecial = 0;
            string text;

            //username check
            if (username_form.Text.Length > 8 || username_form.Text.Length < 6)
            {
                usernameFlag = false;
                errors_username += ("between 6 - 8 chars\n");
            }

            countDigit = username_form.Text.Count(Char.IsDigit); //count digits
            if (countDigit > 2)
            {
                usernameFlag = false;
                errors_username += ("max 2 digit!\n");

            }
            else
            {
                
                int exceptCountLetters = username_form.Text.Length - countDigit;
                foreach (var item in username_form.Text)
                {
                    if ((item >= 'A' && item <= 'Z') || (item >= 'a' && item <= 'z'))
                        countLetters++;
                }
                if (!(exceptCountLetters == countLetters))
                {
                    usernameFlag = false;
                    errors_username += ("max 2 digit!\n");

                }

            }
            countDigit = 0;
            countLetters = 0;

            //password check
            if (password_form.Text.Length > 10 || password_form.Text.Length < 8)
            {
                passwordFlag = false;
                errors_password += ("between 8-10 chars\n");

            }

            foreach (var item in password_form.Text)
            {
                if ((item >= 'A' && item <= 'Z') || (item >= 'a' && item <= 'z'))
                    countLetters++;
            }
            countDigit = password_form.Text.Count(Char.IsDigit); //count digits

            string specialChar = @"@\|!#$%&/()=?»«*^&£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (password_form.Text.Contains(item))
                    countSpecial++;
            }

           
            if (countDigit < 1)
            {
                passwordFlag = false;
                errors_password += ("At least one digit \n");
            }
            if (countSpecial < 1)
            {
                passwordFlag = false;
                errors_password += ("At least one special char\n");
            }
            if (countLetters < 1)
            {
                passwordFlag = false;
                errors_password += ("At least one letter \n");
            }
            if (passwordFlag == false || usernameFlag == false)
            {
                MessageBox.Show("user name error:\n" + errors_username + "\npassword error:\n" + errors_password);
                errors_username = "";
                errors_password = "";
            }
            else
            {
                text = "Success! Please log in";
                MessageBox.Show(text);
                int i = Form1.GetRangeOfRow();
                Form1.WriteCell(i, 0, ID_form.Text);
                Form1.WriteCell(i, 1, username_form.Text);
                Form1.WriteCell(i, 2, password_form.Text);
                Form1.wb.Save();
                Form1.wb.Close();
                this.Hide();
                Form1 f2 = new Form1();
                f2.ShowDialog(); // Shows main
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.wb.Close();
            Form1 f2 = new Form1();
            f2.ShowDialog();
            this.Close();
            this.Hide();

        }
    }
; }
