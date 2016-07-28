using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.EventLog
{
    public class EventLog : NavigatorBase, IEventLog
    {
        public EventLog()
        {
            MailWasher.UiMap.MainWindow.EventLogTab_Button.Click();
        }
    }
}