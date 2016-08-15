namespace Test.UiMaps.UiMapItems.TextLabel
{
    internal class TextLabelWhite : UiMapItemWhite, ITextLabel
    {
        private TestStack.White.UIItems.Label _label;

        public TextLabelWhite(TestStack.White.UIItems.Label label)
            : base(label)
        {
            this._label = label;
        }

        public string Content
        {
            get
            {
                return this._label.Text;
            }
        }
    }
}