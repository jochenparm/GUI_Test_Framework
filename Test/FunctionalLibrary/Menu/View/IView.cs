using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Menu.View
{
    public interface IView
    {
        IView Preview_Pane(bool enable);

        IView Preview_Pane_Graphic(bool enable);

        IView Side_Bar(bool enable);

        IView Always_Show_Event_Log(bool enable);

        IView Open_Tutorial_Video();

        IView Show_Hidden_Mails(bool enable);
    }
}