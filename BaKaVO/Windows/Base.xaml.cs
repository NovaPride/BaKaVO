using BaKaVO.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BaKaVO.Windows
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class Base : Window
    {
        public Base()
        {
            InitializeComponent();
            glob.pat_id = 1;
            glob.curvi_id = 1;
            glob.myBase = this;
            //Content="{Binding CurrentView}"
            //Binding myBinding = new Binding("CurrentView");
            //myBinding.Source = MainViewModel;
            
            //BaseContentControl.SetBinding(BaseContentControl.DataContext, myBinding);
           // BaseContentControl.Content = "{Binding CurrentView}";
            this.WindowStyle = WindowStyle.ThreeDBorderWindow;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.LongDatePattern = "dd.MM.yyyy"; //This can be used for one type of DatePicker
            ci.DateTimeFormat.ShortDatePattern = "dd.MM.yy"; //for the second type
            Thread.CurrentThread.CurrentCulture = ci;
        }
        public void switchView(int i)
        {
            switch (i)
            {
                case 1:
                    BaseRadio1.Command.Execute(null);
                    BaseRadio1.IsChecked = true;
                    glob.curvi_id = 1;
                    break;
                case 2:
                    BaseRadio2.Command.Execute(null);
                    BaseRadio2.IsChecked = true;
                    glob.curvi_id = 2;
                    break;
                case 3:
                    BaseRadio3.Command.Execute(null);
                    BaseRadio3.IsChecked = true;
                    glob.curvi_id = 3;
                    break;
                case 4:
                    BaseRadio4.Command.Execute(null);
                    BaseRadio4.IsChecked = true;
                    glob.curvi_id = 4;
                    break;
                default: MessageBox.Show("Error! How did you get here?"); break;
            }  
        }
        private void RadioButtonSwitchView_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rbut = (RadioButton)sender;//sender button
            string name = rbut.Name;//sender button name
            string num = name.Substring(name.Length - 1, 1);//only it number

            glob.curvi_id = Convert.ToInt32(num);
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (SaveButton.IsChecked == true)
            {
                SaveButton.Content = "Сохранить";
                ButtonsLock.Visibility = Visibility.Visible;
                glob.issaveclicked = true;
            }
            else
            {
                SaveButton.Content = "Редактировать";
                ButtonsLock.Visibility = Visibility.Hidden;
                glob.issaveclicked = false;
            }

            switch (glob.curvi_id)
            {
                case 1:
                    glob.myPatientListView.SaveButtonWasClicked();
                    break;
                case 2:
                    glob.myPatientView.SaveButtonWasClicked();
                    break;
                case 3:
                    glob.myAnamnesisView.SaveButtonWasClicked();
                    break;
                case 4:
                    glob.mySettingsView.SaveButtonWasClicked();
                    break;
                default: MessageBox.Show("Error! How did you get here?"); break;
            }
        }
        private void Maximized_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Normal)
            {
                this.ResizeMode = ResizeMode.CanResize;
                this.WindowState = WindowState.Normal;
                //this.Topmost = false;
            }
            else
            {
                //this.Visibility = Visibility.Collapsed;
                this.ResizeMode = ResizeMode.NoResize;
                this.WindowState = WindowState.Maximized;
                //this.Topmost = true;
                //this.Visibility = Visibility.Visible;
            }
        }
        private void Minimized_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)//функция закрытия окна
        {
            this.Close();
        }
        private void LeftPanel_Click(object sender, RoutedEventArgs e)//функция закрытия окна
        {
            if (LeftColumn.Width.Value == 130) {
                LeftPanelBut.Content = "▼";
                LeftColumn.Width = new GridLength(0); 
            }
            else { 
                LeftPanelBut.Content = "▲";
                LeftColumn.Width = new GridLength(130);
            }
        }
        
        public void DragWindow(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch { }
        }
    }
}
