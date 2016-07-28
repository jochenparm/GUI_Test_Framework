using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Notifications
{
    public interface IGeneralNotificationsScreen
    {
        UiMapItems.CheckBox.ICheckBox Display_Balloon_Notification_When_New_Mail_Arrives_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Play_Sound_When_New_Mail_Arrives_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Dont_Notify_Me_When_Mail_Is_Spam_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Play_Sound_When_Error_Occurs_CheckBox { get; }
        UiMapItems.Button.IButton Save_Button { get; }
        UiMapItems.Button.IButton Display_Duration_Reset_Button { get; }
        UiMapItems.Slider.ISlider Display_Duration_Slider { get; }
        UiMapItems.TextBox.ITextBox New_Mail_Sound_Path_TextBox { get; }
    }
}