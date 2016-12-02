using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class ButtonWhite : UiMapItemWhite, IButton
    {
        private readonly TestStack.White.UIItems.Button _button;

        private readonly string _buttonName;

        public ButtonWhite(TestStack.White.UIItems.Button Button, string ButtonName)
            : base(Button, ButtonName)
        {
            this._button = Button;
            this._buttonName = ButtonName;
        }
    }
}