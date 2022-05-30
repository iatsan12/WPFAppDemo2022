using System;

namespace WpfAppDemo2022.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string NameRole { get; set; }
        public Role() { }
        public Role(int id, string nameRole)
        {
            this.Id = id;
            this.NameRole = nameRole;
        }
        /// <summary>
        /// Метод поверхностного копирования 
        /// </summary>
        /// <returns></returns>
        public Role ShallowCopy()
        {
            return (Role)this.MemberwiseClone();
        }
    }
}
