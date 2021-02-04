using System;
using System.Collections.Generic;
using System.Text;

namespace TUC.plugins.interfaces
{
    interface IMainViewModel
    {
        public string Title { get; set; }
        public string Button1Text { get; set; }
        public string Button2Text { get; set; }

        public void Button1Pressed();
        public void Button2Pressed();



    }
}
