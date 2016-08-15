using Test.UiMaps.MainWindow.Tabs.Settings.General.Application;
using Test.UiMaps.MainWindow.Tabs.Settings.General.CheckingMail;
using Test.UiMaps.MainWindow.Tabs.Settings.General.Notifications;
using Test.UiMaps.MainWindow.Tabs.Settings.General.Performance;
using Test.UiMaps.MainWindow.Tabs.Settings.General.Updates;
using Test.UiMaps.MainWindow.Tabs.Settings.General.WashingMail;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General
{
    public interface IGeneralSettingsScreen
    {
        UiMapItems.Button.IButton Application_Button { get; }
        UiMapItems.Button.IButton Checking_Mail_Button { get; }
        UiMapItems.Button.IButton Notifications_Button { get; }
        UiMapItems.Button.IButton Washing_Mail_Button { get; }
        UiMapItems.Button.IButton Performance_Button { get; }
        UiMapItems.Button.IButton Updates_Button { get; }

        IGeneralApplicationScreen Application { get; }
        IGeneralCheckingMailScreen Checking_Mail { get; }

        IGeneralNotificationsScreen Notifications { get; }

        IGeneralWashingMailScreen Washing_Mail { get; }

        IGeneralPerformanceScreen Performance { get; }
        IGeneralUpdatesScreen Updates { get; }
    }
}