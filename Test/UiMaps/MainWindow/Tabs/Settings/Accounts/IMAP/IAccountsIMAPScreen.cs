using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Accounts.IMAP
{
    public interface IAccountsIMAPScreen
    {
        UiMapItems.Button.IButton Refresh_Button { get; }
        UiMapItems.Button.IButton Save_Button { get; }
    }
}