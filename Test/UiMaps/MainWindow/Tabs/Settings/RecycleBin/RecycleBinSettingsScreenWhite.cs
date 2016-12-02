using System.Reflection;
using Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin.Factory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WPFUIItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.RecycleBin
{
    public class RecycleBinSettingsScreenWhite : AppScreen, IRecycleBinSettingsScreen
    {
        private readonly IRecycleBinSettingsFactory _recycleBinSettingsFactory;

        public RecycleBinSettingsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._recycleBinSettingsFactory = new RecycleBinSettingsFactoryWhite(screenRepository);
        }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.ListBoxItems.ListBox LstBxSettings; // ListBox Settings, containing the ListItems for Buttons 'General' and 'Restoring'
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning
        private readonly string GeneralButtonLabelContent = "General";
        private readonly string RestoringButtonLabelContent = "Restoring";

        General.IRecycleBinGeneralScreen IRecycleBinSettingsScreen.General
        {
            get
            {
                return this._recycleBinSettingsFactory.PopulateRecycleBinGeneralScreen();
            }
        }

        Restoring.IRecycleBinRestoringScreen IRecycleBinSettingsScreen.Restoring
        {
            get
            {
                return this._recycleBinSettingsFactory.PopulateRecycleBinRestoringScreen();
            }
        }

        private UiMapItems.Button.IButton General_Button
        {
            get
            {
                return new UiMapItems.Button.ListItemToButtonWhite(this.LstBxSettings.Items.Find(x => (x).Get<Label>(SearchCriteria.ByText(this.GeneralButtonLabelContent)).Visible), MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IRecycleBinSettingsScreen.General_Button
        {
            get
            {
                return this.General_Button;
            }
        }

        private UiMapItems.Button.IButton Restoring_Button
        {
            get
            {
                return new UiMapItems.Button.ListItemToButtonWhite(this.LstBxSettings.Items.Find(x => (x).Get<Label>(SearchCriteria.ByText(this.RestoringButtonLabelContent)).Visible), MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        UiMapItems.Button.IButton IRecycleBinSettingsScreen.Restoring_Button
        {
            get
            {
                return this.Restoring_Button;
            }
        }
    }
}