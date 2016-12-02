using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Washing_Mail
{
    public interface ISettingsGeneralWashingMail
    {
        ISettingsGeneralWashingMail Minimize_MailWasher_After_Wash_Mail(bool enable);

        ISettingsGeneralWashingMail Launch_After_Wash_Mail(bool enable);

        ISettingsGeneralWashingMail Use_Default_Email_Program_Icon(bool enable);

        ISettingsGeneralWashingMail Save();
    }
}