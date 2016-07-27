using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class ListItemToButtonWhite : IButton
    {
        private TestStack.White.UIItems.ListBoxItems.ListItem _listItem;

        public ListItemToButtonWhite(TestStack.White.UIItems.ListBoxItems.ListItem listItem)
        {
            this._listItem = listItem;
        }

        private void Click()
        {
            this._listItem.Click();
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
                return this._listItem.Enabled;
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
                return !(this._listItem.IsOffScreen);
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