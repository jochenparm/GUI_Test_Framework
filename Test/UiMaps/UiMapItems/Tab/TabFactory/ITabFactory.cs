using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Tab.TabFactory
{
    public interface ITabFactory
    {
        ITab GetTab(object tab, string tabName);
    }
}