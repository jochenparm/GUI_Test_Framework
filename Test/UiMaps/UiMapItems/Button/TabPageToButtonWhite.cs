using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class TabPageToButtonWhite : UiMapItemWhite, IButton
    {
        private readonly TestStack.White.UIItems.TabItems.TabPage _tabPage;

        private readonly string _buttonName;

        public TabPageToButtonWhite(TestStack.White.UIItems.TabItems.TabPage tabPage, string ButtonName)
            : base(tabPage, ButtonName)
        {
            this._tabPage = tabPage;
            this._buttonName = ButtonName;
        }
    }
}