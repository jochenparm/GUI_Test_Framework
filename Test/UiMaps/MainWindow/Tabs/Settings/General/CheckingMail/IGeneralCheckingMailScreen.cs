using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.CheckingMail
{
    public interface IGeneralCheckingMailScreen
    {
        UiMapItems.Slider.ISlider Spam_Throttle_Slider { get; }
        UiMapItems.Slider.ISlider Check_Throttle_Slider { get; }
        UiMapItems.Button.IButton Save_Button { get; }
        UiMapItems.Button.IButton Spam_Throttle_Reset_Button { get; }
        UiMapItems.Button.IButton Check_Throttle_Reset_Button { get; }
        UiMapItems.CheckBox.ICheckBox Check_Default_Accounts_When_MailWasher_Starts_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Periodically_Check_Mail_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Dont_Check_Mail_Between_CheckBox { get; }
        UiMapItems.TextBox.ITextBox Mail_Check_Interval_TextBox { get; }
    }
}