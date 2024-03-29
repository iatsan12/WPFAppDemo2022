﻿using System.Windows;
using WpfAppDemo2022.View;
using WpfAppDemo2022.ViewModel;

namespace WpfAppDemo2022
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int IdRole { get; set; }
        public static int IdEmployee { get; set; }
        public static RoleViewModel vmRole { get; set; }
        public static PersonViewModel vmPerson { get; set; }


        public MainWindow()
        {
            InitializeComponent();
        }
        private void Employee_OnClick(object sender, RoutedEventArgs e)
        {
            WindowEmployee wEmployee = new WindowEmployee();
            wEmployee.Show();
        }
        private void Role_OnClick(object sender, RoutedEventArgs e)
        {
            WindowRole wRole = new WindowRole();
            wRole.Show();
        }

    }
}
