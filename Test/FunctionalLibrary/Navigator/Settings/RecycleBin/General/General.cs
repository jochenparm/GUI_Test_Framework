using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.RecycleBin.General
{
    public class General : NavigatorBase, IGeneral
    {
        public General()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin.General_Button.Click();
        }
    }
}