using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Menu.Help
{
    public interface IHelp
    {
        IHelp Open_Help_Topics();

        IHelp Open_Forums();

        IHelp Open_Tell_A_Friend_Form();

        IHelp Open_Registration_Form();

        IHelp Open_User_Files();

        IHelp Open_Common_Files();

        IHelp Log_Protocol(bool enable);

        IHelp Open_Send_Support_Logs_Form();

        IHelp Check_For_Updates();

        IHelp Open_About_Window();
    }
}