using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.MainWindow.Tabs.Settings.General.Application;
using Test.UiMaps.MainWindow.Tabs.Settings.General.CheckingMail;
using Test.UiMaps.MainWindow.Tabs.Settings.General.Notifications;
using Test.UiMaps.MainWindow.Tabs.Settings.General.Performance;
using Test.UiMaps.MainWindow.Tabs.Settings.General.Updates;
using Test.UiMaps.MainWindow.Tabs.Settings.General.WashingMail;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Factory
{
    internal interface IGeneralSettingsFactory
    {
        IGeneralApplicationScreen PopulateGeneralApplicationScreen();

        IGeneralCheckingMailScreen PopulateGeneralCheckingMailScreen();

        IGeneralNotificationsScreen PopulateGeneralNotificationsScreen();

        IGeneralWashingMailScreen PopulateGeneralWashingMailScreen();

        IGeneralPerformanceScreen PopulateGeneralPerformanceScreen();

        IGeneralUpdatesScreen PopulateGeneralUpdatesScreen();
    }
}