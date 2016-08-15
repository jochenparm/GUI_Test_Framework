using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.General.Notifications
{
    public class Notifications : NavigatorBase, INotifications
    {
        public Notifications()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications_Button.Click();
        }
    }
}