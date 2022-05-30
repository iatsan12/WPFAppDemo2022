using System.Windows;
using WpfAppDemo2022.ViewModel;

namespace WpfAppDemo2022.View
{
    /// <summary>
    /// Логика взаимодействия для WindowRole.xaml
    /// </summary>
    public partial class WindowRole : Window
    {
        public WindowRole()
        {
            InitializeComponent();
            RoleViewModel vmRole = new RoleViewModel();
            lvRole.ItemsSource = vmRole.ListRole;
        }
    }
}
