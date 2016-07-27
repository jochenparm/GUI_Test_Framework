using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.IMAP
{
    public class AccountsIMAPScreenWhite : AppScreen, IAccountsIMAPScreen
    {
        public AccountsIMAPScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.Button BtnRefresh; //Button 'Refresh'
        private TestStack.White.UIItems.Button BtnSave; //Button 'Save'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.Button.IButton Refresh_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnRefresh);
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
                return new UiMapItems.Button.ButtonWhite(this.BtnSave);
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