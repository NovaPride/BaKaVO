using BaKaVO.Windows;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BaKaVO.MVVM.View
{
    public class Ex
    {
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
        public string Col5 { get; set; }
        public string Col6 { get; set; }
        public string Col7 { get; set; }
        public string Col8 { get; set; }
        public string Col9 { get; set; }
        public string Col10 { get; set; }
        public string Col11 { get; set; }
        public string Col12 { get; set; }
        public string Col13 { get; set; }
        public string Col14 { get; set; }
        public string Col15 { get; set; }
        public string Col16 { get; set; }
    }
    public partial class PatientView : UserControl
    {
        Ex[] Xmas;
        bool isDiaryOpen;
        public PatientView()
        {
            InitializeComponent();
            glob.myPatientView = this;
            this.FontSize = 15;
            PreLastRow.Height = new GridLength(10);
            LastRow.Height = new GridLength(0);
            Xmas = new Ex[] {
                new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""},
                new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""},
                new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""},
                new Ex{Col1 = "8", Col2 = "7", Col3 = "6", Col4 = "5", Col5 = "4", Col6 = "3", Col7 = "2", Col8 = "1", Col9 = "1", Col10 = "2", Col11 = "3", Col12 = "4", Col13 = "5", Col14 = "6", Col15 = "7", Col16 = "8"},
                new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""},
                new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""},
                new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""}
            };
            datagrid.ItemsSource = Xmas;
            isDiaryOpen = false;
            Update();
            OneTimeUpdate();
        }
        public void SaveButtonWasClicked()
        {
            Grid1.IsHitTestVisible = glob.issaveclicked;
            Grid2.IsHitTestVisible = glob.issaveclicked;
            Grid3.IsHitTestVisible = glob.issaveclicked;
            if (!glob.issaveclicked)
            { 
                Save();
                PreLastRow.Height = new GridLength(10);
                LastRow.Height = new GridLength(0);
                
                DiaryDataGrid.IsHitTestVisible = true;
            }
        }
        private void Save()//фунция обновления данных в бд
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(glob.connectionstring))
                {
                    //база
                    string save = "UPDATE Patient SET " +
                        "Fullname_Patient = N'" + FullnameBox.Text +
                        "', PhoneNumber_Patient = N'" + PhoneNumberBox.Text +
                        "', Domicile_Patient = N'" + DomicileBox.Text +
                        "', BirthDate_Patient = N'" + MonthToDay(BirthDate.SelectedDate.Value.Date.ToShortDateString()) +
                        "', Bite_Patient = " + BiteCBox.SelectedIndex.ToString() +
                        ", Comment_Patient = N'" + CommentBox.Text +
                        "' WHERE ID_Patient = " + glob.pat_id.ToString();
                    conn.Open();
                    SqlCommand savecom = new SqlCommand(save, conn);
                    savecom.ExecuteNonQuery();
                    glob.patientdb.SaveChanges();
                    conn.Close();

                    //sql = "SELECT ID_Dentist_Dia FROM Diary WHERE ID_Patient_Dia = " + id.ToString();
                    // int[] den_id = new int[DiaryDataGrid.Items.Count];
                    //таблица зубов
                    int i = 0;
                    int j = 0;
                    conn.Open();
                    string sql = "SELECT ID_Exam FROM Exam WHERE ID_Patient_Exa = " + glob.pat_id.ToString();
                    SqlCommand com = new SqlCommand(sql, conn);
                    int[] ex_id = new int[6];
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ex_id[j] = reader.GetInt32(0);
                            j++;
                        }
                    }
                    conn.Close();
                    j = 0;
                    foreach (Ex elem in Xmas)
                    {
                        i++;
                        if (i == 4) { continue; }
                        j++;
                        // MessageBox.Show(num.ToString() + "_" + bit.ToString() + "_" + ex_id[j - 1].ToString());
                        save = "UPDATE Exam SET " +
                            "Left_First_Exam = N'" + elem.Col8 +
                            "', Left_Second_Exam = N'" + elem.Col7 +
                            "', Left_Third_Exam = N'" + elem.Col6 +
                            "', Left_Fourth_Exam = N'" + elem.Col5 +
                            "', Left_Fifth_Exam = N'" + elem.Col4 +
                            "', Left_Sixth_Exam = N'" + elem.Col3 +
                            "', Left_Seventh_Exam = N'" + elem.Col2 +
                            "', Left_Eighth_Exam = N'" + elem.Col1 +
                            "', Right_First_Exam = N'" + elem.Col9 +
                            "', Right_Second_Exam = N'" + elem.Col10 +
                            "', Right_Third_Exam = N'" + elem.Col11 +
                            "', Right_Fourth_Exam = N'" + elem.Col12 +
                            "', Right_Fifth_Exam = N'" + elem.Col13 +
                            "', Right_Sixth_Exam = N'" + elem.Col14 +
                            "', Right_Seventh_Exam = N'" + elem.Col15 +
                            "', Right_Eighth_Exam = N'" + elem.Col16 +
                            "' WHERE ID_Exam = " + ex_id[j - 1].ToString();
                        conn.Open();
                        savecom = new SqlCommand(save, conn);
                        savecom.ExecuteNonQuery();
                        glob.examdb.SaveChanges();
                        conn.Close();

                    }

                    Update();
                }
                //MessageBox.Show(MonthToDay(BirthDate.SelectedDate.Value.Date.ToShortDateString()));
            }
            catch { MessageBox.Show("Введите корректную информацию! 4"); return; }
        }
        private void Update()
        {
            using (SqlConnection conn = new SqlConnection(glob.connectionstring))
            {
                //база
                conn.Open();
                string sql = "SELECT Fullname_Patient, PhoneNumber_Patient, Domicile_Patient, BirthDate_Patient, Bite_Patient, Comment_Patient FROM Patient WHERE ID_Patient = " + glob.pat_id.ToString();
                SqlCommand com = new SqlCommand(sql, conn);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FullnameBox.Text = reader.GetString(0);
                        PhoneNumberBox.Text = reader.GetString(1);
                        DomicileBox.Text = reader.GetString(2);
                        BirthDate.SelectedDate = reader.GetDateTime(3);
                        BiteCBox.SelectedIndex = reader.GetByte(4);
                        CommentBox.Text = reader.GetString(5);
                    }
                }
                conn.Close();

                //дневник
                string reg = "SELECT ID_Diary as idD, CONCAT(CONVERT(varchar(10), Date_Diary, 104), '  ' , CONVERT(varchar(5), Date_Diary, 8)) as dateD, Complaint_Diary as appealD, Diagnosis_Diary as dignosisD, " +
                    "Treatment_Diary as therapyD, Price_Diary as priceD, Recomendation_Diary as recommendationsD, " +
                    "Dentist.Fullname_Dentist as doctorD FROM Diary " +
                    "JOIN Patient ON ID_Patient_Dia = Patient.ID_Patient " +
                    "JOIN Dentist ON ID_Dentist_Dia = Dentist.ID_Dentist " +
                    "WHERE ID_Patient = " + glob.pat_id.ToString();
                glob.adapt = new SqlDataAdapter(reg, conn);
                conn.Open();
                glob.dt = new DataTable();
                glob.adapt.Fill(glob.dt);
                DiaryDataGrid.ItemsSource = glob.dt.DefaultView;
                conn.Close();

                //таблица зубов
                Xmas = new Ex[] {
                        new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""},
                        new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""},
                        new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""},
                        new Ex{Col1 = "8", Col2 = "7", Col3 = "6", Col4 = "5", Col5 = "4", Col6 = "3", Col7 = "2", Col8 = "1", Col9 = "1", Col10 = "2", Col11 = "3", Col12 = "4", Col13 = "5", Col14 = "6", Col15 = "7", Col16 = "8"},
                        new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""},
                        new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""},
                        new Ex{Col1 = "", Col2 = "", Col3 = "", Col4 = "", Col5 = "", Col6 = "", Col7 = "", Col8 = "", Col9 = "", Col10 = "", Col11 = "", Col12 = "", Col13 = "", Col14 = "", Col15 = "", Col16 = ""}
                    };
                conn.Open();
                sql = "SELECT Num_Exam, Bit_Exam, " +
                    "Left_First_Exam, Left_Second_Exam, Left_Third_Exam, Left_Fourth_Exam, " +
                    "Left_Fifth_Exam, Left_Sixth_Exam, Left_Seventh_Exam, Left_Eighth_Exam, " +
                    "Right_First_Exam, Right_Second_Exam, Right_Third_Exam, Right_Fourth_Exam, " +
                    "Right_Fifth_Exam, Right_Sixth_Exam, Right_Seventh_Exam, Right_Eighth_Exam " +
                    "FROM Exam " +
                    "JOIN Patient ON ID_Patient_Exa = Patient.ID_Patient " +
                    "WHERE ID_Patient = " + glob.pat_id.ToString();
                com = new SqlCommand(sql, conn);
                int tempnum = -1;
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.GetBoolean(1))
                        {
                            if (reader.GetByte(0) == 1) { tempnum = 4; }
                            if (reader.GetByte(0) == 2) { tempnum = 5; }
                            if (reader.GetByte(0) == 3) { tempnum = 6; }
                        }
                        else
                        {
                            if (reader.GetByte(0) == 1) { tempnum = 2; }
                            if (reader.GetByte(0) == 2) { tempnum = 1; }
                            if (reader.GetByte(0) == 3) { tempnum = 0; }
                        }

                        Xmas[tempnum] = new Ex
                        {
                            Col1 = reader.GetString(9),
                            Col2 = reader.GetString(8),
                            Col3 = reader.GetString(7),
                            Col4 = reader.GetString(6),
                            Col5 = reader.GetString(5),
                            Col6 = reader.GetString(4),
                            Col7 = reader.GetString(3),
                            Col8 = reader.GetString(2),
                            Col9 = reader.GetString(10),
                            Col10 = reader.GetString(11),
                            Col11 = reader.GetString(12),
                            Col12 = reader.GetString(13),
                            Col13 = reader.GetString(14),
                            Col14 = reader.GetString(15),
                            Col15 = reader.GetString(16),
                            Col16 = reader.GetString(17)
                        };
                    }
                    datagrid.ItemsSource = Xmas;
                }
                conn.Close();
            }
        }
        private void OneTimeUpdate()
        {
            FullnameBox.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteCommand));//важно

            using (SqlConnection conn = new SqlConnection(glob.connectionstring))
            {
                conn.Open();
                string sql = "SELECT ID_Dentist, Fullname_Dentist FROM Dentist";
                SqlCommand com = new SqlCommand(sql, conn);
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DentistCBox.Items.Insert(reader.GetInt32(0) - 1, reader.GetString(1));
                    }
                }
                conn.Close();
            }
        }
        private void DiaryDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try { 
                if (glob.issaveclicked)
                {
               
                    DataRowView h = DiaryDataGrid.SelectedItems[0] as DataRowView;
                    PreLastRow.Height = new GridLength(0);
                    LastRow.Height = new GridLength(75);

                    DiaryDataGrid.IsHitTestVisible = false;

                    isDiaryOpen = true;
                }
                else
                {
                    PreLastRow.Height = new GridLength(10);
                    LastRow.Height = new GridLength(0);

                    DiaryDataGrid.IsHitTestVisible = true;

                    isDiaryOpen = false;
                }
            }
            catch { }
        }
        private void DiaryDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)//функция обновления полей для заполнения при выделения строки в таблице
        {
            try
            {
                if (DiaryDataGrid.SelectedItems.Count <= 0) { return; }
                using (SqlConnection conn = new SqlConnection(glob.connectionstring))
                {
                    DataRowView h = DiaryDataGrid.SelectedItems[0] as DataRowView;
                    conn.Open();
                    string sql = "SELECT CONVERT(varchar(10), Date_Diary, 104), CONVERT(varchar(5), Date_Diary, 8), Complaint_Diary, Diagnosis_Diary, Treatment_Diary, Recomendation_Diary, Price_Diary, ID_Dentist_Dia FROM Diary WHERE ID_Diary = " + h.Row[0].ToString();
                    SqlCommand com = new SqlCommand(sql, conn);
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VisitDateDate.Text = reader.GetString(0);
                            VisitTimeBox.Text = reader.GetString(1);
                            ComplaintBox.Text = reader.GetString(2);
                            DiagnosisBox.Text = reader.GetString(3);
                            TherapyBox.Text = reader.GetString(4);
                            RecommendationBox.Text = reader.GetString(5);
                            PriceBox.Text = reader.GetString(5);
                            DentistCBox.SelectedIndex = reader.GetInt32(7) - 1;
                        }
                    }
                    conn.Close();
                }
            }
            catch { MessageBox.Show("Введите корректную информацию! 2"); return; }
        }
        private void DiarySave_Click(object sender, RoutedEventArgs e)//фунция обновления данных в бд
        {
            try 
            { 
                if (isDiaryOpen)
                {
                    isDiaryOpen = false;
                    PreLastRow.Height = new GridLength(10);
                    LastRow.Height = new GridLength(0);

                    DiaryDataGrid.IsHitTestVisible = true;
                }
                else { return; }
                using (SqlConnection conn = new SqlConnection(glob.connectionstring))
                {
                    DataRowView h = DiaryDataGrid.SelectedItems[0] as DataRowView;
                    string save = "UPDATE Diary SET " +
                        "Date_Diary = N'" + MonthToDay(VisitDateDate.Text) + " " + VisitTimeBox.Text +
                        "', Complaint_Diary = N'" + ComplaintBox.Text +
                        "',  Diagnosis_Diary = N'" + DiagnosisBox.Text +
                        "',  Treatment_Diary = N'" + TherapyBox.Text +
                        "',  Recomendation_Diary = N'" + RecommendationBox.Text +
                        "',  Price_Diary = N'" + PriceBox.Text +
                        "', ID_Dentist_Dia = " + (DentistCBox.SelectedIndex + 1).ToString() +
                        " WHERE ID_Diary = " + h.Row[0].ToString(); ;
                    conn.Open();
                    SqlCommand savecom = new SqlCommand(save, conn);
                    savecom.ExecuteNonQuery();
                    glob.diarydb.SaveChanges();
                    conn.Close();

                }
                Save();
                Update();
            }
            catch { MessageBox.Show("Введите корректную информацию! 3"); return; }
        }
        private void PatientView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //Console.WriteLine(this.ActualWidth.ToString());
            if (this.ActualWidth <= 1425) { 
                //this.FontSize = 15;
                FirstColumn.Width = new GridLength(0); 
            }
            if (this.ActualWidth > 1425) { 
                //this.FontSize = 16; 
                FirstColumn.Width = new GridLength(290); 
            }
            //if (this.ActualWidth > 1850) { 
            //    this.FontSize = 17;
            //}
            //if (this.ActualWidth > 2400) { 
            //    this.FontSize = 18; 
            //}
        }
        private string MonthToDay(string date)
        {
            string[] words = date.Split('.');
            return words[1] + '.' + words[0] + '.' + words[2];
        }
        public void OnPasteCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Ручками пиши");
        }

        //private void TextBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    Console.WriteLine(e.Key.ToString().ToLower());
        //    //string lat = "qwertyuiopasdfghjklzxcvbnm";
        //    //string cyr = "ёйцукенгшўзхифывапролджэячсмітьбюїєґщъ";
        //    string al = "qwertyuiopasdfghjklzxcvbnmёйцукенгшўзхифывапролджэячсмітьбюїєґщъ";
        //    string key = e.Key.ToString().ToLower();
        //    Console.WriteLine(key);

        //    if (!al.Contains(key))
        //    {
        //        if (key == "capital" || 
        //            key == "leftshift" || 
        //            key == "leftctrl" || 
        //            key == "leftwin" ||
        //            key == "rightshift" ||
        //            key == "rightctrl" ||
        //            key == "rightwin" ||
        //            key == "system" || 
        //            key == "tab" || 
        //            key == "escape" ||
        //            key == "return" ||
        //            key == "f1" ||
        //            key == "f2" ||
        //            key == "f3" ||
        //            key == "f4" ||
        //            key == "f5" ||
        //            key == "f6" ||
        //            key == "f7" ||
        //            key == "f8" ||
        //            key == "f9" ||
        //            key == "f10" ||
        //            key == "f11" ||
        //            key == "f12" ) { return; }

        //        MessageBox.Show("Данный символ запрещен!");
        //        e.Handled = true;
        //        return;
        //    }

        //}
    }
}
