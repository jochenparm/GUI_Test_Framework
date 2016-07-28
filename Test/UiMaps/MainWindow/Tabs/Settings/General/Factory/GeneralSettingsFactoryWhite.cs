using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.MainWindow.Tabs.Settings.General.Application;
using Test.UiMaps.MainWindow.Tabs.Settings.General.CheckingMail;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Factory
{
    public class GeneralSettingsFactoryWhite : IGeneralSettingsFactory
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
    }
}