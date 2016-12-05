using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.Accounts.Outgoing
{
    public enum SecureConnectionProtocols
    {
        None,
        SSL,
        TLS,
        CRAM_MD5,
        NTLM
    }

    public interface ISettingsAccountsOutgoing
    {
        ISettingsAccountsOutgoing Set_SMTP_Server_Address(string serverAddress);

        ISettingsAccountsOutgoing Set_Server_Port_Number(int portNumber);

        ISettingsAccountsOutgoing SMTP_Server_Requires_Authentication(bool enable);

        ISettingsAccountsOutgoing Set_Authentication_Same_As_Incoming_Server();

        ISettingsAccountsOutgoing Set_Authentication_Custom(string username, string password);

        ISettingsAccountsOutgoing Set_Secure_Connection_Protocol(SecureConnectionProtocols protocol);

        ISettingsAccountsOutgoing Save();
    }
}