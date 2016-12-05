using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.TextLabel.TextLabelFactory
{
    public class TextLabelFactoryWhite : ITextLabelFactory
    {
        ITextLabel ITextLabelFactory.GetTextLabel(object textLabel, string textLabelName)
        {
            Type objectType = textLabel.GetType();
            if(textLabel is TestStack.White.UIItems.Label)
            {
                return this.ReturnTextLabelFromTextLabeWhite((TestStack.White.UIItems.Label)textLabel, textLabelName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private ITextLabel ReturnTextLabelFromTextLabeWhite(TestStack.White.UIItems.Label label, string labelName)
        {
            return new TextLabelWhite(label, labelName);
        }
    }
}