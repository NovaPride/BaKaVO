using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BaKaVO.Windows
{
    public partial class Anamnesis : Window
    {
        public Anamnesis()
        {
            InitializeComponent();
          
        }
        
        public void DragWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }  
    }
}
