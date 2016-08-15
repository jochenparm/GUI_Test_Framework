using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.Tabs.EventLog.ToolBar.Factory
{
    internal class EventLogToolBarFactoryWhite : IEventLogToolBarFactory
    {
        private readonly ScreenRepository screenRepository;

        public EventLogToolBarFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        public IEventLogToolBarScreen PopulateEventLogToolBarScreen()
        {
            return this.screenRepository.Get<EventLogToolBarScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}