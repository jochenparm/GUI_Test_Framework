using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TestSuite.FunctionalLevel.Tabs.Inbox
{
    [TestFixture, Property("Functional", "InboxTab")]
    public class Functional_Tests_InboxTab
    {
        [SetUp]
        public void SetUp()
        {
            MailWasher.Init();
        }

        [Test]
        public void Inbox_Check_All_Email()
        {
            MailWasher.Main.Tabs.Inbox.Check_All_Email();
            MailWasher.Main.Tabs.Inbox.Wait_For_Is_Checking_Email(5).ShouldBeTrue();
        }

        [Test]
        public void Inbox_Stop_Checking_Email()
        {
            MailWasher.Main.Tabs.Inbox.Check_All_Email();
            MailWasher.Main.Tabs.Inbox.Wait_For_Is_Checking_Email(5).ShouldBeTrue();
            MailWasher.Main.Tabs.Inbox.Stop_Checking_Email();
            MailWasher.Main.Tabs.Inbox.Wait_For_Isnt_Checking_Email(5).ShouldBeTrue();
        }

        [TearDown]
        public void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}