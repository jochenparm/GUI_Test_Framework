using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;
using Test.UiMaps.UiMapItems.CheckBox;

namespace Test.TestSuite.UiMapLevel.Strategies.Verification
{
    public abstract class CheckBox_Verification : VerificationBase
    {
        private readonly Func<ICheckBox> _SUT;

        public CheckBox_Verification(Func<INavigator> path, Func<ICheckBox> SUT)
            : this(path, () => { }, SUT)
        { }

        public CheckBox_Verification(Func<INavigator> path, Action precondition, Func<ICheckBox> SUT)
            : base(path, SUT)
        {
            this._SUT = SUT;
        }

        [Test]
        public void IsEnabled_Property_Is_Accessible()
        {
            this._SUT().IsEnabled.ShouldNotBeNull();
        }

        [Test]
        public void Can_Be_Disabled()
        {
            this._SUT().Disable();
            this._SUT().IsEnabled.ShouldBeFalse();
        }

        [Test]
        public void Can_Be_Enabled()
        {
            this._SUT().Enable();
            this._SUT().IsEnabled.ShouldBeTrue();
        }
    }
}