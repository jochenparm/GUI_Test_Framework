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
                return new UiMapItems.Button.ButtonWhite(this.Btn_Min_Window);
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
                return new UiMapItems.Button.ButtonWhite(this.Btn_Max_Window);
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
                return new UiMapItems.Button.ButtonWhite(this.Btn_Close_Window);
            }
        }

        UiMapItems.Button.IButton IMainWindowScreen.CloseWindow_Button
        {
            get
            {
                return this.CloseWindow_Button;
            }
        }

        private UiMapItems.Button.IButton InboxTab_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabItmInbox);
            }
        }

        UiMapItems.Button.IButton IMainWindowScreen.InboxTab_Button
        {
            get
            {
                return this.InboxTab_Button;
            }
        }

        private UiMapItems.Button.IButton RecycleBinTab_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabItmRecycleBin);
            }
        }

        UiMapItems.Button.IButton IMainWindowScreen.RecycleBinTab_Button
        {
            get
            {
                return this.RecycleBinTab_Button;
            }
        }

        private UiMapItems.Button.IButton SettingsTab_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabItmSettings);
            }
        }

        UiMapItems.Button.IButton IMainWindowScreen.SettingsTab_Button
        {
            get
            {
                return this.SettingsTab_Button;
            }
        }

        private UiMapItems.Button.IButton EventLogTab_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabItmEventLog);
            }
        }

        UiMapItems.Button.IButton IMainWindowScreen.EventLogTab_Button
        {
            get
            {
                return this.EventLogTab_Button;
            }
        }
    }
}