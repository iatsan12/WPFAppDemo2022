using System.Windows;
using WpfAppDemo2022.Model;

namespace WpfAppDemo2022.Helper
{
    public class FindRole
    {
        int id;
        public FindRole(int id)
        {
            this.id = id;
        }
        public bool RolePredicate(Role role)
        {
            return role.Id == id;
        }

    }
}