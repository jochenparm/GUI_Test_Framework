﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Tabs.Settings
{
    public class Settings : NavigatorBase, ISettings
    {
        public Settings()
        {
            MailWasher.UiMap.MainWindow.Settings_Tab.Open();
        }

        public Accounts.IAccounts Accounts
        {
            get
            {
                return new Accounts.Accounts();
            }
        }

        public Sync.ISync Sync
        {
            get
            {
                return new Sync.Sync();
            }
        }

        public General.IGeneral General
        {
            get
            {
                return new General.General();
            }
        }

        public RecycleBin.IRecycleBin RecycleBin
        {
            get
            {
                return new RecycleBin.RecycleBin();
            }
        }
    }
}