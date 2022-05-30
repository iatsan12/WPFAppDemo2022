﻿using System;
using System.Windows;
using System.Collections.ObjectModel;
using System.Collections.Generic;

using WpfAppDemo2022.ViewModel;
using WpfAppDemo2022.Model;
using WpfAppDemo2022.Helper;

namespace WpfAppDemo2022.View
{
    /// <summary>
    /// Логика взаимодействия для WindowEmployee.xaml
    /// </summary>
    public partial class WindowEmployee : Window
    {
        public WindowEmployee()
        {
            InitializeComponent();
            PersonViewModel vmPerson = new PersonViewModel();
            RoleViewModel vmRole = new RoleViewModel();
            List<Role> roles = new List<Role>();
            foreach (Role r in vmRole.ListRole)
            {
                roles.Add(r);
            }
            ObservableCollection<PersonDPO> persons = new ObservableCollection<PersonDPO>();
            FindRole finder;
            foreach (var p in vmPerson.ListPerson)
            {
                finder = new FindRole(p.RoleId);
                Role rol = roles.Find(new Predicate<Role>(finder.RolePredicate));
                persons.Add(new PersonDPO
                {
                    Id = p.Id,
                    Role = rol.NameRole,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Birthday = p.Birthday
                });
            }
            lvEmployee.ItemsSource = persons;
        }
    }
}
