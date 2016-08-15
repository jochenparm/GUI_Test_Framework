using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.TextBox
{
    public interface ITextBox : IUiMapItem
    {
        string Content { get; set; }
    }
}