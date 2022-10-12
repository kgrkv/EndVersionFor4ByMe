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

namespace WpfIgora
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

        private void btShowPassword_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(tbPassword.Password);
        }

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {
            DB.MyContext myContext = new DB.MyContext();
            var flag = myContext.Users.Any(x => x.Login == tbLogin.Text && x.Password == tbPassword.Password);
            var Job = myContext.Workers.Where(x => x.Login == tbLogin.Text && x.Password == tbPassword.Password);
            if (flag == true)
            {
                MessageBox.Show("Вы вошли!");
                var us = myContext.Users.Single(x => x.Login == tbLogin.Text && x.Password == tbPassword.Password);

                App.idUser = us.Id;
                Forms.UserWindow userWindow = new();
                userWindow.Show();
                Close();
            }
            else if (Job.Count() > 0)
            {
                MessageBox.Show("Вы вошли!");
                var Worker = Job.First();
                App.idUser = Job.First().Id;
                if (Worker.Role == "Продавец")
                {
                    Forms.SellerWindow sellerWindow = new();
                    sellerWindow.Show();
                    Close();
                }
                else if (Worker.Role == "Старший смены")
                {
                    Forms.StSmeniWindow stSmeniWindow = new();
                    stSmeniWindow.Show();
                    Close();
                }
                else if (Worker.Role == "Администратор")
                {
                    Forms.AdminWindow adminWindow = new();
                    adminWindow.Show();
                    Close();

                }
                else
                {
                    MessageBox.Show("Ошибка входа!");

                }
            }
            else
            {
                MessageBox.Show("Ошибка входа!");

            }
        }
    }
}
