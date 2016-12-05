using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.Button;
using Test.UiMaps.UiMapItems.Button.ButtonFactory;
using Test.UiMaps.UiMapItems.CheckBox;
using Test.UiMaps.UiMapItems.UiMapItemsFactory;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Menu.View
{
    public class ViewMenuScreenWhite : AppScreen, IViewMenuScreen
    {
        private readonly IUiMapItemsFactory _uiMapItemsFactory;

        public ViewMenuScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        {
            this._uiMapItemsFactory = new UiMapItemsFactoryWhite();
        }

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

        private UiMapItems.CheckBox.ICheckBox Preview_Pane_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.MnuItmPreviewPane, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.CheckBox.ICheckBox Preview_Pane_Graphic_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.MnuItmPreviewSplash, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.CheckBox.ICheckBox Side_Bar_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.MnuItmSideBar, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.CheckBox.ICheckBox Always_Show_Event_Log_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.MnuItmEventLog, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Tutorial_Video_Button
        {
            get
            {
                return this._uiMapItemsFactory.GetButton(this.MnuItmVideo, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.CheckBox.ICheckBox Show_Hidden_Emails_CheckBox
        {
            get
            {
                return this._uiMapItemsFactory.GetCheckBox(this.MnuItmShowHiddenEmails, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        /// <summary>
        /// "Preview Pane" UiMapItem CheckBox
        /// </summary>
        ICheckBox IViewMenuScreen.Preview_Pane_CheckBox
        {
            get
            {
                return this.Preview_Pane_CheckBox;
            }
        }

        /// <summary>
        /// "Preview Pane Graphic" UiMapItem CheckBox
        /// </summary>
        ICheckBox IViewMenuScreen.Preview_Pane_Graphic_CheckBox
        {
            get
            {
                return this.Preview_Pane_Graphic_CheckBox;
            }
        }

        /// <summary>
        /// "Side Bar" UiMapItem CheckBox
        /// </summary>
        ICheckBox IViewMenuScreen.Side_Bar_CheckBox
        {
            get
            {
                return this.Side_Bar_CheckBox;
            }
        }

        /// <summary>
        /// "Always Show Event Log" UiMapItem CheckBox
        /// </summary>
        ICheckBox IViewMenuScreen.Always_Show_Event_Log_CheckBox
        {
            get
            {
                return this.Always_Show_Event_Log_CheckBox;
            }
        }

        /// <summary>
        /// "Tutorial Video" UiMapItem Button
        /// </summary>
        IButton IViewMenuScreen.Tutorial_Video_Button
        {
            get
            {
                return this.Tutorial_Video_Button;
            }
        }

        /// <summary>
        /// "Show hidden emails" UiMapItem CheckBox
        /// </summary>
        ICheckBox IViewMenuScreen.Show_Hidden_Emails_CheckBox
        {
            get
            {
                return this.Show_Hidden_Emails_CheckBox;
            }
        }
    }
}