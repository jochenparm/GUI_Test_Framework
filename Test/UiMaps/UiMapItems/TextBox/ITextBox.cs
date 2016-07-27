using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.TextBox
{
    public interface ITextBox
    {
        bool IsOnScreen { get; }
        string Content { get; set; }

        bool IsEnabled { get; }
    }
}