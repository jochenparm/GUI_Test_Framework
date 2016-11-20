using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Menu.Email
{
    public interface IEmail
    {
        IEmail Add_Sender_To_Friends_List();

        IEmail Add_Domain_To_Friends_List();

        IEmail Remove_Sender_From_Friends_List();

        IEmail Add_Sender_To_Blacklist();

        IEmail Add_Domain_To_Blacklist();

        IEmail Remove_Sender_From_Blacklist();

        IEmail Mark_As_Spam();

        IEmail Mark_As_Good();

        IEmail Mark_For_Delete();

        IEmail Unmark_Delete();

        IEmail Mark_All_For_Delete();

        IEmail Mark_For_Bounce();

        IEmail Quick_Reply();

        IEmail Quick_Forward();

        IEmail Download_Full();

        IEmail Clear_Message_List();
    }
}