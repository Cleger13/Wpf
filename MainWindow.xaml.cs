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

namespace Поликлиника
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string pass = passBox.Password.Trim();

            if (!email.Contains("@mail.ru") && !email.Contains("@gmail.com"))
            {
                textBoxEmail.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 6) 
            {
                passBox.ToolTip = "Пароль слишком короткий!";
                passBox.Background = Brushes.DarkRed;
            }
            else
            {
                WelcomeWindow welcomewindow = new WelcomeWindow();
                welcomewindow.textBoxUser.Text = this.textBoxLogin.Text + "!";
                welcomewindow.Show();
                Hide();
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationwindow = new RegistrationWindow();
            registrationwindow.Show();
            Hide();
        }
    }
}
