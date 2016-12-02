using System.Reflection;
using Test.UiMaps.MainWindow.Tabs.Settings.Factory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings
{
    public class SettingsTabScreenWhite : AppScreen, ISettingsTabScreen
    {
        private readonly ISettingsTabFactory _settingsTabFactory;

        public SettingsTabScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._settingsTabFactory = new SettingsTabFactoryWhite(screenRepository);
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.TabItems.TabPage TabItmSpamTools; //Tab Item 'Spam Tools'
        private TestStack.White.UIItems.TabItems.TabPage TabRecycleBin; //Tab Item 'Recycle Bin'
        private TestStack.White.UIItems.TabItems.TabPage TabSync; //Tab Item 'Sync'
        private TestStack.White.UIItems.TabItems.TabPage TabItmAccounts; //Tab Item 'Accounts'
        private TestStack.White.UIItems.Label LblGeneralIcon; //Text Label for Tab Item 'General'
        private TestStack.White.UIItems.Label LblDisplayIcon; //Text Label for Tab Item 'Display'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.Button.IButton General_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.LblGeneralIcon.GetParent<TestStack.White.UIItems.TabItems.TabPage>(), MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton ISettingsTabScreen.General_Button
        {
            get
            {
                return this.General_Button;
            }
        }

        private UiMapItems.Button.IButton Accounts_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabItmAccounts, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton ISettingsTabScreen.Accounts_Button
        {
            get
            {
                return this.Accounts_Button;
            }
        }

        private UiMapItems.Button.IButton SpamTools_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabItmSpamTools, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton ISettingsTabScreen.SpamTools_Button
        {
            get
            {
                return this.SpamTools_Button;
            }
        }

        private UiMapItems.Button.IButton Display_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.LblDisplayIcon.GetParent<TestStack.White.UIItems.TabItems.TabPage>(), MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton ISettingsTabScreen.Display_Button
        {
            get
            {
                return this.Display_Button;
            }
        }

        private UiMapItems.Button.IButton RecycleBin_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabRecycleBin, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton ISettingsTabScreen.RecycleBin_Button
        {
            get
            {
                return this.RecycleBin_Button;
            }
        }

        private UiMapItems.Button.IButton Sync_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabSync, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton ISettingsTabScreen.Sync_Button
        {
            get
            {
                return this.Sync_Button;
            }
        }

        Accounts.IAccountsSettingsScreen ISettingsTabScreen.Accounts
        {
            get
            {
                return this._settingsTabFactory.PopulateAccountSettingsScreen();
            }
        }

        General.IGeneralSettingsScreen ISettingsTabScreen.General
        {
            get
            {
                return this._settingsTabFactory.PopulateGeneralSettingsScreen();
            }
        }

        RecycleBin.IRecycleBinSettingsScreen ISettingsTabScreen.RecycleBin
        {
            get
            {
                return this._settingsTabFactory.PopulateRecycleBinSettingsScreen();
            }
        }

        SpamTools.ISpamToolsSettingsScreen ISettingsTabScreen.SpamTools
        {
            get
            {
                return this._settingsTabFactory.PopulateSpamToolsSettingsScreen();
            }
        }

        Sync.ISyncSettingsScreen ISettingsTabScreen.Sync
        {
            get
            {
                return this._settingsTabFactory.PopulateSyncSettingsScreen();
            }
        }

        Display.IDisplaySettingsScreen ISettingsTabScreen.Display
        {
            get
            {
                return this._settingsTabFactory.PopulateDisplaySettingsScreen();
            }
        }
    }
}