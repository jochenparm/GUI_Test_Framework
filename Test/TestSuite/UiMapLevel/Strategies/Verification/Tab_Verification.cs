using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;
using Test.UiMaps.UiMapItems.Tab;

namespace Test.TestSuite.UiMapLevel.Strategies.Verification
{
    public abstract class Tab_Verification : VerificationBase
    {
        private readonly Func<ITab> _SUT;

        public Tab_Verification(Func<INavigator> path, Func<ITab> SUT)
            : this(path, () => { }, SUT)
        { }

        public Tab_Verification(Func<INavigator> path, Action precondition, Func<ITab> SUT)
            : base(path, SUT)
        {
            this._SUT = SUT;
        }

        [Test]
        public void Can_Be_Opened()
        {
            this._SUT().Open();
            this._SUT().IsOpened.ShouldBeTrue();
        }
    }
}