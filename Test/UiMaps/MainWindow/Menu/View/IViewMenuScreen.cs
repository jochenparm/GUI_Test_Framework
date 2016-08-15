using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Menu.View
{
    public interface IViewMenuScreen
    {
        UiMapItems.Button.IButton Preview_Pane_Button { get; }
        UiMapItems.Button.IButton Preview_Pane_Graphic_Button { get; }
        UiMapItems.Button.IButton Side_Bar_Button { get; }
        UiMapItems.Button.IButton Always_Show_Event_Log_Button { get; }
        UiMapItems.Button.IButton Tutorial_Video_Button { get; }
        UiMapItems.Button.IButton Show_Hidden_Emails_Button { get; }
    }
}