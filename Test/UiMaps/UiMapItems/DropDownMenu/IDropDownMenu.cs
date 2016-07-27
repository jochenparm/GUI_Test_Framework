using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.DropDownMenu
{
    public interface IDropDownMenu
    {
        void Select(string choice);

        string CurrentSelection { get; }

        bool IsOnScreen { get; }

        bool IsEnabled { get; }
    }
}