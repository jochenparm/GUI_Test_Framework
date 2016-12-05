using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Tab.TabFactory
{
    public class TabFactoryWhite : ITabFactory
    {
        ITab ITabFactory.GetTab(object tab, string tabName)
        {
            if(tab is TestStack.White.UIItems.TabItems.TabPage)
            {
                return this.ReturnTabFromTabPageWhite((TestStack.White.UIItems.TabItems.TabPage)tab, tabName);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private ITab ReturnTabFromTabPageWhite(TestStack.White.UIItems.TabItems.TabPage tabPage, string tabName)
        {
            return new TabWhite(tabPage, tabName);
        }
    }
}