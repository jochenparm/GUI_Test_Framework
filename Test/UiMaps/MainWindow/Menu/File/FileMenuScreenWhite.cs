using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Menu.File
{
    public class FileMenuScreenWhite : AppScreen, IFileMenuScreen
    {
        public FileMenuScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649 //Field XYZ is never assigned to, and will always have its default value XX
        private TestStack.White.UIItems.MenuItems.Menu MnuItmCheckMail;       //MnuItmCheckMail = Menu Item "Check Mail"
        private TestStack.White.UIItems.MenuItems.Menu MnuItmWashMail;        //MnuItmWashMail = Menu Item "Wash Mail"
        private TestStack.White.UIItems.MenuItems.Menu MnuItmMailProgram;     //MnuItmMailProgram = Menu Item "Mail Program"
        private TestStack.White.UIItems.MenuItems.Menu MnuItmImport;          //MnuItmImport = Menu Item "Import..."
        private TestStack.White.UIItems.MenuItems.Menu MnuItmExport;          //MnuItmExport = Menu Item "Export..."
        private TestStack.White.UIItems.MenuItems.Menu MnuItmExit;            //MnuItmExit = Menu Item "Exit"
#pragma warning restore 0649

        public UiMapItems.Button.IButton CheckMail_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmCheckMail);
            }
        }

        public UiMapItems.Button.IButton WashMail_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmWashMail);
            }
        }

        public UiMapItems.Button.IButton MailProgram_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmMailProgram);
            }
        }

        public UiMapItems.Button.IButton Import_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmImport);
            }
        }

        public UiMapItems.Button.IButton Export_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmExport);
            }
        }

        public UiMapItems.Button.IButton Exit_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmExit);
            }
        }
    }
}