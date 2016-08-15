using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Performance
{
    public interface IGeneralPerformanceScreen
    {
        UiMapItems.CheckBox.ICheckBox Use_Low_Quality_Animation_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Enable_Fast_Scrolling_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Collapse_Group_Header_On_Check_Mail_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Only_Display_Emails_Upon_Check_Mail_Completion_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Enable_For_Screenreaders_CheckBox { get; }
        UiMapItems.Button.IButton Reset_Spam_Throttle_Button { get; }
        UiMapItems.Button.IButton Save_Button { get; }
        UiMapItems.Slider.ISlider Spam_Throttle_Slider { get; }
        UiMapItems.Slider.ISlider Maximum_Character_Count_Slider { get; }
    }
}