using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.Accounts.Incoming
{
    public enum ServerTypes
    {
        POP3,
        IMAP
    }

    public interface ISettingsAccountsIncoming
    {
        ISettingsAccountsIncoming Set_Server_Type(ServerTypes type);

        ISettingsAccountsIncoming Set_Server_Address(string address);

        ISettingsAccountsIncoming Set_Username(string username);

        ISettingsAccountsIncoming Set_Password(string password);

        ISettingsAccountsIncoming Remember_Password(bool enable);

        ISettingsAccountsIncoming Store_Cached_Emails(bool enable);

        ISettingsAccountsIncoming Set_Server_Port_Number(int portNumber);

        ISettingsAccountsIncoming This_Server_Requires_A_Secure_Connection(bool enable);

        ISettingsAccountsIncoming Use_OAUTH(bool enable);

        ISettingsAccountsIncoming Download_Read_Emails(bool enable);

        ISettingsAccountsIncoming Save();
    }
}