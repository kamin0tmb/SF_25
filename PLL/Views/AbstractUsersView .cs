using SF_25.BLL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public abstract class AbstractUsersView : AbstractView
    {
        public UsersServices usersServices;

        public AbstractUsersView(UsersServices usersServices)
        {
            this.usersServices = usersServices;
        }

        public override void Exit()
        {
            Console.WriteLine("\nНАЖМИТЕ ЛЮБУЮ КЛАВИШУ.");
            Console.ReadKey();
            Console.Clear();
            Program.usersViewMenu.Show();
        }
    }
}
