using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.Sync
{
    public class SyncSettingsScreenWhite : AppScreen, ISyncSettingsScreen
    {
        public SyncSettingsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.ListBoxItems.ListItem LstBxItmMobile;
        private TestStack.White.UIItems.ListBoxItems.ListItem LstBxItmAccount;
#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.Button.IButton Account_Button
        {
            get
            {
                return new UiMapItems.Button.ListItemToButtonWhite(this.LstBxItmAccount);
            }
        }

        UiMapItems.Button.IButton ISyncSettingsScreen.Account_Button
        {
            get
            {
                return this.Account_Button;
            }
        }

        private UiMapItems.Button.IButton Mobile_Button
        {
            get
            {
                return new UiMapItems.Button.ListItemToButtonWhite(this.LstBxItmMobile);
            }
        }

        UiMapItems.Button.IButton ISyncSettingsScreen.Mobile_Button
        {
            get
            {
                return this.Mobile_Button;
            }
        }
    }
}