using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems
{
    public abstract class UiMapItemWhite : IUiMapItem
    {
        private readonly TestStack.White.UIItems.IUIItem _UiItem;

        public UiMapItemWhite(TestStack.White.UIItems.IUIItem UiItem)
        {
            this._UiItem = UiItem;
        }

        public bool IsOnScreen
        {
            get
            {
                return !(this._UiItem.IsOffScreen);
            }
        }

        public void Click()
        {
            this._UiItem.Click();
            Thread.Sleep(350);
        }

        public bool IsActive
        {
            get
            {
                return this._UiItem.Enabled;
            }
        }
    }
}