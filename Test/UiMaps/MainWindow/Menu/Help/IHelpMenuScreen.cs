using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Menu.Help
{
    public interface IHelpMenuScreen
    {
        UiMapItems.Button.IButton Help_Topics_Button { get; }
        UiMapItems.Button.IButton Forums_Button { get; }
        UiMapItems.Button.IButton Tell_A_Friend_Button { get; }
        UiMapItems.Button.IButton Registration_Button { get; }
        UiMapItems.Button.IButton User_Files_Button { get; }
        UiMapItems.Button.IButton Common_Files_Button { get; }
        UiMapItems.CheckBox.ICheckBox Log_Protocol_CheckBox { get; }
        UiMapItems.Button.IButton Send_Support_Logs_Button { get; }
        UiMapItems.Button.IButton Check_For_Updates_Button { get; }
        UiMapItems.Button.IButton About_Button { get; }
    }
}