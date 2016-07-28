using Test.UiMaps.MainWindow.Tabs.Settings.General.Application;
using Test.UiMaps.MainWindow.Tabs.Settings.General.CheckingMail;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General
{
    public interface IGeneralSettingsScreen
    {
        IGeneralApplicationScreen Application { get; }
        IGeneralCheckingMailScreen Checking_Mail { get; }
    }
}