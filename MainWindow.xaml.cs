using System;
using System.Collections.Generic;
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

namespace _1406
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] login = new string[3] { "1", "2", "3" };
            string[] password = new string[3] { "1", "2", "3" };

            if (l_txt.Text.Equals(login[0]) & p_txt.Password.Equals(password[0]) | (l_txt.Text.Equals(login[1]) & p_txt.Password.Equals(password[1]) | (l_txt.Text.Equals(login[2]) & p_txt.Password.Equals(password[2])))) ;
            {
                Window1 window1 = new Window1();
                //window1.ViewModel = "ViewModel";


                window1.Show();
                Close();
            }
            

        }
    }
}
