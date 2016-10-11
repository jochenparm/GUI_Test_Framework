using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class ButtonWhite : UiMapItemWhite, IButton
    {
        private readonly TestStack.White.UIItems.Button _button;

        public ButtonWhite(TestStack.White.UIItems.Button button)
            : base(button)
        {
            this._button = button;
        }
    }
}