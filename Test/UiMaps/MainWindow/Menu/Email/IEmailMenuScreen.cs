using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.MainWindow.Menu.Email
{
    public interface IEmailMenuScreen
    {
        UiMapItems.Button.IButton Add_Sender_To_Friends_List_Button { get; }
        UiMapItems.Button.IButton Add_Domain_To_Friends_List_Button { get; }
        UiMapItems.Button.IButton Remove_Sender_From_Friends_List_Button { get; }
        UiMapItems.Button.IButton Add_Sender_To_Blacklist_Button { get; }
        UiMapItems.Button.IButton Add_Domain_To_Blacklist_Button { get; }
        UiMapItems.Button.IButton Remove_Sender_From_Blacklist_Button { get; }
        UiMapItems.Button.IButton Mark_As_Spam_Button { get; }
        UiMapItems.Button.IButton Mark_As_Good_Button { get; }
        UiMapItems.Button.IButton Mark_For_Delete_Button { get; }
        UiMapItems.Button.IButton Unmark_Delete_Button { get; }
        UiMapItems.Button.IButton Mark_All_For_Delete_Button { get; }
        UiMapItems.Button.IButton Mark_For_Bounce_Button { get; }
        UiMapItems.Button.IButton Quick_Reply_Button { get; }
        UiMapItems.Button.IButton Quick_Forward_Button { get; }
        UiMapItems.Button.IButton Download_Full_Button { get; }
        UiMapItems.Button.IButton Clear_Message_List_Button { get; }
    }
}