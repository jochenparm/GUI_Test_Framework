using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class LabelToButtonWhite : UiMapItemWhite, IButton
    {
        private readonly TestStack.White.UIItems.Label _label;

        private readonly string _buttonName;

        public LabelToButtonWhite(TestStack.White.UIItems.Label label, string ButtonName)
            : base(label, ButtonName)
        {
            this._label = label;
            this._buttonName = ButtonName;
        }
    }
}