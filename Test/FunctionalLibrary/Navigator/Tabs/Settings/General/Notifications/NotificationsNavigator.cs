using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.General.Notifications
{
    public class NotificationsNavigator : NavigatorBase, INotificationsNavigator
    {
        public NotificationsNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Notifications_Button.Click();
        }
    }
}