using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Menu.View
{
    public interface IView
    {
        IView Enable_Preview_Pane();

        IView Disable_Preview_Pane();

        IView Enable_Preview_Pane_Graphic();

        IView Disable_Preview_Pane_Graphic();

        IView Enable_Side_Bar();

        IView Disable_Side_Bar();

        IView Enable_Always_Show_Event_Log();

        IView Disable_Always_Show_Event_Log();

        IView Open_Tutorial_Video();

        IView Show_Hidden_Mails();

        IView Hide_Hidden_Mails();
    }
}