namespace Test.UiMaps.UiMapItems.TextLabel
{
    internal class TextLabelWhite : ITextLabel
    {
        private TestStack.White.UIItems.Label _label;

        public TextLabelWhite(TestStack.White.UIItems.Label label)
        {
            this._label = label;
        }

        private string Content
        {
            get
            {
                return this._label.Text;
            }
        }

        string ITextLabel.Content
        {
            get
            {
                return this.Content;
            }
        }

        private bool IsOnScreen
        {
            get
            {
                return !(this._label.IsOffScreen);
            }
        }

        bool ITextLabel.IsOnScreen
        {
            get
            {
                return this.IsOnScreen;
            }
        }
    }
}