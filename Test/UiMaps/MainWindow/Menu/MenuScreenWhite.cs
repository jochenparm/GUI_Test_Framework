using Test.UiMaps.MainWindow.Menu.Factory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Menu
{
    public class MenuScreenWhite : AppScreen, IMenuScreen
    {
        private readonly IMenuFactory _menuFactory;
#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.MenuItems.Menu MnuItmFile; //Menu item 'File'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        public MenuScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._menuFactory = new MenuFactoryWhite(screenRepository);
        }

        File.IFileMenuScreen IMenuScreen.File
        {
            get
            {
                return this._menuFactory.PopulateFileMenuScreen();
            }
        }

        private UiMapItems.Button.IButton File_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmFile);
            }
        }

        UiMapItems.Button.IButton IMenuScreen.File_Button
        {
            get
            {
                return this.File_Button;
            }
        }
    }
}