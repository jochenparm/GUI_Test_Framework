using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.RecycleBin.Restoring
{
    public class Restoring : NavigatorBase, IRestoring
    {
        public Restoring()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.Restoring_Button.Click();
        }
    }
}