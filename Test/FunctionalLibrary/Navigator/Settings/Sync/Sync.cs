using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.Sync
{
    public class Sync : NavigatorBase, ISync
    {
        public Sync()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Sync_Button.Click();
        }
    }
}