using Microsoft.EntityFrameworkCore;
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


namespace WpfIgora.Forms
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
            Loaded += UserWindow_Loaded; 
        }

        private void UserWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MyContext myContext = new DB.MyContext();
                UserName.Text = myContext.Users.Single(x => x.Id == App.idUser).Name;
                UserSurname.Text = myContext.Users.Single(x => x.Id == App.idUser).Surname;
                UserFathername.Text = myContext.Users.Single(x => x.Id == App.idUser).Fathername;
                UserDataBirth.Text = myContext.Users.Single(x => x.Id == App.idUser).Databirth;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }

    }
}
