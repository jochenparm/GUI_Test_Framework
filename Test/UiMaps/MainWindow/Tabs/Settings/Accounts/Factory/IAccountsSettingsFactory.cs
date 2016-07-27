using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.General;
using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.IMAP;
using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Incoming;
using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Outgoing;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Factory
{
    internal interface IAccountsSettingsFactory
    {
        IAccountsGeneralScreen PopulateAccountsGeneralScreen();

        IAccountsIMAPScreen PopulateAccountsIMAPScreen();

        IAccountsIncomingScreen PopulateAccountsIncomingScreen();

        IAccountsOutgoingScreen PopulateAccountsOutgoingScreen();
    }
}