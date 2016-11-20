using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Application;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.CheckingMail;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Notifications;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Performance;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Updates;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.General.WashingMail;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.General
{
    public class General : NavigatorBase, IGeneral
    {
        public General()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General_Button.Click();
        }

        private IApplication Application
        {
            get
            {
                return new Application.Application();
            }
        }

        IApplication IGeneral.Application
        {
            get
            {
                return this.Application;
            }
        }

        private ICheckingMail Checking_Mail
        {
            get
            {
                return new CheckingMail.CheckingMail();
            }
        }

        ICheckingMail IGeneral.Checking_Mail
        {
            get
            {
                return this.Checking_Mail;
            }
        }

        private INotifications Notifications
        {
            get
            {
                return new Notifications.Notifications();
            }
        }

        INotifications IGeneral.Notifications
        {
            get
            {
                return this.Notifications;
            }
        }

        private IPerformance Performance
        {
            get
            {
                return new Performance.Performance();
            }
        }

        IPerformance IGeneral.Performance
        {
            get
            {
                return this.Performance;
            }
        }

        private IUpdates Updates
        {
            get
            {
                return new Updates.Updates();
            }
        }

        IUpdates IGeneral.Updates
        {
            get
            {
                return this.Updates;
            }
        }

        private IWashingMail Washing_Mail
        {
            get
            {
                return new WashingMail.WashingMail();
            }
        }

        IWashingMail IGeneral.Washing_Mail
        {
            get
            {
                return this.Washing_Mail;
            }
        }
    }
}