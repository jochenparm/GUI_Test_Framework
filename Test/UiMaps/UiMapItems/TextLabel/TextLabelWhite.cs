using Serilog;
using System;
using System.Reflection;

namespace Test.UiMaps.UiMapItems.TextLabel
{
    internal class TextLabelWhite : UiMapItemWhite, ITextLabel
    {
        private readonly TestStack.White.UIItems.Label _label;

        private readonly string _labelName;

        public TextLabelWhite(TestStack.White.UIItems.Label label, string LabelName)
            : base(label, LabelName)
        {
            this._label = label;

            this._labelName = LabelName;
        }

        string ITextLabel.Content
        {
            get
            {
                try
                {
                    string returnValue = this.Content;
                    Log.Debug("Returned {PropertyName:l} property of {LabelName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._labelName);
                    return returnValue;
                }
                catch(Exception)
                {
                    Log.Fatal("Failed to return {PropertyName:l} property of {LabelName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._labelName);
                    throw;
                }
            }
        }

        private string Content
        {
            get
            {
                return this._label.Text;
            }
        }
    }
}