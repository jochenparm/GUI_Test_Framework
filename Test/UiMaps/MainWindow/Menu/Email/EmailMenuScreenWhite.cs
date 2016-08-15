using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Menu.Email
{
    internal class EmailMenuScreenWhite : AppScreen, IEmailMenuScreen
    {
        public EmailMenuScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

#pragma warning disable 0649 //Field XYZ is never assigned to, and will always have its default value XX

        /// <summary>
        /// "Add domain to Friends list" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmAddFriendDomain;

        /// <summary>
        /// "Remove sender from Friends list" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmRemoveFriend;

        /// <summary>
        /// "Add sender to Blacklist" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmAddBlack;

        /// <summary>
        /// "Add domain to Blacklist" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmAddBlackDomain;

        /// <summary>
        /// "Remove sender from Blacklist" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmRemoveBlack;

        /// <summary>
        /// "Mark as Spam" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmMarkSpam;

        /// <summary>
        /// "Mark as Good" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmMarkGood;

        /// <summary>
        /// "Mark for Delete" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmMarkDelete;

        /// <summary>
        /// "Unmark Delete" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmUnmarkDelete;

        /// <summary>
        /// "Mark all for delete" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmDeleteAll;

        /// <summary>
        /// "Mark for bounce" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmBounce;

        /// <summary>
        /// "Quick Reply..." TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmQuickReply;

        /// <summary>
        /// "Quick Forward..." TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmQuickForward;

        /// <summary>
        /// "Download Full" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmDownloadFull;

        /// <summary>
        /// "Clear Message List" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmClearGrid;

        /// <summary>
        /// "Add sender to Friends list" TestStack White MenuItem
        /// </summary>
        private TestStack.White.UIItems.MenuItems.Menu MnuItmAddFriend;

#pragma warning restore 0649

        /// <summary>
        /// "Add Sender To Friends List" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Add_Sender_To_Friends_List_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmAddFriend);
            }
        }

        /// <summary>
        /// "Add Domain To Friends List" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Add_Domain_To_Friends_List_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmAddFriendDomain);
            }
        }

        /// <summary>
        /// "Remove Sender From Friends List" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Remove_Sender_From_Friends_List_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmRemoveFriend);
            }
        }

        /// <summary>
        /// "Add Sender To Blacklist" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Add_Sender_To_Blacklist_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmAddBlack);
            }
        }

        /// <summary>
        /// "Add Domain To Blacklist" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Add_Domain_To_Blacklist_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmAddBlackDomain);
            }
        }

        /// <summary>
        /// "Remove Sender From Blacklist" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Remove_Sender_From_Blacklist_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmRemoveBlack);
            }
        }

        /// <summary>
        /// "Mark As Spam" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Mark_As_Spam_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmMarkSpam);
            }
        }

        /// <summary>
        /// "Mark As Good" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Mark_As_Good_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmMarkGood);
            }
        }

        /// <summary>
        /// "Mark For Delete" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Mark_For_Delete_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmMarkDelete);
            }
        }

        /// <summary>
        /// "Unmark Delete" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Unmark_Delete_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmUnmarkDelete);
            }
        }

        /// <summary>
        /// "Mark All For Delete" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Mark_All_For_Delete_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmDeleteAll);
            }
        }

        /// <summary>
        /// "Mark For Bounce" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Mark_For_Bounce_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmBounce);
            }
        }

        /// <summary>
        /// "Quick Reply..." UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Quick_Reply_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmQuickReply);
            }
        }

        /// <summary>
        /// "Quick Forward..." UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Quick_Forward_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmQuickForward);
            }
        }

        /// <summary>
        /// "Download Full" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Download_Full_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmDownloadFull);
            }
        }

        /// <summary>
        /// "Clear Message List" UiMapItems Button
        /// </summary>
        public UiMapItems.Button.IButton Clear_Message_List_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmClearGrid);
            }
        }
    }
}