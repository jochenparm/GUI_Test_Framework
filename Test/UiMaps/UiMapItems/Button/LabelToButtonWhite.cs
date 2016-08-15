using System.Threading;

namespace Test.UiMaps.UiMapItems.Button
{
    public class LabelToButtonWhite : UiMapItemWhite, IButton
    {
        private TestStack.White.UIItems.Label _label;

        public LabelToButtonWhite(TestStack.White.UIItems.Label label)
            : base(label)
        {
            this._label = label;
        }
    }
}