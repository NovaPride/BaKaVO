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
        public PatientListView()
        {
            InitializeComponent();
            glob.myPatientListView = this;
            this.FontSize = 15;
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
        private void Update()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(glob.connectionstring))
                {

                    string reg = "SELECT ID_Patient as IDP, Fullname_Patient as NameP, PhoneNumber_Patient as PhoneP, CONVERT(varchar(10), FillingAt_Patient, 104) as FillingP FROM Patient";
                    glob.adapt = new SqlDataAdapter(reg, conn);
                    conn.Open();
                    glob.dt = new System.Data.DataTable();
                    glob.adapt.Fill(glob.dt);
                    PatientListDataGrid.ItemsSource = glob.dt.DefaultView;
                    conn.Close();
                }
            }
            catch { MessageBox.Show("Введите корректную информацию!"); return; }
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

        
    }
}
