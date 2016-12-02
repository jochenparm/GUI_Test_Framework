using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.TextBox
{
    public class TextBoxWhite : UiMapItemWhite, ITextBox
    {
        private readonly TestStack.White.UIItems.TextBox _textBox;

        private readonly string _textBoxName;

        public TextBoxWhite(TestStack.White.UIItems.TextBox textBox, string TextBoxName)
            : base(textBox, TextBoxName)
        {
            this._textBox = textBox;
            this._textBoxName = TextBoxName;
        }

        string ITextBox.Content
        {
            get
            {
                try
                {
                    string returnValue = this.Content;
                    Log.Debug("Returned {PropertyName:l} property of {TextBoxName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._textBoxName);
                    return returnValue;
                }
                catch(Exception)
                {
                    Log.Fatal("Failed to return {PropertyName:l} property of {TextBoxName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._textBoxName);
                    throw;
                }
            }
            set
            {
                try
                {
                    this.Content = value;
                    Log.Debug("Set {PropertyName:l} property of {TextBoxName:l}", MethodBase.GetCurrentMethod().Name.Replace("set_", ""), this._textBoxName);
                }
                catch(Exception)
                {
                    Log.Fatal("Failed to set {PropertyName:l} property of {TextBoxName:l}", MethodBase.GetCurrentMethod().Name.Replace("set_", ""), this._textBoxName);
                    throw;
                }
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
    }
}