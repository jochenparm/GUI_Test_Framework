using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.EventLog.ToolBar.Factory
{
    internal interface IEventLogToolBarFactory
    {
        IEventLogToolBarScreen PopulateEventLogToolBarScreen();
    }
}