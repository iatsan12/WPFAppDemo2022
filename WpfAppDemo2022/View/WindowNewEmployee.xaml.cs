using System;
using System.Windows;
using System.Collections.ObjectModel;
using System.Collections.Generic;

using WpfAppDemo2022.ViewModel;
using WpfAppDemo2022.Model;


namespace WpfAppDemo2022.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewEmployee.xaml
    /// </summary>
    public partial class WindowNewEmployee : Window
    {
        public WindowNewEmployee()
        {
            InitializeComponent();
        }
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
