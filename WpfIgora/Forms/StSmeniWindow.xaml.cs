﻿using System;
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
    /// Логика взаимодействия для StSmeniWindow.xaml
    /// </summary>
    public partial class StSmeniWindow : Window
    {
        public StSmeniWindow()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }
    }
}
