﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Inbox
{
    public class Inbox : NavigatorBase, IInbox
    {
        public Inbox()
        {
            MailWasher.UiMap.MainWindow.Inbox_Tab.Open();
        }
    }
}