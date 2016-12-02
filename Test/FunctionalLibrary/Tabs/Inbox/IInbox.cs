using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Inbox
{
    public interface IInbox
    {
        IInbox Check_Email(string accountName);

        IInbox Check_All_Email();

        IInbox Stop_Checking_Email();

        IInbox Wash_Mail();

        IInbox Open_Mail_Program();

        IInbox Open_Registration_Form();

        bool Is_Checking_Email { get; }

        bool Wait_For_Is_Checking_Email(int seconds);

        bool Wait_For_Isnt_Checking_Email(int seconds);
    }
}