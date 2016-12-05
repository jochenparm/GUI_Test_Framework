using Test.UiMaps.MainWindow.Tabs.RecycleBin.Factory;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.RecycleBin
{
    public class RecycleBinTabScreenWhite : AppScreen, IRecycleBinTabScreen
    {
        private readonly IRecycleBinFactory _toolBarFactory;

        public RecycleBinTabScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._toolBarFactory = new RecycleBinFactoryWhite(screenRepository);
        }

        ToolBar.IRecycleBinToolBarScreen IRecycleBinTabScreen.ToolBar
        {
            get
            {
                return this._toolBarFactory.PopulateRecycleBinToolBarScreen();
            }
        }

        SearchBar.IRecycleBinSearchBarScreen IRecycleBinTabScreen.SearchBar
        {
            get
            {
                return this._toolBarFactory.PopulateRecycleBinSearchBarScreen();
            }
        }
    }
}