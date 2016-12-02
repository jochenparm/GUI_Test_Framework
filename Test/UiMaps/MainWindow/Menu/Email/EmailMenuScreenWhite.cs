using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Test.UiMaps.UiMapItems.Button;
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

        private UiMapItems.Button.IButton Add_Sender_To_Friends_List_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmAddFriend, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Add_Domain_To_Friends_List_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmAddFriendDomain, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Remove_Sender_From_Friends_List_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmRemoveFriend, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Add_Sender_To_Blacklist_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmAddBlack, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Add_Domain_To_Blacklist_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmAddBlackDomain, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Remove_Sender_From_Blacklist_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmRemoveBlack, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Mark_As_Spam_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmMarkSpam, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Mark_As_Good_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmMarkGood, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Mark_For_Delete_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmMarkDelete, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Unmark_Delete_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmUnmarkDelete, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Mark_All_For_Delete_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmDeleteAll, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Mark_For_Bounce_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmBounce, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Quick_Reply_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmQuickReply, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Quick_Forward_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmQuickForward, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Download_Full_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmDownloadFull, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        private UiMapItems.Button.IButton Clear_Message_List_Button
        {
            get
            {
                return new UiMapItems.Button.MenuItemToButtonWhite(this.MnuItmClearGrid, MethodBase.GetCurrentMethod().Name.Replace("get_", ""));
            }
        }

        /// <summary>
        /// "Add Sender To Friends List" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Add_Sender_To_Friends_List_Button
        {
            get
            {
                return this.Add_Sender_To_Friends_List_Button;
            }
        }

        /// <summary>
        /// "Add Domain To Friends List" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Add_Domain_To_Friends_List_Button
        {
            get
            {
                return this.Add_Domain_To_Friends_List_Button;
            }
        }

        /// <summary>
        /// "Remove Sender From Friends List" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Remove_Sender_From_Friends_List_Button
        {
            get
            {
                return this.Remove_Sender_From_Friends_List_Button;
            }
        }

        /// <summary>
        /// "Add Sender To Blacklist" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Add_Sender_To_Blacklist_Button
        {
            get
            {
                return this.Add_Sender_To_Blacklist_Button;
            }
        }

        /// <summary>
        /// "Add Domain To Blacklist" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Add_Domain_To_Blacklist_Button
        {
            get
            {
                return this.Add_Domain_To_Blacklist_Button;
            }
        }

        /// <summary>
        /// "Remove Sender From Blacklist" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Remove_Sender_From_Blacklist_Button
        {
            get
            {
                return this.Remove_Sender_From_Blacklist_Button;
            }
        }

        /// <summary>
        /// "Mark As Spam" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Mark_As_Spam_Button
        {
            get
            {
                return this.Mark_As_Spam_Button;
            }
        }

        /// <summary>
        /// "Mark As Good" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Mark_As_Good_Button
        {
            get
            {
                return this.Mark_As_Good_Button;
            }
        }

        /// <summary>
        /// "Mark For Delete" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Mark_For_Delete_Button
        {
            get
            {
                return this.Mark_For_Delete_Button;
            }
        }

        /// <summary>
        /// "Unmark Delete" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Unmark_Delete_Button
        {
            get
            {
                return this.Unmark_Delete_Button;
            }
        }

        /// <summary>
        /// "Mark All For Delete" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Mark_All_For_Delete_Button
        {
            get
            {
                return this.Mark_All_For_Delete_Button;
            }
        }

        /// <summary>
        /// "Mark For Bounce" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Mark_For_Bounce_Button
        {
            get
            {
                return this.Mark_For_Bounce_Button;
            }
        }

        /// <summary>
        /// "Quick Reply..." UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Quick_Reply_Button
        {
            get
            {
                return this.Quick_Reply_Button;
            }
        }

        /// <summary>
        /// "Quick Forward..." UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Quick_Forward_Button
        {
            get
            {
                return this.Quick_Forward_Button;
            }
        }

        /// <summary>
        /// "Download Full" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Download_Full_Button
        {
            get
            {
                return this.Download_Full_Button;
            }
        }

        /// <summary>
        /// "Clear Message List" UiMapItems Button
        /// </summary>
        IButton IEmailMenuScreen.Clear_Message_List_Button
        {
            get
            {
                return this.Clear_Message_List_Button;
            }
        }
    }
}