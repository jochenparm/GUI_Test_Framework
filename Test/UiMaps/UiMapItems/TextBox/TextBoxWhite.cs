using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.TextBox
{
    public class TextBoxWhite : UiMapItemWhite, ITextBox
    {
        private TestStack.White.UIItems.TextBox _textBox;

        public TextBoxWhite(TestStack.White.UIItems.TextBox textBox)
            : base(textBox)
        {
            this._textBox = textBox;
        }

        public string Content
        {
            get
            {
                return this._textBox.Text;
            }
            set
            {
                this._textBox.BulkText = value;
            }
        }
    }
}