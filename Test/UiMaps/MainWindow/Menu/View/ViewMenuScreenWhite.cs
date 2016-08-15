using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Menu.View
{
    public class ViewMenuScreenWhite : AppScreen, IViewMenuScreen
    {
        public ViewMenuScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649 //Field XYZ is never assigned to, and will always have its default value XX

        /// <summary>
        /// "Preview Pane Graphic" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmPreviewSplash;

        /// <summary>
        /// "Side Bar" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmSideBar;

        /// <summary>
        /// "Always Show Event Log" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmEventLog;

        /// <summary>
        /// "Tutorial Video" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmVideo;

        /// <summary>
        /// "Show hidden emails" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmShowHiddenEmails;

        /// <summary>
        /// "Preview Pane" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmPreviewPane;

#pragma warning restore 0649

        /// <summary>
        /// "Preview Pane" UiMapItem Button
        /// </summary>
        public UiMapItems.Button.IButton Preview_Pane_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmPreviewPane);
            }
        }

        /// <summary>
        /// "Preview Pane Graphic" UiMapItem Button
        /// </summary>
        public UiMapItems.Button.IButton Preview_Pane_Graphic_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmPreviewSplash);
            }
        }

        /// <summary>
        /// "Side Bar" UiMapItem Button
        /// </summary>
        public UiMapItems.Button.IButton Side_Bar_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmSideBar);
            }
        }

        /// <summary>
        /// "Always Show Event Log" UiMapItem Button
        /// </summary>
        public UiMapItems.Button.IButton Always_Show_Event_Log_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmEventLog);
            }
        }

        /// <summary>
        /// "Tutorial Video" UiMapItem Button
        /// </summary>
        public UiMapItems.Button.IButton Tutorial_Video_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmVideo);
            }
        }

        /// <summary>
        /// "Show hidden emails" UiMapItem Button
        /// </summary>
        public UiMapItems.Button.IButton Show_Hidden_Emails_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmShowHiddenEmails);
            }
        }
    }
}