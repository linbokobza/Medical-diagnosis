using System;
using System.Windows.Forms;
using System;
using _Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace FinalProject
{
    public partial class diagnosis : Form
    {

        String path = Path.GetFullPath("Diagnosis.xlsx");
        _Application excel = new _Excel.Application();
        public static Workbook wb;
        public static Worksheet ws;

        static int j = 0;
        static int IClient = -1;
        int Anemia = 0, Diet = 0, Bleeding = 0, Hyperlipidemia = 0, Disruption = 0, Viral = 0, Cancer = 0, Infection = 0,
        Blood_disease = 0, Blood_creator = 0, Lung_disease = 0, Smoke = 0, Kidney_disease = 0, Dehydration = 0, Malnutrition = 0, Hematological_disorder = 0,
        Iron_deficiency = 0, Muscle_diseases = 0, Meat_consumption = 0, Iron_poisoning = 0, heart_diseases = 0, diabetes_mellitus = 0, Vitamin_deficiency = 0,
        Use_drugs = 0, Bile_routes = 0, Thyroid = 0;


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.wb.Close();
            main f2 = new main();
            f2.ShowDialog(); // Shows main
            wb.Close();
        }


        public diagnosis()
        {
            InitializeComponent();
            wb = excel.Workbooks.Open(this.path);
            ws = wb.Worksheets[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Flag = false;
            for (int i = 1; i < main.GetRangeOfRow(); i++)
            {
                if (main.Readcell(i, 0) == IDLabel.Text.ToString())
                {
                    IClient = i;
                    Flag = true;
                }

            }

            if (Flag == false) MessageBox.Show("ID doesn't exist ");
            if (IClient != -1)
            {

                //WBC
                if (Convert.ToInt32(main.Readcell(IClient, 2)) >= 18) //ADULT
                {
                    if (Convert.ToInt32(main.Readcell(IClient, 13)) < 4500)
                    {
                        Viral++;
                        Cancer++;
                    }
                    if (Convert.ToInt32(main.Readcell(IClient, 13)) > 11000)
                    {
                        if ((main.Readcell(IClient, 12)) == "yes")
                        {
                            Infection++;
                        }
                        if (Convert.ToInt32(main.Readcell(IClient, 13)) > 15000)
                        {
                            Cancer++;
                            Blood_disease++;
                        }

                    }
                }
                if (Convert.ToInt32(main.Readcell(IClient, 2)) > 4 && Convert.ToInt32(main.Readcell(IClient, 2)) <= 17) //CHILD
                {
                    if (Convert.ToInt32(main.Readcell(IClient, 13)) < 5500)
                    {
                        Viral++;
                        Cancer++;
                    }
                    if (Convert.ToInt32(main.Readcell(IClient, 13)) > 15500)
                    {
                        if ((main.Readcell(IClient, 12)) == "yes")
                        {
                            Infection++;
                        }
                        if (Convert.ToInt32(main.Readcell(IClient, 13)) > 20000)
                        {
                            Cancer++;
                            Blood_disease++;
                        }
                    }
                }
                if (Convert.ToInt32(main.Readcell(IClient, 2)) > 0 && Convert.ToInt32(main.Readcell(IClient, 2)) <= 3) //BABY
                {
                    if (Convert.ToInt32(main.Readcell(IClient, 13)) < 6000)
                    {
                        Viral++;
                        Cancer++;
                    }
                    if (Convert.ToInt32(main.Readcell(IClient, 13)) > 17500)
                    {
                        if ((main.Readcell(IClient, 12)) == "yes")
                        {
                            Infection++;
                        }
                        if (Convert.ToInt32(main.Readcell(IClient, 13)) > 25000)
                        {
                            Cancer++;
                            Blood_disease++;
                        }
                    }
                }

                //neut
                double present;

                if (Convert.ToInt32(main.Readcell(IClient, 2)) >= 18) //ADULT
                {
                    present = 0.28 * 4500;
                    if (Convert.ToDouble(main.Readcell(IClient, 14)) < 0.28)// low
                    {
                        Blood_creator++;
                        Infection++;
                        Cancer++;
                    }

                    present = 0.54 * 11000;
                    if (Convert.ToDouble(main.Readcell(IClient, 14)) > 0.54)//high
                    {
                        Infection++;
                    }
                }
                if (Convert.ToInt32(main.Readcell(IClient, 2)) > 4 && Convert.ToInt32(main.Readcell(IClient, 2)) <= 17) //CHILD
                {
                    present = 0.28 * 5500;
                    if (Convert.ToDouble(main.Readcell(IClient, 14)) < 0.28)// low
                    {
                        Blood_creator++;
                        Infection++;
                        Cancer++;
                    }

                    present = 0.54 * 15500;
                    if (Convert.ToDouble(main.Readcell(IClient, 14)) > 0.54)//high
                    {
                        Infection++;
                    }
                }
                if (Convert.ToInt32(main.Readcell(IClient, 2)) > 0 && Convert.ToInt32(main.Readcell(IClient, 2)) <= 3) //BABY
                {
                    present = 0.28 * 6000;
                    if (Convert.ToDouble(main.Readcell(IClient, 14)) < 0.28)// low
                    {
                        Blood_creator++;
                        Infection++;
                        Cancer++;
                    }

                    present = 0.54 * 17500;
                    if (Convert.ToDouble(main.Readcell(IClient, 14)) > 0.54)//high
                    {
                        Infection++;
                    }
                }

                //Lymph
                if (Convert.ToInt32(main.Readcell(IClient, 2)) >= 18) //ADULT
                {
                    present = 0.36 * 4500;
                    if (Convert.ToDouble(main.Readcell(IClient, 15)) < 0.36)// low
                    {
                        Blood_creator++;
                    }

                    present = 0.52 * 11000;
                    if (Convert.ToDouble(main.Readcell(IClient, 15)) > 0.52)//high
                    {
                        Infection++;
                        Cancer++;
                    }
                }
                if (Convert.ToInt32(main.Readcell(IClient, 2)) > 4 && Convert.ToInt32(main.Readcell(IClient, 2)) <= 17) //CHILD
                {
                    present = 0.36 * 4500;
                    if (Convert.ToDouble(main.Readcell(IClient, 15)) < 0.36)// low
                    {
                        Blood_creator++;

                    }

                    present = 0.52 * 11000;
                    if (Convert.ToDouble(main.Readcell(IClient, 15)) > 0.52)//high
                    {
                        Infection++;
                        Cancer++;
                    }
                }
                if (Convert.ToInt32(main.Readcell(IClient, 2)) > 0 && Convert.ToInt32(main.Readcell(IClient, 2)) <= 3) //BABY
                {
                    present = 0.36 * 4500;
                    if (Convert.ToDouble(main.Readcell(IClient, 15)) < 0.36)// low
                    {
                        Blood_creator++;
                    }

                    present = 0.52 * 11000;
                    if (Convert.ToDouble(main.Readcell(IClient, 15)) > 0.52)//high
                    {
                        Infection++;
                        Cancer++;
                    }
                }

                //RBC
                if (Convert.ToDouble(main.Readcell(IClient, 17)) < 4.5)
                {
                    Bleeding++;
                    Anemia++;
                }
                if (Convert.ToDouble(main.Readcell(IClient, 17)) > 6)
                {
                    if ((main.Readcell(IClient, 5)) == "no")
                    {
                        Blood_creator++;
                        Lung_disease++;
                    }
                    else Smoke++;
                }

                //HCT  
                if (main.Readcell(IClient, 3) == "male")
                {
                    if (Convert.ToDouble(main.Readcell(IClient, 17)) < 0.37) //low
                    {
                        Bleeding++;
                        Anemia++;
                    }
                    if (Convert.ToDouble(main.Readcell(IClient, 17)) > 0.54) //higt
                        if ((main.Readcell(IClient, 5)) == "yes")
                        {
                            Smoke++;
                        }
                   
                }
                if (main.Readcell(IClient, 3) == "female")
                {
                    if (Convert.ToDouble(main.Readcell(IClient, 21)) < 0.33) //low
                    {
                        Bleeding++;
                        Anemia++;
                    }

                    if (Convert.ToDouble(main.Readcell(IClient, 21)) > 0.47) //high
                        if ((main.Readcell(IClient, 5)) == "yes")
                        {
                            Smoke++;
                        }

                }

                //Urea
                if ((main.Readcell(IClient, 6)) == "no")
                {
                    if (Convert.ToDouble(main.Readcell(IClient, 18)) > 43)
                    {
                        Kidney_disease++;
                        Dehydration++;
                        Diet++;
                    }
                    if (Convert.ToDouble(main.Readcell(IClient, 18)) <= 17)
                    {
                        if ((main.Readcell(IClient, 8)) == "no")
                        {
                            Diet++;
                            Kidney_disease++;
                            Dehydration++;
                            Malnutrition++;
                        }
                    }
                }
                if ((main.Readcell(IClient, 6)) == "yes")
                {
                    if (Convert.ToDouble(main.Readcell(IClient, 18)) > 47.3)
                    {
                        Kidney_disease++;
                        Dehydration++;
                        Diet++;
                    }
                    if (Convert.ToDouble(main.Readcell(IClient, 18)) <= 18.7)
                    {
                        if ((main.Readcell(IClient, 8)) == "no")
                        {
                            Diet++;
                            Kidney_disease++;
                            Dehydration++;
                            Malnutrition++;
                        }
                    }
                }
                //

                //HB
                if (main.Readcell(IClient, 3) == "male") //male 
                {
                    if (Convert.ToInt32(main.Readcell(IClient, 2)) > 0 && Convert.ToInt32(main.Readcell(IClient, 2)) <= 17)//child
                        if (Convert.ToDouble(main.Readcell(IClient, 19)) < 11.5 || Convert.ToDouble(main.Readcell(IClient, 19)) > 15.5)
                        {
                            Anemia++;
                            Hematological_disorder++;
                            Iron_deficiency++;
                            Bleeding++;
                        }
                    else if (Convert.ToDouble(main.Readcell(IClient, 19)) < 12 || Convert.ToDouble(main.Readcell(IClient, 19)) > 18)
                    {
                        Anemia++;
                        Hematological_disorder++;
                        Iron_deficiency++;
                        Bleeding++;
                    }
                }

                if (main.Readcell(IClient, 3) == "female") //female
                {
                    if (Convert.ToInt32(main.Readcell(IClient, 2)) > 0 && Convert.ToInt32(main.Readcell(IClient, 2)) <= 17)//child
                        if (Convert.ToDouble(main.Readcell(IClient, 19)) < 11.5 || Convert.ToDouble(main.Readcell(IClient, 19)) > 15.5)
                        {
                            Anemia++;
                            Hematological_disorder++;
                            Iron_deficiency++;
                            Bleeding++;
                        }
                    else if (Convert.ToDouble(main.Readcell(IClient, 19)) < 12 || Convert.ToDouble(main.Readcell(IClient, 19)) > 16)
                    {
                        Anemia++;
                        Hematological_disorder++;
                        Iron_deficiency++;
                        Bleeding++;
                    }
                }


                //Crtn
                if (Convert.ToInt32(main.Readcell(IClient, 2)) > 0 && Convert.ToInt32(main.Readcell(IClient, 2)) <= 2)//baby
                {
                    if (Convert.ToDouble(main.Readcell(IClient, 20)) < 0.2) //low
                    {
                        Malnutrition++;
                    }
                    if (Convert.ToDouble(main.Readcell(IClient, 20)) > 0.5) //high
                    {
                        if (main.Readcell(IClient, 7) == "no")
                        {
                            Kidney_disease++;
                            Muscle_diseases++;
                            Meat_consumption++;
                        }
                    }
                }
                if (Convert.ToInt32(main.Readcell(IClient, 2)) > 3 && Convert.ToInt32(main.Readcell(IClient, 2)) <= 17)//child
                {
                    if (Convert.ToDouble(main.Readcell(IClient, 20)) < 0.5) //low
                    {
                        Malnutrition++;
                    }
                    if (Convert.ToDouble(main.Readcell(IClient, 20)) > 1) //high
                    {
                        if (main.Readcell(IClient, 7) == "no")
                        {
                            Kidney_disease++;
                            Muscle_diseases++;
                            Meat_consumption++;
                        }
                    }
                }
                if (Convert.ToInt32(main.Readcell(IClient, 2)) > 18 && Convert.ToInt32(main.Readcell(IClient, 2)) <= 59)//adult
                {
                    if (Convert.ToDouble(main.Readcell(IClient, 20)) < 0.6) //low
                    {
                        Malnutrition++;
                    }
                    if (Convert.ToDouble(main.Readcell(IClient, 20)) > 1) //high
                    {
                        if (main.Readcell(IClient, 7) == "no")
                        {
                            Kidney_disease++;
                            Muscle_diseases++;
                            Meat_consumption++;
                        }
                    }
                }
                if (Convert.ToInt32(main.Readcell(IClient, 2)) >= 60)//old
                {
                    if (Convert.ToDouble(main.Readcell(IClient, 20)) < 0.6) //low
                    {
                        Malnutrition++;
                    }
                    if (Convert.ToDouble(main.Readcell(IClient, 20)) > 1.2) //high
                    {
                        if (main.Readcell(IClient, 7) == "no")
                        {
                            Kidney_disease++;
                            Muscle_diseases++;
                            Meat_consumption++;
                        }
                    }
                }

                //Iron
                if (main.Readcell(IClient, 3) == "male")
                {
                    if (Convert.ToDouble(main.Readcell(IClient, 21)) < 60) //low
                    {
                        if ((main.Readcell(IClient, 11)) == "no")
                        {
                            Malnutrition++;
                        }
                    }
                    if (Convert.ToDouble(main.Readcell(IClient, 21)) > 160) //higt
                    {
                        Iron_poisoning++;
                    }
                }
                if (main.Readcell(IClient, 3) == "female")
                {
                    if (Convert.ToDouble(main.Readcell(IClient, 21)) < 48) //low
                    {
                        if ((main.Readcell(IClient, 11)) == "no")
                        {
                            if ((main.Readcell(IClient, 8)) == "no")
                            {
                                Malnutrition++;
                            }
                        }
                    }
                    if (Convert.ToDouble(main.Readcell(IClient, 21)) > 128) //higt
                    {
                        Iron_poisoning++;
                    }
                }

                //HDL
                if (main.Readcell(IClient, 9) == "no")
                {
                    if (main.Readcell(IClient, 3) == "male")
                    {
                        if (Convert.ToDouble(main.Readcell(IClient, 22)) < 29) //low
                        {
                            heart_diseases++;
                            Hyperlipidemia++;
                            diabetes_mellitus++;
                        }

                    }
                    if (main.Readcell(IClient, 3) == "female")
                    {
                        if (Convert.ToDouble(main.Readcell(IClient, 22)) < 34) //low
                        {
                            heart_diseases++;
                            Hyperlipidemia++;
                            diabetes_mellitus++;
                        }
                    }
                }
                if (main.Readcell(IClient, 9) == "yes")
                {
                    if (main.Readcell(IClient, 3) == "male")
                    {
                        if (Convert.ToDouble(main.Readcell(IClient, 22)) < 34.8) //low
                        {
                            heart_diseases++;
                            Hyperlipidemia++;
                            diabetes_mellitus++;
                        }

                    }
                    if (main.Readcell(IClient, 3) == "female")
                    {
                        if (Convert.ToDouble(main.Readcell(IClient, 22)) > 40.8) //low
                        {
                            heart_diseases++;
                            Hyperlipidemia++;
                            diabetes_mellitus++;
                        }
                    }
                }

                //AP
                if (main.Readcell(IClient, 6) == "no")
                {
                    if (Convert.ToInt32(main.Readcell(IClient, 23)) < 60)
                    {
                        Vitamin_deficiency++;
                    }
                    if (Convert.ToDouble(main.Readcell(IClient, 23)) > 120)
                    {
                        if ((main.Readcell(IClient, 8)) == "no")
                        {
                            Kidney_disease++;
                            Use_drugs++;
                            Bile_routes++;
                            Thyroid++;
                        }
                    }
                }
                if (main.Readcell(IClient, 6) == "yes")
                {
                    if (Convert.ToDouble(main.Readcell(IClient, 23)) < 30)
                    {
                        Vitamin_deficiency++;
                    }
                    if (Convert.ToDouble(main.Readcell(IClient, 23)) > 90)
                    {
                        if ((main.Readcell(IClient, 8)) == "no")
                        {
                            Kidney_disease++;
                            Use_drugs++;
                            Bile_routes++;
                            Thyroid++;
                        }
                    }
                }

                diagnosisRecommend();
            }
        }

        private void diagnosisRecommend()
        {
            int[] arr ={Anemia, Diet, Bleeding, Hyperlipidemia, Viral , Cancer , Infection ,
            Blood_disease, Blood_creator, Lung_disease, Smoke, Kidney_disease, Dehydration, Malnutrition, Hematological_disorder,
            Iron_deficiency , Muscle_diseases , Meat_consumption , Iron_poisoning , heart_diseases , diabetes_mellitus, Vitamin_deficiency ,
            Use_drugs , Bile_routes, Thyroid };
            string[] names = {"אנמיה","דיאטה","דימום","היפרליפידמיה","מחלה ויראלית","סרטן","זיהום","מחלת דימום","הפרעה ביצירת הדם / תאי דם","מחלת ריאות","עישון","מחלת כליה","התייבשות","תת תזונה","הפרעה המטולוגית",
                "מחסור בברזל","מחלת דם","מחלות שריר","צריכת בשר מוגברת","הרעלת ברזל","מחלות לב","סוכרת מבוגרים","חוסר בוויטמינים","שימוש בתרופות שונות","מחלות בדרכי המרה","פעילות יתר של בלוטת התריס","מחלת כבד" };



            string final_diseases = " ";
            string final_diagnosis = " ";
            int index = 0;

            string[] diseases = getMax(arr, names);

            for (int i = 0; i < diseases.Length; i++)
            {
                for (int j = 1; j < GetRangeOfRow(); j++)
                {
                    if (diseases[i] == diagnosis.Readcell(j, 0))
                    {
                        final_diseases += ("*"+diseases[i] + "\n");
                        final_diagnosis += ("*" + diagnosis.Readcell(j, 1).ToString() + "\n");
                    }
                }
            }

            main.WriteCell(IClient, 24, final_diseases);
            main.WriteCell(IClient, 25, final_diagnosis);
            main.wb.Save();
            diagnosisLabel.Text = main.Readcell(IClient, 24);
            recommendationLabel.Text = main.Readcell(IClient, 25);

        }
    

        public string[] getMax(int[]arr, string[] names)
        {
            int max = arr[0], index=0;
            for (int i = 0; i < arr.Length; i++)// get the most counting disease.
            {
                if (arr[i] > max)
                    max = arr[i];
                
            }
            int countMax = 0;
            for (int i = 0; i < arr.Length; i++)// count diseases
            {
                if (max == arr[i] && max != 0)
                    countMax++;
                
            }
            string[] diseases = new string[countMax];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max == arr[i] && max!=0)
                {
                    diseases[index] = names[i];
                    index++;
                }
            }
            return diseases;
        }


        public static void WriteCell(int i, int j, string s)
        {
            try
            {
                i++;
                j++;
                ws.Cells[i, j].Value2 = s;
            }
            catch
            {
                MessageBox.Show("unable to write to the file");
            }

        }

        public static int GetRange()
        {
            return wb.Sheets.Count;
        }

        public static int GetRangeOfRow()
        {
            try
            {
                return ws.UsedRange.Rows.Count;
            }
            catch
            {
                MessageBox.Show("unable to get the rows of the file");
                return -1;
            }

        }
        public static string Readcell(int i, int j)
        {
            try
            {
                i++;
                j++;
                if (ws.Cells[i, j].Value2 != null)
                    return (ws.Cells[i, j].Value2).ToString();
                else return "";
            }
            catch
            {
                MessageBox.Show("unable to read the cell");
                return null;
            }

        }

        //public static void WriteCell(int i, int j, string s)
        //{
        //    i++;
        //    j++;
        //    ws.Cells[i, j].Value2 = s;
        //}

        //public static int GetRange()
        //{
        //    return wb.Sheets.Count;
        //}

        //public static int GetRangeOfRow()
        //{
        //    return ws.UsedRange.Rows.Count;
        //}

        //public static string Readcell(int i, int j)
        //{
        //    i++;
        //    j++;
        //    if (ws.Cells[i, j].Value2 != null)
        //        return (ws.Cells[i, j].Value2).ToString();
        //    else return "";
        //}
    }
}
