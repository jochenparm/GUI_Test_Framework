using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.General;
using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.IMAP;
using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Incoming;
using Test.UiMaps.MainWindow.Tabs.Settings.Accounts.Outgoing;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts
{
    public interface IAccountsSettingsScreen
    {
        UiMapItems.Button.IButton General_Button { get; }
        IAccountsGeneralScreen General { get; }
        UiMapItems.Button.IButton Incoming_Button { get; }
        IAccountsIncomingScreen Incoming { get; }
        UiMapItems.Button.IButton Outgoing_Button { get; }
        IAccountsOutgoingScreen Outgoing { get; }
        UiMapItems.Button.IButton IMAP_Button { get; }
        IAccountsIMAPScreen IMAP { get; }
        UiMapItems.Button.IButton Add_Email_Account_Button { get; }
        UiMapItems.Button.IButton Remove_Account_Button { get; }
        UiMapItems.Button.IButton Import_Accounts_Button { get; }
        UiMapItems.Button.IButton Check_Order_Up_Button { get; }
        UiMapItems.Button.IButton Check_Order_Down_Button { get; }
    }
}