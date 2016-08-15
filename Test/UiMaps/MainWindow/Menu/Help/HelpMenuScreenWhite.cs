using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Menu.Help
{
    public class HelpMenuScreenWhite : AppScreen, IHelpMenuScreen
    {
        public HelpMenuScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649 //Field XYZ is never assigned to, and will always have its default value XX

        /// <summary>
        /// "Forums..." TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmForums;

        /// <summary>
        /// "Tell a Friend..." TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmTellAFriend;

        /// <summary>
        /// "Registration..." TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmRegistration;

        /// <summary>
        /// "User Files..." TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmDataFiles;

        /// <summary>
        /// "Common Files..." TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmCommonDataFiles;

        /// <summary>
        /// "Log Protocol" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmLogProtocol;

        /// <summary>
        /// "Send Support Logs" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmSendLogs;

        /// <summary>
        /// "Check for Updates..." TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmCheckForUpdate;

        /// <summary>
        /// "About" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmAbout;

        /// <summary>
        /// "Help Topics..." TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmHelpTopics;

#pragma warning restore 0649

        /// <summary>
        /// "Help Topics..." TestStack White MenuItem
        /// </summary>
        public UiMapItems.Button.IButton Help_Topics_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmHelpTopics);
            }
        }

        /// <summary>
        /// "Forums..." UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Forums_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmForums);
            }
        }

        /// <summary>
        /// "Tell a Friend..." UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Tell_A_Friend_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmTellAFriend);
            }
        }

        /// <summary>
        /// "Registration..." UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Registration_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmRegistration);
            }
        }

        /// <summary>
        /// "User Files..." UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton User_Files_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmDataFiles);
            }
        }

        /// <summary>
        /// "Common Files..." UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Common_Files_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmCommonDataFiles);
            }
        }

        /// <summary>
        /// "Log Protocol" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Log_Protocol_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmLogProtocol);
            }
        }

        /// <summary>
        /// "Send Support Logs" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Send_Support_Logs_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmSendLogs);
            }
        }

        /// <summary>
        /// "Check for Updates..." UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Check_For_Updates_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmCheckForUpdate);
            }
        }

        /// <summary>
        /// "About" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton About_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmAbout);
            }
        }
    }
}