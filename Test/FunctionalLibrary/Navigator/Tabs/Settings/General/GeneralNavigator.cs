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
    public class GeneralNavigator : NavigatorBase, IGeneralNavigator
    {
        public GeneralNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General_Button.Click();
        }

        private IApplicationNavigator Application
        {
            get
            {
                return new Application.ApplicationNavigator();
            }
        }

        IApplicationNavigator IGeneralNavigator.Application
        {
            get
            {
                return this.Application;
            }
        }

        private ICheckingMailNavigator Checking_Mail
        {
            get
            {
                return new CheckingMail.CheckingMailNavigator();
            }
        }

        ICheckingMailNavigator IGeneralNavigator.Checking_Mail
        {
            get
            {
                return this.Checking_Mail;
            }
        }

        private INotificationsNavigator Notifications
        {
            get
            {
                return new Notifications.NotificationsNavigator();
            }
        }

        INotificationsNavigator IGeneralNavigator.Notifications
        {
            get
            {
                return this.Notifications;
            }
        }

        private IPerformanceNavigator Performance
        {
            get
            {
                return new Performance.PerformanceNavigator();
            }
        }

        IPerformanceNavigator IGeneralNavigator.Performance
        {
            get
            {
                return this.Performance;
            }
        }

        private IUpdatesNavigator Updates
        {
            get
            {
                return new Updates.UpdatesNavigator();
            }
        }

        IUpdatesNavigator IGeneralNavigator.Updates
        {
            get
            {
                return this.Updates;
            }
        }

        private IWashingMailNavigator Washing_Mail
        {
            get
            {
                return new WashingMail.WashingMailNavigator();
            }
        }

        IWashingMailNavigator IGeneralNavigator.Washing_Mail
        {
            get
            {
                return this.Washing_Mail;
            }
        }
    }
}