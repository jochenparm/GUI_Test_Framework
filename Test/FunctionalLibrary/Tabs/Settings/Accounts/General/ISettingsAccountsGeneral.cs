using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.Accounts.General
{
    public interface ISettingsAccountsGeneral
    {
        ISettingsAccountsGeneral Set_Account_Description(string accountName);

        ISettingsAccountsGeneral Set_Account_Email_Address(string accountEmailAddress);

        ISettingsAccountsGeneral Include_In_Default_Mail_Check(bool enable);

        ISettingsAccountsGeneral Save();
    }
}