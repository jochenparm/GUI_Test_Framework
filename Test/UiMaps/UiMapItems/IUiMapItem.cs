using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems
{
    public interface IUiMapItem
    {
        void Click();

        bool IsOnScreen { get; }

        bool IsActive { get; }
    }
}