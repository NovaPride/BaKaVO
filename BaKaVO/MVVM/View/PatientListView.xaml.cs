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
        public PatientListView()
        {
            curr_patlistpage = 1;
            patientperpage = 25;
            InitializeComponent();
            glob.myPatientListView = this;
            this.FontSize = 15;
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

        private void Update()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(glob.connectionstring))
                {
                    string reg = "SELECT ID_Patient as IDP, Fullname_Patient as NameP, PhoneNumber_Patient as PhoneP, SUBSTRING(Comment_Patient, 1, 200) as CommentP FROM Patient " +
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
            catch { MessageBox.Show("Введите корректную информацию ! 1"); return; }
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

    }
}
