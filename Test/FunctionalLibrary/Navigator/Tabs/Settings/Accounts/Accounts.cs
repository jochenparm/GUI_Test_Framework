using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.General;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.IMAP;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.Incoming;
using Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts.Outgoing;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings.Accounts
{
    public class Accounts : NavigatorBase, IAccounts
    {
        public Accounts()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts_Button.Click();
        }

        private IGeneral General
        {
            get
            {
                return new General.General();
            }
        }

        IGeneral IAccounts.General
        {
            get
            {
                return this.General;
            }
        }

        private IIMAP IMAP
        {
            get
            {
                return new IMAP.IMAP();
            }
        }

        IIMAP IAccounts.IMAP
        {
            get
            {
                return this.IMAP;
            }
        }

        private IIncoming Incoming
        {
            get
            {
                return new Incoming.Incoming();
            }
        }

        IIncoming IAccounts.Incoming
        {
            get
            {
                return this.Incoming;
            }
        }

        private IOutgoing Outgoing
        {
            get
            {
                return new Outgoing.Outgoing();
            }
        }

        IOutgoing IAccounts.Outgoing
        {
            get
            {
                return this.Outgoing;
            }
        }
    }
}