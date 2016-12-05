using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;
using Test.UiMaps.UiMapItems;

namespace Test.TestSuite.UiMapLevel.Strategies.Verification
{
    public abstract class VerificationBase
    {
        private readonly Func<INavigator> _path;
        private readonly Action _precondition;
        private readonly Func<IUiMapItem> _SUT;

        public VerificationBase(Func<INavigator> path, Func<IUiMapItem> SUT)
            : this(path, () => { }, SUT)
        { }

        public VerificationBase(Func<INavigator> path, Action precondition, Func<IUiMapItem> SUT)
        {
            this._SUT = SUT;
            this._path = path;
            this._precondition = precondition;
        }

        [SetUp]
        protected void SetUp()
        {
            MailWasher.Init();
            this._path();
            this._precondition();
        }

        [Test]
        public void Is_OnScreen_On_Start()
        {
            this._SUT().IsOnScreen.ShouldBeTrue();
        }

        [TearDown]
        protected void TearDown()
        {
            MailWasher.DeInit();
        }
    }
}