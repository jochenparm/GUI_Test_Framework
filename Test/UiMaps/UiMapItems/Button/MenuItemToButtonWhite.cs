using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class MenuItemToButtonWhite : IButton
    {
        private TestStack.White.UIItems.MenuItems.Menu _menuItem;

        public MenuItemToButtonWhite(TestStack.White.UIItems.MenuItems.Menu menuItem)
        {
            this._menuItem = menuItem;
        }

        private void Click()
        {
            this._menuItem.Click();
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
                return this._menuItem.Enabled;
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
                return !(this._menuItem.IsOffScreen);
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