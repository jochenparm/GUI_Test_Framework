using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.IMAP
{
    public class AccountsIMAPScreenWhite : AppScreen, IAccountsIMAPScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public AccountsIMAPScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.Button BtnRefresh; //Button 'Refresh'
        private TestStack.White.UIItems.Button BtnSave; //Button 'Save'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.Button.IButton Refresh_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnRefresh, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IAccountsIMAPScreen.Refresh_Button
        {
            get
            {
                return this.Refresh_Button;
            }
        }

        private UiMapItems.Button.IButton Save_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.BtnSave, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IAccountsIMAPScreen.Save_Button
        {
            get
            {
                return this.Save_Button;
            }
        }
    }
}