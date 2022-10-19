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
    public partial class TableWindow : Window
    {
        public TableWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            WelcomeWindow welcomwindow = new WelcomeWindow();
            welcomwindow.Show();
            Hide();
        }
        private void Button_Click_Open1(object sender, RoutedEventArgs e)
        {
            Day1Window day1window = new Day1Window();
            day1window.Show();
            Hide();
        }
        private void Button_Click_Open2(object sender, RoutedEventArgs e)
        {
            Day2Window day2window = new Day2Window();
            day2window.Show();
            Hide();
        }
        private void Button_Click_Open3(object sender, RoutedEventArgs e)
        {
            Day3Window day3window = new Day3Window();
            day3window.Show();
            Hide();
        }
        private void Button_Click_Open4(object sender, RoutedEventArgs e)
        {
            Day4Window day4window = new Day4Window();
            day4window.Show();
            Hide();
        }
        private void Button_Click_Open5(object sender, RoutedEventArgs e)
        {
            Day5Window day5window = new Day5Window();
            day5window.Show();
            Hide();
        }
        private void Button_Click_Open6(object sender, RoutedEventArgs e)
        {
            Day6Window day6window = new Day6Window();
            day6window.Show();
            Hide();
        }
    }
}
