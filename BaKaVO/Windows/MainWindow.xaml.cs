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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BaKaVO.Windows
{

    public partial class MainWindow : Window
    {
        int id = 0;
        public MainWindow()
        {
            InitializeComponent();
            Window w = new Base();
            w.Show();
            this.Close();

            //this.WindowStyle = WindowStyle.ThreeDBorderWindow;
            //id = 1;//prevent errors
            //Update();
        }

        //private void Update()//функция обновления данных в разных полях
        //{
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(glob.connectionstring))
        //        {

        //            string reg = "SELECT ID_Patient as IDP, Fullname_Patient as NameP, PhoneNumber_Patient as PhoneP, CONVERT(varchar(10), FillingAt_Patient, 104) as FillingP FROM Patient";
        //            glob.adapt = new SqlDataAdapter(reg, conn);
        //            conn.Open();
        //            glob.dt = new System.Data.DataTable();
        //            glob.adapt.Fill(glob.dt);
        //            PatientDataGrid.ItemsSource = glob.dt.DefaultView;
        //            conn.Close();
        //        }
        //    }
        //    catch { MessageBox.Show("Введите корректную информацию! 7"); return; }
        //}

        //private void PatientDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)//функция обновления полей для заполнения при выделения строки в таблице
        //{
        //    try
        //    {
        //        DataRowView h = PatientDataGrid.SelectedItems[0] as DataRowView;
        //        id = Convert.ToInt32( h.Row[0]);
        //        //MessageBox.Show(id.ToString());
        //    }
        //    catch { }
        //}

        //private void PatientWin_Click(object sender, RoutedEventArgs e)
        //{
        //    Window w = new Base();
        //    w.Show();
        //    this.Close();
        //}
        //private void Maximized_Click(object sender, RoutedEventArgs e)
        //{
        //    if (this.WindowState != WindowState.Normal)
        //    {
        //        this.ResizeMode = ResizeMode.CanResize;
        //        this.WindowState = WindowState.Normal;
        //        //this.Topmost = false;
        //    }
        //    else
        //    {
        //        //this.Visibility = Visibility.Collapsed;
        //        this.ResizeMode = ResizeMode.NoResize;
        //        this.WindowState = WindowState.Maximized;
        //        //this.Topmost = true;
        //        // this.Visibility = Visibility.Visible;
        //    }
        //}
        //private void Minimized_Click(object sender, RoutedEventArgs e)
        //{
        //    this.WindowState = WindowState.Minimized;
        //}
        //private void Exit_Click(object sender, RoutedEventArgs e)//функция закрытия окна
        //{
        //    this.Close();
        //}
        //public void DragWindow(object sender, MouseButtonEventArgs e)
        //{
        //    this.DragMove();
        //}


        //private void test(object sender, RoutedEventArgs e)
        //{
        //    string amogus = ((Button)sender).Name;
        //    MessageBox.Show(amogus);
        //}

        //private void PatientDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    Window w = new PatientWin();
        //    w.Show();
        //    this.Close();
        //}
    }
}
