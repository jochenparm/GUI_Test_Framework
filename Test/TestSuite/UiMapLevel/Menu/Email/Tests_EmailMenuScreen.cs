using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestSuite.UiMapLevel.Strategies.Verification;

namespace Test.TestSuite.UiMapLevel.Menu.Email
{
    [TestFixture, Property("UiMap_Email_Menu", "Add_Sender_To_Friends_List_Button")]
    public class Tests_EmailMenuScreen_Add_Sender_To_Friends_List_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Add_Sender_To_Friends_List_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Add_Sender_To_Friends_List_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Add_Domain_To_Friends_List_Button")]
    public class Tests_EmailMenuScreen_Add_Domain_To_Friends_List_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Add_Domain_To_Friends_List_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Add_Domain_To_Friends_List_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Remove_Sender_From_Friends_List_Button")]
    public class Tests_EmailMenuScreen_Remove_Sender_From_Friends_List_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Remove_Sender_From_Friends_List_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Remove_Sender_From_Friends_List_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Add_Sender_To_Blacklist_Button")]
    public class Tests_EmailMenuScreen_Add_Sender_To_Blacklist_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Add_Sender_To_Blacklist_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Add_Sender_To_Blacklist_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Add_Domain_To_Blacklist_Button")]
    public class Tests_EmailMenuScreen_Add_Domain_To_Blacklist_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Add_Domain_To_Blacklist_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Add_Domain_To_Blacklist_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Remove_Sender_From_Blacklist_Button")]
    public class Tests_EmailMenuScreen_Remove_Sender_From_Blacklist_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Remove_Sender_From_Blacklist_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Remove_Sender_From_Blacklist_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Mark_As_Spam_Button")]
    public class Tests_EmailMenuScreen_Mark_As_Spam_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Mark_As_Spam_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Mark_As_Spam_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Mark_As_Good_Button")]
    public class Tests_EmailMenuScreen_Mark_As_Good_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Mark_As_Good_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Mark_As_Good_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Mark_For_Delete_Button")]
    public class Tests_EmailMenuScreen_Mark_For_Delete_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Mark_For_Delete_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Mark_For_Delete_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Unmark_Delete_Button")]
    public class Tests_EmailMenuScreen_Unmark_Delete_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Unmark_Delete_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Unmark_Delete_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Mark_All_For_Delete_Button")]
    public class Tests_EmailMenuScreen_Mark_All_For_Delete_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Mark_All_For_Delete_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Mark_All_For_Delete_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Mark_For_Bounce_Button")]
    public class Tests_EmailMenuScreen_Mark_For_Bounce_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Mark_For_Bounce_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Mark_For_Bounce_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Quick_Reply_Button")]
    public class Tests_EmailMenuScreen_Quick_Reply_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Quick_Reply_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Quick_Reply_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Quick_Forward_Button")]
    public class Tests_EmailMenuScreen_Quick_Forward_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Quick_Forward_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Quick_Forward_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Download_Full_Button")]
    public class Tests_EmailMenuScreen_Download_Full_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Download_Full_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Download_Full_Button)
        { }
    }

    [TestFixture, Property("UiMap_Email_Menu", "Clear_Message_List_Button")]
    public class Tests_EmailMenuScreen_Clear_Message_List_Button : Button_Verification
    {
        public Tests_EmailMenuScreen_Clear_Message_List_Button()
            : base(() => MailWasher.Navigator.Menu.Email.Navigate(),
                  () => MailWasher.UiMap.MainWindow.Menu.Email.Clear_Message_List_Button)
        { }
    }
}