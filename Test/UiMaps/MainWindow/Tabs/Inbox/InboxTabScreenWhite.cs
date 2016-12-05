using System;
using Test.UiMaps.MainWindow.Tabs.Inbox.ToolBar;
using Test.UiMaps.MainWindow.Tabs.Inbox.ToolBar.Factory;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
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

        private IInboxToolBarScreen ToolBar
        {
            get
            {
                return this._toolBarFactory.PopulateInboxToolBarScreen();
            }
        }

        IInboxToolBarScreen IInboxTabScreen.ToolBar
        {
            get
            {
                return this.ToolBar;
            }
        }
    }
}