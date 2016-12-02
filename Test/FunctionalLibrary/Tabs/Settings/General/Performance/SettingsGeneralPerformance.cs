using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Performance
{
    public class SettingsGeneralPerformance : ISettingsGeneralPerformance
    {
        public SettingsGeneralPerformance()
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance_Button.Click();
        }

        private void Collapse_Group_Header_On_Check_Mail(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Collapse_Group_Header_On_Check_Mail_CheckBox.Set(enable);
        }

        ISettingsGeneralPerformance ISettingsGeneralPerformance.Collapse_Group_Header_On_Check_Mail(bool enable)
        {
            this.Collapse_Group_Header_On_Check_Mail(enable);
            return this;
        }

        private void Enable_Fast_Scrolling(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Enable_Fast_Scrolling_CheckBox.Set(enable);
        }

        ISettingsGeneralPerformance ISettingsGeneralPerformance.Enable_Fast_Scrolling(bool enable)
        {
            this.Enable_Fast_Scrolling(enable);
            return this;
        }

        private void Enable_For_Screenreaders(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Enable_For_Screenreaders_CheckBox.Set(enable);
        }

        ISettingsGeneralPerformance ISettingsGeneralPerformance.Enable_For_Screenreaders(bool enable)
        {
            this.Enable_For_Screenreaders(enable);
            return this;
        }

        private void Only_Display_Emails_Upon_Check_Mail_Completion(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Only_Display_Emails_Upon_Check_Mail_Completion_CheckBox.Set(enable);
        }

        ISettingsGeneralPerformance ISettingsGeneralPerformance.Only_Display_Emails_Upon_Check_Mail_Completion(bool enable)
        {
            this.Only_Display_Emails_Upon_Check_Mail_Completion(enable);
            return this;
        }

        private void Save()
        {
            if(MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Save_Button.IsActive)
            {
                MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Save_Button.Click();
            }
        }

        ISettingsGeneralPerformance ISettingsGeneralPerformance.Save()
        {
            throw new NotImplementedException();
        }

        private void Set_Maximum_Character_Count(int characterCount)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Maximum_Character_Count_Slider.Value = characterCount;
        }

        ISettingsGeneralPerformance ISettingsGeneralPerformance.Set_Maximum_Character_Count(int characterCount)
        {
            this.Set_Maximum_Character_Count(characterCount);
            return this;
        }

        private void Set_Number_Of_Lines_Downloaded_Per_Email(int numberOfLines)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Maximum_Character_Count_Slider.Value = numberOfLines;
        }

        ISettingsGeneralPerformance ISettingsGeneralPerformance.Set_Number_Of_Lines_Downloaded_Per_Email(int numberOfLines)
        {
            this.Set_Number_Of_Lines_Downloaded_Per_Email(numberOfLines);
            return this;
        }

        private void Use_Low_Quality_Animation(bool enable)
        {
            MailWasher.UiMap.MainWindow.Tabs.Settings.General.Performance.Use_Low_Quality_Animation_CheckBox.Set(enable);
        }

        ISettingsGeneralPerformance ISettingsGeneralPerformance.Use_Low_Quality_Animation(bool enable)
        {
            this.Use_Low_Quality_Animation(enable);
            return this;
        }
    }
}