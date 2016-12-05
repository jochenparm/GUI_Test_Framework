using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Tabs.Settings.General.Application;
using Test.FunctionalLibrary.Tabs.Settings.General.Checking_Mail;
using Test.FunctionalLibrary.Tabs.Settings.General.Notifications;
using Test.FunctionalLibrary.Tabs.Settings.General.Performance;
using Test.FunctionalLibrary.Tabs.Settings.General.Updates;
using Test.FunctionalLibrary.Tabs.Settings.General.Washing_Mail;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Factory
{
    internal class FunctionalSettingsGeneralFactory : IFunctionalSettingsGeneralFactory
    {
        private ISettingsGeneralCheckingMail Get_Checking_Mail()
        {
            return new Checking_Mail.SettingsGeneralCheckingMail();
        }

        ISettingsGeneralCheckingMail IFunctionalSettingsGeneralFactory.Get_Checking_Mail()
        {
            return this.Get_Checking_Mail();
        }

        private ISettingsGeneralApplication Get_Application()
        {
            return new Application.SettingsGeneralApplication();
        }

        ISettingsGeneralApplication IFunctionalSettingsGeneralFactory.Get_Application()
        {
            return this.Get_Application();
        }

        private ISettingsGeneralNotifications Get_Notifications()
        {
            return new Notifications.SettingsGeneralNotifications();
        }

        ISettingsGeneralNotifications IFunctionalSettingsGeneralFactory.Get_Notifications()
        {
            return this.Get_Notifications();
        }

        private ISettingsGeneralPerformance Get_Performance()
        {
            return new Performance.SettingsGeneralPerformance();
        }

        ISettingsGeneralPerformance IFunctionalSettingsGeneralFactory.Get_Performance()
        {
            return this.Get_Performance();
        }

        private ISettingsGeneralUpdates Get_Updates()
        {
            return new Updates.SettingsGeneralUpdates();
        }

        ISettingsGeneralUpdates IFunctionalSettingsGeneralFactory.Get_Updates()
        {
            return this.Get_Updates();
        }

        private ISettingsGeneralWashingMail Get_Washing_Mail()
        {
            return new Washing_Mail.SettingsGeneralWashingMail();
        }

        ISettingsGeneralWashingMail IFunctionalSettingsGeneralFactory.Get_Washing_Mail()
        {
            return this.Get_Washing_Mail();
        }
    }
}