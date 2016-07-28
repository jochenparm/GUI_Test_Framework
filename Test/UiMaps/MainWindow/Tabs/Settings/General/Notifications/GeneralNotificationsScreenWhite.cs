using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.General.Notifications
{
    public class GeneralNotificationsScreenWhite : AppScreen, IGeneralNotificationsScreen
    {
        public GeneralNotificationsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649 //Suppresses the 'is never assigned to, and will always have its default value null' warning
        private TestStack.White.UIItems.CheckBox ChkBxNewMailPopup; // CheckBox 'Display balloon notification when new mail arrives'
        private TestStack.White.UIItems.CheckBox ChkBxNewMailSound; // CheckBox 'Play sound when new mail arrives'
        private TestStack.White.UIItems.CheckBox ChkBxNotSpam; // CheckBox 'Don't notify me if mail is spam'
        private TestStack.White.UIItems.CheckBox ChkBxErrorSound; // CheckBox 'Play sound when error occurs'

#pragma warning restore 0649 //Restores the 'is never assigned to, and will always have its default value null' warning

        private UiMapItems.CheckBox.ICheckBox Display_Balloon_Notification_When_New_Mail_Arrives_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxNewMailPopup);
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralNotificationsScreen.Display_Balloon_Notification_When_New_Mail_Arrives_CheckBox
        {
            get
            {
                return this.Display_Balloon_Notification_When_New_Mail_Arrives_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Play_Sound_When_New_Mail_Arrives_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxNewMailSound);
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralNotificationsScreen.Play_Sound_When_New_Mail_Arrives_CheckBox
        {
            get
            {
                return this.Play_Sound_When_New_Mail_Arrives_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Dont_Notify_Me_When_Mail_Is_Spam_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxNotSpam);
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralNotificationsScreen.Dont_Notify_Me_When_Mail_Is_Spam_CheckBox
        {
            get
            {
                return this.Dont_Notify_Me_When_Mail_Is_Spam_CheckBox;
            }
        }

        private UiMapItems.CheckBox.ICheckBox Play_Sound_When_Error_Occurs_CheckBox
        {
            get
            {
                return new UiMapItems.CheckBox.CheckBoxWhite(this.ChkBxErrorSound);
            }
        }

        UiMapItems.CheckBox.ICheckBox IGeneralNotificationsScreen.Play_Sound_When_Error_Occurs_CheckBox
        {
            get
            {
                return this.Play_Sound_When_Error_Occurs_CheckBox;
            }
        }

        UiMapItems.Button.IButton IGeneralNotificationsScreen.Save_Button
        {
            get { throw new NotImplementedException(); }
        }

        UiMapItems.Button.IButton IGeneralNotificationsScreen.Display_Duration_Reset_Button
        {
            get { throw new NotImplementedException(); }
        }

        UiMapItems.Slider.ISlider IGeneralNotificationsScreen.Display_Duration_Slider
        {
            get { throw new NotImplementedException(); }
        }

        UiMapItems.TextBox.ITextBox IGeneralNotificationsScreen.New_Mail_Sound_Path_TextBox
        {
            get { throw new NotImplementedException(); }
        }
    }
}