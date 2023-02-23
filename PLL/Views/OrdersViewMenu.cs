using SF_25.PLL.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public class OrdersViewMenu
    {
        public void Show()
        {
            SuccessMessage.Show("Данный раздел находится в разработке. Приносим свои извинения за причинённые неудобства.");

            Console.WriteLine("\nНАЖМИТЕ ЛЮБУЮ КЛАВИШУ.");
            Console.ReadKey();
            Console.Clear();
            Program.rootMenuView.Show();
        }
    }
}
