using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Tabs.Inbox;
using Test.FunctionalLibrary.Tabs.Settings;

namespace Test.FunctionalLibrary.Tabs
{
    public class Tabs : ITabs
    {
        private Inbox.IInbox Inbox
        {
            get
            {
                return new Inbox.Inbox();
            }
        }

        IInbox ITabs.Inbox
        {
            get
            {
                return this.Inbox;
            }
        }

        private Settings.ISettings Settings
        {
            get
            {
                return new Settings.Settings();
            }
        }

        ISettings ITabs.Settings

        {
            get
            {
                return this.Settings;
            }
        }
    }
}