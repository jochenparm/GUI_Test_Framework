using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class TabPageToButtonWhite : UiMapItemWhite, IButton
    {
        private readonly TestStack.White.UIItems.TabItems.TabPage _tabPage;

        public TabPageToButtonWhite(TestStack.White.UIItems.TabItems.TabPage tabPage)
            : base(tabPage)
        {
            this._tabPage = tabPage;
        }
    }
}