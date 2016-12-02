using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings;
using Test.FunctionalLibrary.Tabs.Inbox;

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

        ISettings ITabs.Settings

        {
            get
            {
                throw private newNotImplementedException();
    }
}
    }
}