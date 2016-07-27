using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class LabelToButtonWhite : IButton
    {
        private TestStack.White.UIItems.Label _label;

        public LabelToButtonWhite(TestStack.White.UIItems.Label label)
        {
            this._label = label;
        }

        private void Click()
        {
            this._label.Click();
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
                return this._label.Enabled;
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
                return !(this._label.IsOffScreen);
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