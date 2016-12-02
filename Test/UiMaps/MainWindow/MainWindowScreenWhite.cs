using System.Reflection;
using Test.UiMaps.MainWindow.ScreenFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow
{
    public class MainWindowScreenWhite : AppScreen, IMainWindowScreen
    {
        private readonly IScreenFactory _screenFactory;

        public MainWindowScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._screenFactory = new ScreenFactoryWhite(screenRepository);
        }

        private TestStack.White.UIItems.TabItems.Tab MainTabControl;
#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.TabItems.TabPage TabItmRecycleBin;
        private TestStack.White.UIItems.TabItems.TabPage TabItmSettings;
        private TestStack.White.UIItems.TabItems.TabPage TabItmInbox;
        private TestStack.White.UIItems.TabItems.TabPage TabItmEventLog;
        private TestStack.White.UIItems.Button Btn_Min_Window;
        private TestStack.White.UIItems.Button Btn_Max_Window;
        private TestStack.White.UIItems.Button Btn_Close_Window;
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        StatusBar.IStatusBarScreen IMainWindowScreen.StatusBar
        {
            get
            {
                return this._screenFactory.PopulateStatusBarScreen();
            }
        }

        Tabs.ITabsScreen IMainWindowScreen.Tabs
        {
            get
            {
                return this._screenFactory.PopulateTabsScreen();
            }
        }

        Menu.IMenuScreen IMainWindowScreen.Menu
        {
            get
            {
                return this._screenFactory.PopulateMenuScreen();
            }
        }

        private UiMapItems.Button.IButton MinimizeWindow_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.Btn_Min_Window, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IMainWindowScreen.MinimizeWindow_Button
        {
            get
            {
                return this.MinimizeWindow_Button;
            }
        }

        private UiMapItems.Button.IButton MaximizeWindow_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.Btn_Max_Window, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IMainWindowScreen.MaximizeWindow_Button
        {
            get
            {
                return this.MaximizeWindow_Button;
            }
        }

        private UiMapItems.Button.IButton CloseWindow_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.Btn_Close_Window, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IMainWindowScreen.CloseWindow_Button
        {
            get
            {
                return this.CloseWindow_Button;
            }
        }

        private UiMapItems.Tab.ITab Inbox_Tab
        {
            get
            {
                return new UiMapItems.Tab.TabWhite(this.TabItmInbox, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Tab.ITab IMainWindowScreen.Inbox_Tab
        {
            get
            {
                return this.Inbox_Tab;
            }
        }

        private UiMapItems.Tab.ITab RecycleBin_Tab
        {
            get
            {
                return new UiMapItems.Tab.TabWhite(this.TabItmRecycleBin, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Tab.ITab IMainWindowScreen.RecycleBin_Tab
        {
            get
            {
                return this.RecycleBin_Tab;
            }
        }

        private UiMapItems.Tab.ITab Settings_Tab
        {
            get
            {
                return new UiMapItems.Tab.TabWhite(this.TabItmSettings, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Tab.ITab IMainWindowScreen.Settings_Tab
        {
            get
            {
                return this.Settings_Tab;
            }
        }

        private UiMapItems.Tab.ITab EventLog_Tab
        {
            get
            {
                return new UiMapItems.Tab.TabWhite(this.TabItmEventLog, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Tab.ITab IMainWindowScreen.EventLog_Tab
        {
            get
            {
                return this.EventLog_Tab;
            }
        }
    }
}