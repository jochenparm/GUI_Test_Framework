using System;
using System.Reflection;
using Test.UiMaps.UiMapItems.Button;
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

        private UiMapItems.Button.IButton CheckMail_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmCheckMail, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton WashMail_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmWashMail, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton MailProgram_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmMailProgram, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Import_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmImport, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Export_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmExport, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Exit_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmExit, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        IButton IFileMenuScreen.CheckMail_Button
        {
            get
            {
                return this.CheckMail_Button;
            }
        }

        IButton IFileMenuScreen.WashMail_Button
        {
            get
            {
                return this.WashMail_Button;
            }
        }

        IButton IFileMenuScreen.MailProgram_Button
        {
            get
            {
                return this.MailProgram_Button;
            }
        }

        IButton IFileMenuScreen.Import_Button
        {
            get
            {
                return this.Import_Button;
            }
        }

        IButton IFileMenuScreen.Export_Button
        {
            get
            {
                return this.Export_Button;
            }
        }

        IButton IFileMenuScreen.Exit_Button
        {
            get
            {
                return this.Exit_Button;
            }
        }
    }
}