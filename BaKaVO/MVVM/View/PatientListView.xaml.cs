using BaKaVO.Windows;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BaKaVO.MVVM.ViewModel;
using BaKaVO.Core;
using BaKaVO.Classes;

namespace BaKaVO.MVVM.View
{
    public partial class PatientListView : UserControl
    {
        int curr_patlistpage;
        int patientperpage;
        int patientcount;
        string search_sel;
        public PatientListView()
        {
            curr_patlistpage = 1;
            patientperpage = 25;
            InitializeComponent();
            glob.myPatientListView = this;
            this.FontSize = 15;
            search_sel = "";
            //OneTimeUpdate();
            Update();
        }

      

        public void SaveButtonWasClicked() 
        {
            if (glob.issaveclicked)
            {
             
            }
            else {
               
            }
        }

        //private void OneTimeUpdate() {

        //    using (SqlConnection conn = new SqlConnection(glob.connectionstring))
        //    {
        //        conn.Open();
        //        string sql = "SELECT COUNT(DISTINCT ID_Patient) FROM Patient";
        //        SqlCommand com = new SqlCommand(sql, conn);
        //        using (SqlDataReader reader = com.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                patientcount = reader.GetInt32(0);
        //            }
        //        }
        //        conn.Close();
        //    }
        //}
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            search_sel = SearchBox.Text;
            Update();
        }
        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            search_sel = SearchBox.Text;
            Update();
        }

        private void Update()
        {
            
                using (SqlConnection conn = new SqlConnection(glob.connectionstring))
                {
                    string reg = $"SELECT ID_Patient as IDP, Fullname_Patient as NameP, " +
                        $"PhoneNumber_Patient as PhoneP, CONVERT(varchar(10), BirthDate_Patient, 104) as BirthP, " +
                        $"SUBSTRING(Comment_Patient, 1, 200) as CommentP, " +
                        $"(SELECT CONVERT(varchar(10), max(Date_Diary), 104) FROM Diary WHERE ID_Patient_Dia = ID_Patient) as LastVisitP " +
                        $"FROM Patient " +
                        $"WHERE Fullname_Patient LIKE N'%{search_sel}%'" +
                        $"ORDER BY ID_Patient " +
                        $"OFFSET {(curr_patlistpage - 1) * patientperpage} ROWS " +
                        $"FETCH NEXT {patientperpage} ROWS ONLY";
                    glob.adapt = new SqlDataAdapter(reg, conn);
                    conn.Open();
                    glob.dt = new System.Data.DataTable();
                    glob.adapt.Fill(glob.dt);
                    PatientListDataGrid.ItemsSource = glob.dt.DefaultView;

                    string sql = "SELECT COUNT(DISTINCT ID_Patient) FROM Patient";
                    SqlCommand com = new SqlCommand(sql, conn);
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patientcount = reader.GetInt32(0);
                        }
                    }
                    int temp = patientcount > curr_patlistpage * patientperpage ? curr_patlistpage * patientperpage : patientcount;
                    PageSelectBlock.Text = $"{1 + ((curr_patlistpage - 1) * patientperpage)}-{temp} из {patientcount}";
                    conn.Close();
                }
           
        }

        private void PatientListDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)//функция обновления полей для заполнения при выделения строки в таблице
        {
            try
            {
                DataRowView h = PatientListDataGrid.SelectedItems[0] as DataRowView;
                glob.pat_id = Convert.ToInt32(h.Row[0]);
            }
            catch { }
        }
        private void PatientListDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (!glob.issaveclicked) { glob.myBase.switchView(2); }
        }
        private void PatientListView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.ActualWidth <= 1300) { this.FontSize = 15; }
            if (this.ActualWidth > 1300) { this.FontSize = 16; }
            if (this.ActualWidth > 1850) { this.FontSize = 17; }
            if (this.ActualWidth > 2400) { this.FontSize = 18; }
        }
        private void FirstPage_Click(object sender, RoutedEventArgs e)
        {
            curr_patlistpage = 1;
            Update();
        }
        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            if (curr_patlistpage > 1) { curr_patlistpage--; }
            Update();
        }
        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            if (patientcount > curr_patlistpage * patientperpage) { curr_patlistpage++; }
            Update();
        }
        private void LastPage_Click(object sender, RoutedEventArgs e)
        {
            int temp = (patientcount / patientperpage);
            if (patientcount > temp * patientperpage) { temp++; }
            curr_patlistpage = temp ;
            Update();
        }
        private void AddNewPatient_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(glob.connectionstring))
                {
                    SqlCommand com;
                    int lastPID = -1;

                    conn.Open();

                    //insert patient
                    string newPat = $"INSERT INTO Patient (Fullname_Patient, Domicile_Patient, PhoneNumber_Patient, Bite_Patient, Comment_Patient) VALUES " +
                        $"(N'', N'', N'375 (29) ___-__-__', 1, N''); ";
                    com = new SqlCommand(newPat, conn);
                    com.ExecuteNonQuery();
                    glob.patientdb.SaveChanges();

                    //find last patient id
                    string sqlLastPID = "SELECT MAX(ID_Patient) FROM Patient";
                    com = new SqlCommand(sqlLastPID, conn);
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lastPID = reader.GetInt32(0);
                        }
                    }

                    //create anamnesis and bound it to lastPID
                    string newAna = $"INSERT INTO Anamnesis (First_Anamnesis, Second_Anamnesis, Third_Anamnesis, Fourth_Anamnesis, Fifth_Anamnesis, Sixth_Anamnesis, Seventh_Anamnesis, Eighth_Anamnesis, Ninth_Anamnesis, Tenth_Anamnesis, Other_Anamnesis, ID_Patient_Ana) VALUES " +
                        $"(N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', {lastPID})";
                    com = new SqlCommand(newAna, conn);
                    com.ExecuteNonQuery();
                    glob.anamnesisdb.SaveChanges();

                    //create exam x6 and bound it to lastPID
                    string newExa = $"INSERT INTO Exam (Num_Exam, Bit_Exam, Left_First_Exam, Left_Second_Exam, Left_Third_Exam, Left_Fourth_Exam, Left_Fifth_Exam, Left_Sixth_Exam, Left_Seventh_Exam, Left_Eighth_Exam, Right_First_Exam, Right_Second_Exam, Right_Third_Exam, Right_Fourth_Exam, Right_Fifth_Exam, Right_Sixth_Exam, Right_Seventh_Exam, Right_Eighth_Exam, ID_Patient_Exa) VALUES " +
                        $"(3, 0, N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', {lastPID}), " +
                        $"(2, 0, N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', {lastPID}), " +
                        $"(1, 0, N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', {lastPID}), " +
                        $"(1, 1, N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', {lastPID}), " +
                        $"(2, 1, N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', {lastPID}), " +
                        $"(3, 1, N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', {lastPID});";
                    com = new SqlCommand(newExa, conn);
                    com.ExecuteNonQuery();
                    glob.examdb.SaveChanges();

                    conn.Close();

                    Update();
                }
            }
            catch { }
            
        }

        
    }
}
