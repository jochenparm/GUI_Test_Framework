using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Menu.File
{
    public class FileMenuScreenWhite : AppScreen, IFileMenuScreen
    {
        public FileMenuScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

        protected TestStack.White.UIItems.MenuItems.Menu MnuItmCheckMail;       //MnuItmCheckMail = Menu Item "Check Mail"
        protected TestStack.White.UIItems.MenuItems.Menu MnuItmWashMail;        //MnuItmWashMail = Menu Item "Wash Mail"
        protected TestStack.White.UIItems.MenuItems.Menu MnuItmMailProgram;     //MnuItmMailProgram = Menu Item "Mail Program"
        protected TestStack.White.UIItems.MenuItems.Menu MnuItmImport;          //MnuItmImport = Menu Item "Import..."
        protected TestStack.White.UIItems.MenuItems.Menu MnuItmExport;          //MnuItmExport = Menu Item "Export..."
        protected TestStack.White.UIItems.MenuItems.Menu MnuItmExit;            //MnuItmExit = Menu Item "Exit"

        private UiMapItems.Button.IButton CheckMail_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmCheckMail);
            }
        }

        UiMapItems.Button.IButton IFileMenuScreen.CheckMail_Button
        {
            get
            {
                return this.CheckMail_Button;
            }
        }

        private UiMapItems.Button.IButton WashMail_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmWashMail);
            }
        }

        UiMapItems.Button.IButton IFileMenuScreen.WashMail_Button
        {
            get
            {
                return this.WashMail_Button;
            }
        }

        private UiMapItems.Button.IButton MailProgram_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmMailProgram);
            }
        }

        UiMapItems.Button.IButton IFileMenuScreen.MailProgram_Button
        {
            get
            {
                return this.MailProgram_Button;
            }
        }

        private UiMapItems.Button.IButton Import_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmImport);
            }
        }

        UiMapItems.Button.IButton IFileMenuScreen.Import_Button
        {
            get
            {
                return this.Import_Button;
            }
        }

        private UiMapItems.Button.IButton Export_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmExport);
            }
        }

        UiMapItems.Button.IButton IFileMenuScreen.Export_Button
        {
            get
            {
                return this.Export_Button;
            }
        }

        private UiMapItems.Button.IButton Exit_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmExit);
            }
        }

        UiMapItems.Button.IButton IFileMenuScreen.Exit_Button
        {
            get
            {
                return this.Exit_Button;
            }
        }
    }
}