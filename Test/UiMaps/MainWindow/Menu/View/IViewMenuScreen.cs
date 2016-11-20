using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Menu.View
{
    public interface IViewMenuScreen
    {
        UiMapItems.CheckBox.ICheckBox Preview_Pane_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Preview_Pane_Graphic_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Side_Bar_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox Always_Show_Event_Log_CheckBox { get; }
        UiMapItems.Button.IButton Tutorial_Video_Button { get; }
        UiMapItems.CheckBox.ICheckBox Show_Hidden_Emails_CheckBox { get; }
    }
}