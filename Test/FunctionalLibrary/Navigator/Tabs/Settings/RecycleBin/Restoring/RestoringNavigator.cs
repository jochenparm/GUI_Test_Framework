using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.RecycleBin.Restoring
{
    public class RestoringNavigator : NavigatorBase, IRestoringNavigator
    {
        public RestoringNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.Restoring_Button.Click();
        }
    }
}