using Test.UiMaps.MainWindow.Tabs.Inbox.ToolBar;
using Test.UiMaps.MainWindow.Tabs.Inbox.ToolBar.Factory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Inbox
{
    public class InboxTabScreenWhite : AppScreen, IInboxTabScreen
    {
        private readonly IInboxToolBarFactory _toolBarFactory;

        public InboxTabScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._toolBarFactory = new InboxToolBarFactoryWhite(screenRepository);
        }

        public IInboxToolBarScreen ToolBar
        {
            get
            {
                return this._toolBarFactory.PopulateInboxToolBarScreen();
            }
        }
    }
}