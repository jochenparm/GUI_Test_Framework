using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Tab
{
    public interface ITab : IUiMapItem
    {
        void Open();

        bool IsOpened { get; }
    }
}