using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.TextLabel.TextLabelFactory
{
    public interface ITextLabelFactory
    {
        ITextLabel GetTextLabel(object textLabel, string textLabelName);
    }
}