using Test.UiMaps.MainWindow.Menu.Email;
using Test.UiMaps.MainWindow.Menu.Factory;
using Test.UiMaps.MainWindow.Menu.File;
using Test.UiMaps.MainWindow.Menu.Help;
using Test.UiMaps.MainWindow.Menu.View;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Menu
{
    public class MenuScreenWhite : AppScreen, IMenuScreen
    {
        private readonly IMenuFactory _menuFactory;
#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.MenuItems.Menu MnuItmFile; //Menu item 'File'
        private TestStack.White.UIItems.MenuItems.Menu MnuItmMessage; //Menu item 'Email'
        private TestStack.White.UIItems.MenuItems.Menu MnuItmView; //Menu item 'View'
        private TestStack.White.UIItems.MenuItems.Menu MnuItmHelp; //Menu item 'Help'

#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        public MenuScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._menuFactory = new MenuFactoryWhite(screenRepository);
        }

        public UiMapItems.Button.IButton File_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmFile);
            }
        }

        public IFileMenuScreen File
        {
            get
            {
                return this._menuFactory.PopulateFileMenuScreen();
            }
        }

        public IEmailMenuScreen Email
        {
            get
            {
                return this._menuFactory.PopulateEmailMenuScreen();
            }
        }

        public IHelpMenuScreen Help
        {
            get
            {
                return this._menuFactory.PopulateHelpMenuScreen();
            }
        }

        public IViewMenuScreen View
        {
            get
            {
                return this._menuFactory.PopulateViewMenuScreen();
            }
        }

        public UiMapItems.Button.IButton Email_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmMessage);
            }
        }

        public UiMapItems.Button.IButton Help_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmHelp);
            }
        }

        public UiMapItems.Button.IButton View_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmView);
            }
        }
    }
}