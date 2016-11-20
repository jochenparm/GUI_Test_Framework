using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FunctionalLibrary.Navigator.Menu.Email
{
    public class Email : NavigatorBase, IEmail
    {
        public Email()
        {
            MailWasher.UiMap.MainWindow.Menu.Email_Button.Click();
        }
    }
}