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
    public class AccountsNavigator : NavigatorBase, IAccountsNavigator
    {
        public AccountsNavigator()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.Accounts_Button.Click();
        }

        private IGeneralNavigator General
        {
            get
            {
                return new General.GeneralNavigator();
            }
        }

        IGeneralNavigator IAccountsNavigator.General
        {
            get
            {
                return this.General;
            }
        }

        private IIMAPNavigator IMAP
        {
            get
            {
                return new IMAP.IMAPNavigator();
            }
        }

        IIMAPNavigator IAccountsNavigator.IMAP
        {
            get
            {
                return this.IMAP;
            }
        }

        private IIncomingNavigator Incoming
        {
            get
            {
                return new Incoming.IncomingNavigator();
            }
        }

        IIncomingNavigator IAccountsNavigator.Incoming
        {
            get
            {
                return this.Incoming;
            }
        }

        private IOutgoingNavigator Outgoing
        {
            get
            {
                return new Outgoing.OutgoingNavigator();
            }
        }

        IOutgoingNavigator IAccountsNavigator.Outgoing
        {
            get
            {
                return this.Outgoing;
            }
        }
    }
}