using System;
using System.Reflection;
using Test.UiMaps.MainWindow.Menu.Email;
using Test.UiMaps.MainWindow.Menu.Factory;
using Test.UiMaps.MainWindow.Menu.File;
using Test.UiMaps.MainWindow.Menu.Help;
using Test.UiMaps.MainWindow.Menu.View;
using Test.UiMaps.UiMapItems.Button;
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

        private IFileMenuScreen File
        {
            get
            {
                return this._menuFactory.PopulateFileMenuScreen();
            }
        }

        private IEmailMenuScreen Email
        {
            get
            {
                return this._menuFactory.PopulateEmailMenuScreen();
            }
        }

        private IHelpMenuScreen Help
        {
            get
            {
                return this._menuFactory.PopulateHelpMenuScreen();
            }
        }

        private IViewMenuScreen View
        {
            get
            {
                return this._menuFactory.PopulateViewMenuScreen();
            }
        }

        private UiMapItems.Button.IButton File_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmFile, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Email_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmMessage, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Help_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmHelp, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton View_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmView, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        IFileMenuScreen IMenuScreen.File
        {
            get
            {
                return this.File;
            }
        }

        IEmailMenuScreen IMenuScreen.Email
        {
            get
            {
                return this.Email;
            }
        }

        IHelpMenuScreen IMenuScreen.Help
        {
            get
            {
                return this.Help;
            }
        }

        IViewMenuScreen IMenuScreen.View
        {
            get
            {
                return this.View;
            }
        }

        IButton IMenuScreen.File_Button
        {
            get
            {
                return this.File_Button;
            }
        }

        IButton IMenuScreen.Email_Button
        {
            get
            {
                return this.Email_Button;
            }
        }

        IButton IMenuScreen.Help_Button
        {
            get
            {
                return this.Help_Button;
            }
        }

        IButton IMenuScreen.View_Button
        {
            get
            {
                return this.View_Button;
            }
        }
    }
}