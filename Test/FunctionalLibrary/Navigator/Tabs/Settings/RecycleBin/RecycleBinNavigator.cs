using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.RecycleBin
{
    public class RecycleBinNavigator : NavigatorBase, IRecycleBinNavigator
    {
        public RecycleBinNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin_Button.Click();
        }

        public General.IGeneralNavigator General
        {
            get
            {
                return new General.GeneralNavigator();
            }
        }

        public Restoring.IRestoringNavigator Restoring
        {
            get
            {
                return new Restoring.RestoringNavigator();
            }
        }
    }
}