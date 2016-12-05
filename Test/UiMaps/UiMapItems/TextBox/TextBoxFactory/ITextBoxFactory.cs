using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.TextBox.TextBoxFactory
{
    public interface ITextBoxFactory
    {
        ITextBox GetTextBox(object textBox, string textBoxName);
    }
}