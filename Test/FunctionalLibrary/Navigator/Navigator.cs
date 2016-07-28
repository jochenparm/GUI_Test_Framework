using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator
{
    public class Navigator : INavigator
    {
        public Navigator()
        {
        }

        private Inbox.IInbox Inbox
        {
            get
            {
                return new Inbox.Inbox();
            }
        }

        Inbox.IInbox INavigator.Inbox
        {
            get
            {
                return this.Inbox;
            }
        }

        private RecycleBin.IRecycleBin RecycleBin
        {
            get
            {
                return new RecycleBin.RecycleBin();
            }
        }

        RecycleBin.IRecycleBin INavigator.RecycleBin
        {
            get
            {
                return this.RecycleBin;
            }
        }

        private Settings.ISettings Settings
        {
            get
            {
                return new Settings.Settings();
            }
        }

        Settings.ISettings INavigator.Settings
        {
            get
            {
                return this.Settings;
            }
        }

        private EventLog.IEventLog EventLog
        {
            get
            {
                return new EventLog.EventLog();
            }
        }

        EventLog.IEventLog INavigator.EventLog
        {
            get
            {
                return this.EventLog;
            }
        }
    }
}