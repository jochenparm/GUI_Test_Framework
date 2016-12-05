using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.EventLog
{
    public class EventLogNavigator : NavigatorBase, IEventLogNavigator
    {
        public EventLogNavigator()
        {
            MailWasher.UiMap.MainWindow.EventLog_Tab.Open();
        }
    }
}