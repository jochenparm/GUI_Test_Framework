using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.RecycleBin
{
    public class RecycleBin : NavigatorBase, IRecycleBin
    {
        public RecycleBin()
        {
            MailWasher.UiMap.MainWindow.RecycleBinTab_Button.Click();
        }
    }
}