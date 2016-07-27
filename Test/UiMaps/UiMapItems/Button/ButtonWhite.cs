using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class ButtonWhite : IButton
    {
        private TestStack.White.UIItems.Button _button;

        public ButtonWhite(TestStack.White.UIItems.Button button)
        {
            this._button = button;
        }

        private void Click()
        {
            this._button.Click();
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
                return this._button.Enabled;
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
                return !(this._button.IsOffScreen);
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