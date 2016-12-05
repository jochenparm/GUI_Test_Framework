using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.TextBox.TextBoxFactory
{
    public class TextBoxFactoryWhite : ITextBoxFactory
    {
        ITextBox ITextBoxFactory.GetTextBox(object textBox, string textBoxName)
        {
            if(textBox is TestStack.White.UIItems.TextBox)
            {
                return this.ReturnTextBoxFromTextBoxWhite((TestStack.White.UIItems.TextBox)textBox, textBoxName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private ITextBox ReturnTextBoxFromTextBoxWhite(TestStack.White.UIItems.TextBox textBox, string textBoxName)
        {
            return new TextBoxWhite(textBox, textBoxName);
        }
    }
}