using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Tabs.Settings.General.Application;
using Test.FunctionalLibrary.Tabs.Settings.General.Checking_Mail;
using Test.FunctionalLibrary.Tabs.Settings.General.Factory;
using Test.FunctionalLibrary.Tabs.Settings.General.Notifications;
using Test.FunctionalLibrary.Tabs.Settings.General.Performance;
using Test.FunctionalLibrary.Tabs.Settings.General.Updates;
using Test.FunctionalLibrary.Tabs.Settings.General.Washing_Mail;

namespace Test.FunctionalLibrary.Tabs.Settings.General
{
    public class SettingsGeneral : ISettingsGeneral
    {
        private readonly IFunctionalSettingsGeneralFactory _settingsGeneralFactory;

        public SettingsGeneral()
        {
            MailWasher.Navigator.Tabs.Settings.General.Navigate();
            this._settingsGeneralFactory = new FunctionalSettingsGeneralFactory();
        }

        ISettingsGeneralApplication ISettingsGeneral.Application
        {
            get
            {
                return this._settingsGeneralFactory.Get_Application();
            }
        }

        ISettingsGeneralCheckingMail ISettingsGeneral.Checking_Mail
        {
            get
            {
                return this._settingsGeneralFactory.Get_Checking_Mail();
            }
        }

        ISettingsGeneralNotifications ISettingsGeneral.Notifications
        {
            get
            {
                return this._settingsGeneralFactory.Get_Notifications();
            }
        }

        ISettingsGeneralPerformance ISettingsGeneral.Performance
        {
            get
            {
                return this._settingsGeneralFactory.Get_Performance();
            }
        }

        ISettingsGeneralUpdates ISettingsGeneral.Updates
        {
            get
            {
                return this._settingsGeneralFactory.Get_Updates();
            }
        }

        ISettingsGeneralWashingMail ISettingsGeneral.Washing_Mail
        {
            get
            {
                return this._settingsGeneralFactory.Get_Washing_Mail();
            }
        }
    }
}