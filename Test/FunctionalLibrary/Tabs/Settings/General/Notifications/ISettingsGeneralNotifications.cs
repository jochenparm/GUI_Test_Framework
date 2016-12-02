using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Tabs.Settings.General.Notifications
{
    public interface ISettingsGeneralNotifications
    {
        ISettingsGeneralNotifications Display_Balloon_Notifications_When_New_Mail_Arrives(bool enable);

        ISettingsGeneralNotifications Set_Display_Duration(int seconds);

        ISettingsGeneralNotifications Play_Sound_When_New_Mail_Arrives(bool enable);

        ISettingsGeneralNotifications Dont_Notify_Me_When_Mail_Is_Spam(bool enable);

        ISettingsGeneralNotifications Play_Sound_When_Error_Occurs(bool enable);

        ISettingsGeneralNotifications Save();
    }
}