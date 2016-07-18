using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.ToolBar
{
    public class ToolBarScreenWhite : AppScreen, IToolBarScreen
    {
        public ToolBarScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {   }
    }
}
