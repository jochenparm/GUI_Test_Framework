using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Performance
{
    public interface ISettingsGeneralPerformance
    {
        ISettingsGeneralPerformance Use_Low_Quality_Animation(bool enable);

        ISettingsGeneralPerformance Enable_Fast_Scrolling(bool enable);

        ISettingsGeneralPerformance Collapse_Group_Header_On_Check_Mail(bool enable);

        ISettingsGeneralPerformance Only_Display_Emails_Upon_Check_Mail_Completion(bool enable);

        ISettingsGeneralPerformance Enable_For_Screenreaders(bool enable);

        ISettingsGeneralPerformance Set_Number_Of_Lines_Downloaded_Per_Email(int numberOfLines);

        ISettingsGeneralPerformance Set_Maximum_Character_Count(int characterCount);

        ISettingsGeneralPerformance Save();
    }
}