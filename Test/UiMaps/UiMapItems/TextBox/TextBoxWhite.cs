using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.TextBox
{
    public class TextBoxWhite : ITextBox
    {
        private TestStack.White.UIItems.TextBox _textBox;

        public TextBoxWhite(TestStack.White.UIItems.TextBox textBox)
        {
            this._textBox = textBox;
        }

        private bool IsOnScreen
        {
            get
            {
                return !(this._textBox.IsOffScreen);
            }
        }

        bool ITextBox.IsOnScreen
        {
            get
            {
                return this.IsOnScreen;
            }
        }

        private string Content
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

        string ITextBox.Content
        {
            get
            {
                return this.Content;
            }
            set
            {
                this.Content = value;
            }
        }

        private bool IsEnabled
        {
            get
            {
                return this._textBox.Enabled;
            }
        }

        bool ITextBox.IsEnabled
        {
            get
            {
                return this.IsEnabled;
            }
        }
    }
}