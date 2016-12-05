using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Button.ButtonFactory
{
    public interface IButtonFactory
    {
        IButton GetButton(Object button, string buttonName);
    }
}