using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Settings.Accounts
{
    public class Accounts : NavigatorBase, IAccounts
    {
        public Accounts()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts_Button.Click();
        }

        public General.IGeneral General
        {
            get
            {
                return new General.General();
            }
        }

        public IMAP.IIMAP IMAP
        {
            get
            {
                return new IMAP.IMAP();
            }
        }

        public Incoming.IIncoming Incoming
        {
            get
            {
                return new Incoming.Incoming();
            }
        }

        public Outgoing.IOutgoing Outgoing
        {
            get
            {
                return new Outgoing.Outgoing();
            }
        }
    }
}