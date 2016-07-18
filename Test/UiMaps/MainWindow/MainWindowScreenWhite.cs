using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow
{
    public class MainWindowScreenWhite : AppScreen, IMainWindowScreen
    {
        public MainWindowScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {   }


    }
}
