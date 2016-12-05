using System.Reflection;
using Test.UiMaps.MainWindow.Tabs.Settings.General.Factory;
using Test.UiMaps.UiMapItems.Button.ButtonFactory;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General
{
    public class GeneralSettingsScreenWhite : AppScreen, IGeneralSettingsScreen
    {
        private readonly IGeneralSettingsFactory _generalSettingsFactory;
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public GeneralSettingsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._generalSettingsFactory = new GeneralSettingsFactoryWhite(screenRepository);
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.ListBoxItems.ListItem LstBxItmCheckMail; // Button 'Checking Mail'
        private TestStack.White.UIItems.ListBoxItems.ListItem LstBxItmNotifications; // Button 'Notifications'
        private TestStack.White.UIItems.ListBoxItems.ListItem LstBxItmWashMail; // Button 'Washing Mail'
        private TestStack.White.UIItems.ListBoxItems.ListItem LstBxItmPerformance; // Button 'Performance'
        private TestStack.White.UIItems.ListBoxItems.ListItem LstBxItmUpdate; // Button 'Updates'
        private TestStack.White.UIItems.ListBoxItems.ListItem LstBxItmApplication; // Button 'Application'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        Application.IGeneralApplicationScreen IGeneralSettingsScreen.Application
        {
            get
            {
                return this._generalSettingsFactory.PopulateGeneralApplicationScreen();
            }
        }

        CheckingMail.IGeneralCheckingMailScreen IGeneralSettingsScreen.Checking_Mail
        {
            get
            {
                return this._generalSettingsFactory.PopulateGeneralCheckingMailScreen();
            }
        }

        Notifications.IGeneralNotificationsScreen IGeneralSettingsScreen.Notifications
        {
            get
            {
                return this._generalSettingsFactory.PopulateGeneralNotificationsScreen();
            }
        }

        WashingMail.IGeneralWashingMailScreen IGeneralSettingsScreen.Washing_Mail
        {
            get
            {
                return this._generalSettingsFactory.PopulateGeneralWashingMailScreen();
            }
        }

        Performance.IGeneralPerformanceScreen IGeneralSettingsScreen.Performance
        {
            get
            {
                return this._generalSettingsFactory.PopulateGeneralPerformanceScreen();
            }
        }

        Updates.IGeneralUpdatesScreen IGeneralSettingsScreen.Updates
        {
            get
            {
                return this._generalSettingsFactory.PopulateGeneralUpdatesScreen();
            }
        }

        private UiMapItems.Button.IButton Application_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.LstBxItmApplication, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralSettingsScreen.Application_Button
        {
            get
            {
                return this.Application_Button;
            }
        }

        private UiMapItems.Button.IButton Checking_Mail_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.LstBxItmCheckMail, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralSettingsScreen.Checking_Mail_Button
        {
            get
            {
                return this.Checking_Mail_Button;
            }
        }

        private UiMapItems.Button.IButton Notifications_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.LstBxItmNotifications, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralSettingsScreen.Notifications_Button
        {
            get
            {
                return this.Notifications_Button;
            }
        }

        private UiMapItems.Button.IButton Washing_Mail_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.LstBxItmWashMail, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralSettingsScreen.Washing_Mail_Button
        {
            get
            {
                return this.Washing_Mail_Button;
            }
        }

        private UiMapItems.Button.IButton Performance_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.LstBxItmPerformance, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralSettingsScreen.Performance_Button
        {
            get
            {
                return this.Performance_Button;
            }
        }

        private UiMapItems.Button.IButton Updates_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.LstBxItmUpdate, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IGeneralSettingsScreen.Updates_Button
        {
            get
            {
                return this.Updates_Button;
            }
        }
    }
}