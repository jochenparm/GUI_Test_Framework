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
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Factory
{
    internal class GeneralSettingsFactoryWhite : IGeneralSettingsFactory
    {
        private readonly ScreenRepository screenRepository;

        public GeneralSettingsFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        Application.IGeneralApplicationScreen IGeneralSettingsFactory.PopulateGeneralApplicationScreen()
        {
            return this.screenRepository.Get<GeneralApplicationScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        CheckingMail.IGeneralCheckingMailScreen IGeneralSettingsFactory.PopulateGeneralCheckingMailScreen()
        {
            return this.screenRepository.Get<GeneralCheckingMailScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        Notifications.IGeneralNotificationsScreen IGeneralSettingsFactory.PopulateGeneralNotificationsScreen()
        {
            return this.screenRepository.Get<GeneralNotificationsScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        WashingMail.IGeneralWashingMailScreen IGeneralSettingsFactory.PopulateGeneralWashingMailScreen()
        {
            return this.screenRepository.Get<GeneralWashingMailScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        Performance.IGeneralPerformanceScreen IGeneralSettingsFactory.PopulateGeneralPerformanceScreen()
        {
            return this.screenRepository.Get<GeneralPerformanceScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        Updates.IGeneralUpdatesScreen IGeneralSettingsFactory.PopulateGeneralUpdatesScreen()
        {
            return this.screenRepository.Get<GeneralUpdatesScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}