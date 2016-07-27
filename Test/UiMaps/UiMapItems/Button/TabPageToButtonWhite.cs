using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class TabPageToButtonWhite : IButton
    {
        private TestStack.White.UIItems.TabItems.TabPage _tabPage;

        public TabPageToButtonWhite(TestStack.White.UIItems.TabItems.TabPage tabPage)
        {
            this._tabPage = tabPage;
        }

        private void Click()
        {
            this._tabPage.Click();
            Thread.Sleep(200);
        }

        void IButton.Click()
        {
            this.Click();
        }

        private bool IsEnabled
        {
            get
            {
                return this._tabPage.Enabled;
            }
        }

        bool IButton.IsEnabled
        {
            get
            {
                return this.IsEnabled;
            }
        }

        private bool IsOnScreen
        {
            get
            {
                return !(this._tabPage.IsOffScreen);
            }
        }

        bool IButton.IsOnScreen
        {
            get
            {
                return this.IsOnScreen;
            }
        }
    }
}