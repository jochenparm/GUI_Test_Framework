using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems
{
    public abstract class UiMapItemWhite : IUiMapItem
    {
        private readonly TestStack.White.UIItems.IUIItem _uiItem;

        private readonly string _uitemName;

        public UiMapItemWhite(TestStack.White.UIItems.IUIItem UiItem, string UiItemName)
        {
            this._uiItem = UiItem;
            this._uitemName = UiItemName;
        }

        protected bool IsOnScreen
        {
            get
            {
                return !(this._uiItem.IsOffScreen);
            }
        }

        bool IUiMapItem.IsOnScreen
        {
            get
            {
                try
                {
                    bool returnValue = this.IsOnScreen;
                    Log.Debug("Returned {PropertyName:l} property of {UiItemName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._uitemName);
                    return returnValue;
                }
                catch(Exception)
                {
                    Log.Fatal("Failed to return {PropertyName:l} property of {UiItemName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._uitemName);
                    throw;
                }
            }
        }

        protected void Click()
        {
            this._uiItem.Click();
            Thread.Sleep(350);
        }

        void IUiMapItem.Click()
        {
            try
            {
                this.Click();
                Log.Debug("Invoked {MethodName:l} method of {UiItemName:l}", MethodBase.GetCurrentMethod().Name, this._uitemName);
            }
            catch(Exception)
            {
                Log.Fatal("Failed to invoke {MethodName:l} method of {UiItemName:l}", MethodBase.GetCurrentMethod().Name, this._uitemName);
                throw;
            }
        }

        protected bool IsActive
        {
            get
            {
                return this._uiItem.Enabled;
            }
        }

        bool IUiMapItem.IsActive
        {
            get
            {
                try
                {
                    bool returnValue = this.IsActive;
                    Log.Debug("Returned {PropertyName:l} property of {UiItemName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._uitemName);
                    return returnValue;
                }
                catch(Exception)
                {
                    Log.Fatal("Failed to return {PropertyName:l} property of {UiItemName:l}", MethodBase.GetCurrentMethod().Name.Replace("get_", ""), this._uitemName);
                    throw;
                }
            }
        }
    }
}