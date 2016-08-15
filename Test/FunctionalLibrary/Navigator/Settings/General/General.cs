using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.General
{
    public class General : NavigatorBase, IGeneral
    {
        public General()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General_Button.Click();
        }

        public Application.IApplication Application
        {
            get
            {
                return new Application.Application();
            }
        }

        public CheckingMail.ICheckingMail Checking_Mail
        {
            get
            {
                return new CheckingMail.CheckingMail();
            }
        }

        public Notifications.INotifications Notifications
        {
            get
            {
                return new Notifications.Notifications();
            }
        }

        public Performance.IPerformance Performance
        {
            get
            {
                return new Performance.Performance();
            }
        }

        public Updates.IUpdates Updates
        {
            get
            {
                return new Updates.Updates();
            }
        }

        public WashingMail.IWashingMail Washing_Mail
        {
            get
            {
                return new WashingMail.WashingMail();
            }
        }
    }
}