using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Inbox
{
    public class InboxNavigator : NavigatorBase, IInboxNavigator
    {
        public InboxNavigator()
        {
            MailWasher.UiMap.MainWindow.Inbox_Tab.Open();
        }
    }
}