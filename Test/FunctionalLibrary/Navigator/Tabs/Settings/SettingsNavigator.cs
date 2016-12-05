using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings
{
    public class SettingsNavigator : NavigatorBase, ISettingsNavigator
    {
        public SettingsNavigator()
        {
            MailWasher.UiMap.MainWindow.Settings_Tab.Open();
        }

        public Accounts.IAccountsNavigator Accounts
        {
            get
            {
                return new Accounts.AccountsNavigator();
            }
        }

        public Sync.ISyncNavigator Sync
        {
            get
            {
                return new Sync.SyncNavigator();
            }
        }

        public General.IGeneralNavigator General
        {
            get
            {
                return new General.GeneralNavigator();
            }
        }

        public RecycleBin.IRecycleBinNavigator RecycleBin
        {
            get
            {
                return new RecycleBin.RecycleBinNavigator();
            }
        }
    }
}