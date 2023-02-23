using SF_25.PLL.Views.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL.Views
{
    public abstract class AbstractView : IView
    {
        public abstract void Show();

        public abstract void Exit();        
    }
}
