using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.General;
using Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.Restoring;
using TestStack.White.Factory;
using TestStack.White.ScreenObjects;

namespace Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.Factory
{
    internal class RecycleBinSettingsFactoryWhite : IRecycleBinSettingsFactory
    {
        private readonly ScreenRepository screenRepository;

        public RecycleBinSettingsFactoryWhite(ScreenRepository screenRepository)
        {
            this.screenRepository = screenRepository;
        }

        General.IRecycleBinGeneralScreen IRecycleBinSettingsFactory.PopulateRecycleBinGeneralScreen()
        {
            return this.screenRepository.Get<RecycleBinGeneralScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }

        Restoring.IRecycleBinRestoringScreen IRecycleBinSettingsFactory.PopulateRecycleBinRestoringScreen()
        {
            return this.screenRepository.Get<RecycleBinRestoringScreenWhite>(x => x.StartsWith(Constants.applicationName), InitializeOption.NoCache);
        }
    }
}