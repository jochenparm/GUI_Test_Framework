using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Checking_Mail
{
    public interface ISettingsGeneralCheckingMail
    {
        ISettingsGeneralCheckingMail Check_Default_Accounts_When_MailWasher_Starts(bool enable);

        ISettingsGeneralCheckingMail Periodically_Check_Mail(bool enable);

        ISettingsGeneralCheckingMail Set_Check_Period(int minutes);

        ISettingsGeneralCheckingMail Set_Spam_Throttle(int numberOfLines);

        ISettingsGeneralCheckingMail Reset_Spam_Throttle();

        ISettingsGeneralCheckingMail Set_Check_Throttle(int numberOfAccounts);

        ISettingsGeneralCheckingMail Reset_Check_Throttle();

        ISettingsGeneralCheckingMail Save();
    }
}