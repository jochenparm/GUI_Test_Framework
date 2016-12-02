using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.Button;
using Test.UiMaps.UiMapItems.CheckBox;
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

        private UiMapItems.Button.IButton Help_Topics_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmHelpTopics, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Forums_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmForums, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Tell_A_Friend_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmTellAFriend, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Registration_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmRegistration, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton User_Files_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmDataFiles, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Common_Files_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmCommonDataFiles, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.CheckBox.ICheckBox Log_Protocol_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.MenuItemToCheckBoxWhite(this.MnuItmLogProtocol, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Send_Support_Logs_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmSendLogs, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Check_For_Updates_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmCheckForUpdate, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton About_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmAbout, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        /// <summary>
        /// "Help Topics..." TestStack White MenuItem
        /// </summary>
        IButton IHelpMenuScreen.Help_Topics_Button
        {
            get
            {
                return this.Help_Topics_Button;
            }
        }

        /// <summary>
        /// "Forums..." UiMapItems Button
        /// </summary>
        IButton IHelpMenuScreen.Forums_Button
        {
            get
            {
                return this.Forums_Button;
            }
        }

        /// <summary>
        /// "Tell a Friend..." UiMapItems Button
        /// </summary>
        IButton IHelpMenuScreen.Tell_A_Friend_Button
        {
            get
            {
                return this.Tell_A_Friend_Button;
            }
        }

        /// <summary>
        /// "Registration..." UiMapItems Button
        /// </summary>
        IButton IHelpMenuScreen.Registration_Button
        {
            get
            {
                return this.Registration_Button;
            }
        }

        /// <summary>
        /// "User Files..." UiMapItems Button
        /// </summary>
        IButton IHelpMenuScreen.User_Files_Button
        {
            get
            {
                return this.User_Files_Button;
            }
        }

        /// <summary>
        /// "Common Files..." UiMapItems Button
        /// </summary>
        IButton IHelpMenuScreen.Common_Files_Button
        {
            get
            {
                return this.Common_Files_Button;
            }
        }

        /// <summary>
        /// "Log Protocol" UiMapItems CheckBox
        /// </summary>
        ICheckBox IHelpMenuScreen.Log_Protocol_CheckBox
        {
            get
            {
                return this.Log_Protocol_CheckBox;
            }
        }

        /// <summary>
        /// "Send Support Logs" UiMapItems Button
        /// </summary>
        IButton IHelpMenuScreen.Send_Support_Logs_Button
        {
            get
            {
                return this.Send_Support_Logs_Button;
            }
        }

        /// <summary>
        /// "Check for Updates..." UiMapItems Button
        /// </summary>
        IButton IHelpMenuScreen.Check_For_Updates_Button
        {
            get
            {
                return this.Check_For_Updates_Button;
            }
        }

        /// <summary>
        /// "About" UiMapItems Button
        /// </summary>
        IButton IHelpMenuScreen.About_Button
        {
            get
            {
                return this.About_Button;
            }
        }
    }
}