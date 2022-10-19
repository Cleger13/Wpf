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
    public partial class RegistrationWindow : Window
    {
       // AppContext db;
        public RegistrationWindow()
        {
            InitializeComponent();

           // db = new AppContext();
        }
        private void Button_Click_Ok(object obj, RoutedEventArgs e)
        {
           // string login = textBoxLogin.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string pass = passBox1.Password.Trim();
            string pass2 = passBox2.Password.Trim();

            if (!email.Contains("@mail.ru") && !email.Contains("@gmail.com"))
            {
                textBoxEmail.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 6)
            {
                passBox1.ToolTip = "Пароль слишком короткий!";
                passBox1.Background = Brushes.DarkRed;
            }
            else if (pass != pass2)
            {
                passBox2.ToolTip = "Пароли не сопадают!";
                passBox2.Background = Brushes.DarkRed;
            }
            else
            {
               // User user = new User(login, email, pass);

              //  db.Users.Add(user);
              //  db.SaveChanges();
                
                MainWindow mainwindow = new MainWindow();
                mainwindow.Show();
                Hide();
            }
        }
    }
}
