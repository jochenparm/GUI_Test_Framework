using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Factory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts
{
    public class AccountsSettingsScreenWhite : AppScreen, IAccountsSettingsScreen
    {
        private readonly IAccountsSettingsFactory _accountsSettingsFactory;

        public AccountsSettingsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._accountsSettingsFactory = new AccountsSettingsFactoryWhite(screenRepository);
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.TabItems.TabPage TabItmGeneral; // Tab Item 'General'
        private TestStack.White.UIItems.TabItems.TabPage TabItmMailServer; // Tab Item 'IMAP'
        private TestStack.White.UIItems.TabItems.TabPage TabItmIncoming; // Tab Item 'Incoming'
        private TestStack.White.UIItems.TabItems.TabPage TabItmOutgoing; // Tab Item 'Outgoing'
        private TestStack.White.UIItems.Button BtnAddAccount; //Button 'Add New Account'
        private TestStack.White.UIItems.Button BtnAutoDetect; //Button 'Import Accounts'
        private TestStack.White.UIItems.Button BtnRemoveAccount; //Button 'Remove Account'
        private TestStack.White.UIItems.Button BtnMoveUp; //Button 'Check Order Up'
        private TestStack.White.UIItems.Button BtnMoveDown; //Button 'Check Order Down'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.Button.IButton General_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabItmGeneral);
            }
        }

        UiMapItems.Button.IButton IAccountsSettingsScreen.General_Button
        {
            get
            {
                return this.General_Button;
            }
        }

        private UiMapItems.Button.IButton Incoming_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabItmIncoming);
            }
        }

        UiMapItems.Button.IButton IAccountsSettingsScreen.Incoming_Button
        {
            get
            {
                return this.Incoming_Button;
            }
        }

        private UiMapItems.Button.IButton Outgoing_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabItmOutgoing);
            }
        }

        UiMapItems.Button.IButton IAccountsSettingsScreen.Outgoing_Button
        {
            get
            {
                return this.Outgoing_Button;
            }
        }

        private UiMapItems.Button.IButton IMAP_Button
        {
            get
            {
                return new UiMapItems.Button.TabPageToButtonWhite(this.TabItmMailServer);
            }
        }

        UiMapItems.Button.IButton IAccountsSettingsScreen.IMAP_Button
        {
            get
            {
                return this.IMAP_Button;
            }
        }

        private UiMapItems.Button.IButton Add_Email_Account_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnAddAccount);
            }
        }

        UiMapItems.Button.IButton IAccountsSettingsScreen.Add_Email_Account_Button
        {
            get
            {
                return this.Add_Email_Account_Button;
            }
        }

        private UiMapItems.Button.IButton Remove_Account_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnRemoveAccount);
            }
        }

        UiMapItems.Button.IButton IAccountsSettingsScreen.Remove_Account_Button
        {
            get
            {
                return this.Remove_Account_Button;
            }
        }

        private UiMapItems.Button.IButton Import_Accounts_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnAutoDetect);
            }
        }

        UiMapItems.Button.IButton IAccountsSettingsScreen.Import_Accounts_Button
        {
            get
            {
                return this.Import_Accounts_Button;
            }
        }

        private UiMapItems.Button.IButton Check_Order_Up_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnMoveUp);
            }
        }

        UiMapItems.Button.IButton IAccountsSettingsScreen.Check_Order_Up_Button
        {
            get
            {
                return this.Check_Order_Up_Button;
            }
        }

        private UiMapItems.Button.IButton Check_Order_Down_Button
        {
            get
            {
                return new UiMapItems.Button.ButtonWhite(this.BtnMoveDown);
            }
        }

        UiMapItems.Button.IButton IAccountsSettingsScreen.Check_Order_Down_Button
        {
            get
            {
                return this.Check_Order_Down_Button;
            }
        }

        General.IAccountsGeneralScreen IAccountsSettingsScreen.General
        {
            get
            {
                return this._accountsSettingsFactory.PopulateAccountsGeneralScreen();
            }
        }

        Incoming.IAccountsIncomingScreen IAccountsSettingsScreen.Incoming
        {
            get
            {
                return this._accountsSettingsFactory.PopulateAccountsIncomingScreen();
            }
        }

        Outgoing.IAccountsOutgoingScreen IAccountsSettingsScreen.Outgoing
        {
            get
            {
                return this._accountsSettingsFactory.PopulateAccountsOutgoingScreen();
            }
        }

        IMAP.IAccountsIMAPScreen IAccountsSettingsScreen.IMAP
        {
            get
            {
                return this._accountsSettingsFactory.PopulateAccountsIMAPScreen();
            }
        }
    }
}