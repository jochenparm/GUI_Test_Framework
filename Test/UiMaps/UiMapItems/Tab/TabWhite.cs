using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.Tab
{
    public class TabWhite : UiMapItemWhite, ITab
    {
        private readonly TestStack.White.UIItems.TabItems.TabPage _tabPage;

        private readonly string _tabName;

        public TabWhite(TestStack.White.UIItems.TabItems.TabPage TabPage, string TabName)
            : base(TabPage, TabName)
        {
            this._tabPage = TabPage;
            this._tabName = TabName;
        }

        private bool IsOpened
        {
            get
            {
                return this._tabPage.IsSelected;
            }
        }

        bool ITab.IsOpened
        {
            get
            {
                return this.IsOpened;
            }
        }

        private void Open()
        {
            if(!IsOpened)
            {
                base.Click();
            }
        }

        void ITab.Open()
        {
            this.Open();
        }
    }
}