using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.EventLog;
using Test.FunctionalLibrary.Navigator.Tabs.Inbox;
using Test.FunctionalLibrary.Navigator.Tabs.RecycleBin;
using Test.FunctionalLibrary.Navigator.Tabs.Settings;

namespace Test.FunctionalLibrary.Navigator.Tabs
{
    public class Tabs : ITabs
    {
        public Tabs()
        {
        }

        private IEventLog EventLog
        {
            get
            {
                return new EventLog.EventLog();
            }
        }

        IEventLog ITabs.EventLog
        {
            get
            {
                return this.EventLog;
            }
        }

        private IInbox Inbox
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

        private IRecycleBin RecycleBin
        {
            get
            {
                return new RecycleBin.RecycleBin();
            }
        }

        IRecycleBin ITabs.RecycleBin
        {
            get
            {
                return this.RecycleBin;
            }
        }

        private ISettings Settings
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