using Test.UiMaps.MainWindow.Tabs.RecycleBin.ToolBar.Factory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.RecycleBin
{
    public class RecycleBinTabScreenWhite : AppScreen, IRecycleBinTabScreen
    {
        private readonly IRecycleBinToolBarFactory _toolBarFactory;

        public RecycleBinTabScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._toolBarFactory = new RecycleBinToolBarFactoryWhite(screenRepository);
        }

        ToolBar.IRecycleBinToolBarScreen IRecycleBinTabScreen.ToolBar
        {
            get
            {
                return this._toolBarFactory.PopulateRecycleBinToolBarScreen();
            }
        }
    }
}