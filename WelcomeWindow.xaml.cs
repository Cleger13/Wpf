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
using System.Windows.Shapes;

namespace Поликлиника
{
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_Exit(object obj, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            Hide();
        }
        private void Button_Click_Table(object obj, RoutedEventArgs e)
        {
            TableWindow tablewindow = new TableWindow();
            tablewindow.Show();
            Hide();
        }
    }
}
