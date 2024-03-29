using BaKaVO.Windows;
using System;
using System.Collections.Generic;
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
using static System.Net.Mime.MediaTypeNames;

namespace BaKaVO.MVVM.View
{
    /// <summary>
    /// Interaction logic for AnamnesisView.xaml
    /// </summary>
    public partial class AnamnesisView : UserControl
    {
        public AnamnesisView()
        {
            InitializeComponent();
            glob.myAnamnesisView = this;
            this.FontSize = 15;
            Update();
        }
        public void SaveButtonWasClicked()
        {
            FullGrid.IsHitTestVisible = glob.issaveclicked;
            if (!glob.issaveclicked)
            {
                Save();
            }
        }
        private void Update()//функция обновления данных в разных полях
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(glob.connectionstring))
                {
                    conn.Open();
                    string sql = "SELECT ID_Anamnesis, First_Anamnesis, Second_Anamnesis, Third_Anamnesis, Fourth_Anamnesis, Fifth_Anamnesis, Sixth_Anamnesis, Seventh_Anamnesis, Eighth_Anamnesis, Ninth_Anamnesis, Tenth_Anamnesis, Other_Anamnesis, ID_Anamnesis " +
                        "FROM Anamnesis " +
                        "JOIN Patient ON ID_Patient_Ana = Patient.ID_Patient " +
                        "WHERE ID_Patient = " + glob.pat_id.ToString();
                    SqlCommand com = new SqlCommand(sql, conn);
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 1; i < 11; i++) { RadioButton_Fill(i, reader.GetString(i)); }
                            TextBox11.Text = reader.GetString(11);
                            IDLabel.Content = reader.GetInt32(12).ToString();
                        }
                    }
                    conn.Close();
                }
            }
            catch { MessageBox.Show("Введите корректную информацию! 5"); return; }
        }
        private void RadioButton_Fill(int question, string answer)
        {
            string num = question.ToString();
            TextBox txt = (TextBox)FindName("TextBox" + num);
            RadioButton rby = (RadioButton)FindName("RBY" + num);
            RadioButton rbn = (RadioButton)FindName("RBN" + num);

            if (answer == "" || answer == " " || answer == null)
            {
                rby.IsChecked = true;

                txt.IsHitTestVisible = false;
                txt.Text = null;
            }
            else
            {
                rbn.IsChecked = true;

                txt.IsHitTestVisible = true;
                txt.Text = answer;
            }
        }
        private void Save()
        {
            try
            {
                SqlConnection conn = new SqlConnection(glob.connectionstring);
                conn.Open();

                string save = "UPDATE Anamnesis SET First_Anamnesis = N'" + TextBox1.Text
                    + "',  Second_Anamnesis = N'" + TextBox2.Text
                    + "',  Third_Anamnesis = N'" + TextBox3.Text
                    + "',  Fourth_Anamnesis = N'" + TextBox4.Text
                    + "',  Fifth_Anamnesis = N'" + TextBox5.Text
                    + "',  Sixth_Anamnesis = N'" + TextBox6.Text
                    + "',  Seventh_Anamnesis = N'" + TextBox7.Text
                    + "',  Eighth_Anamnesis = N'" + TextBox8.Text
                    + "',  Ninth_Anamnesis = N'" + TextBox9.Text
                    + "',  Tenth_Anamnesis = N'" + TextBox10.Text
                    + "',  Other_Anamnesis = N'" + TextBox11.Text
                    + "' WHERE ID_Anamnesis = " + IDLabel.Content.ToString();
                    

                SqlCommand savecom = new SqlCommand(save, conn);
                savecom.ExecuteNonQuery();
                glob.anamnesisdb.SaveChanges();
                conn.Close();
                Update();
            }
            catch { MessageBox.Show("Введите корректную информацию! 6"); return; }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rbut = (RadioButton)sender;//sender button
            string name = rbut.Name;//sender button name

            string ch = name.Substring(2, 1);//only it char
            string num = name.Substring(3, name.Length - 3);//only it number
            TextBox txt = (TextBox)FindName("TextBox" + num);

            switch (ch)
            {
                case "Y":
                    txt.Text = null;
                    txt.IsHitTestVisible = false;
                    break;

                case "N":
                    txt.IsHitTestVisible = true;
                    break;

                default: MessageBox.Show("Error! How did you get here?"); break;
            }
        }

        private void AnamnesisView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.ActualWidth <= 1300) { this.FontSize = 15; }
            if (this.ActualWidth > 1300) { this.FontSize = 16; }
            if (this.ActualWidth > 1850) { this.FontSize = 17; }
            if (this.ActualWidth > 2400) { this.FontSize = 18; }
        }

    }
}
