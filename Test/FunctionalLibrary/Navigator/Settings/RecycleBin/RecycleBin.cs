using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.RecycleBin
{
    public class RecycleBin : NavigatorBase, IRecycleBin
    {
        public RecycleBin()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.RecycleBin_Button.Click();
        }

        public General.IGeneral General
        {
            get
            {
                return new General.General();
            }
        }

        public Restoring.IRestoring Restoring
        {
            get
            {
                return new Restoring.Restoring();
            }
        }
    }
}