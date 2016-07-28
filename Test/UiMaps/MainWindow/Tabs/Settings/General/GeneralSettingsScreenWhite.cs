using Test.UiMaps.MainWindow.Tabs.Settings.General.Factory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General
{
    public class GeneralSettingsScreenWhite : AppScreen, IGeneralSettingsScreen
    {
        private readonly IGeneralSettingsFactory _generalSettingsFactory;

        public GeneralSettingsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._generalSettingsFactory = new GeneralSettingsFactoryWhite(screenRepository);
        }

        Application.IGeneralApplicationScreen IGeneralSettingsScreen.Application
        {
            get
            {
                return this._generalSettingsFactory.PopulateGeneralApplicationScreen();
            }
        }

        CheckingMail.IGeneralCheckingMailScreen IGeneralSettingsScreen.Checking_Mail
        {
            get
            {
                return this._generalSettingsFactory.PopulateGeneralCheckingMailScreen();
            }
        }
    }
}