﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.General.WashingMail
{
    public class WashingMail : NavigatorBase, IWashingMail
    {
        public WashingMail()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Washing_Mail_Button.Click();
        }
    }
}