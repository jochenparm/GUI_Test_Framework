using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.RecycleBin
{
    public class RecycleBinNavigator : NavigatorBase, IRecycleBinNavigator
    {
        public RecycleBinNavigator()
        {
            MailWasher.UiMap.MainWindow.RecycleBin_Tab.Open();
        }
    }
}