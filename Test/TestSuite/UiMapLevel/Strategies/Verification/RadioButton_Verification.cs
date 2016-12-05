using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;
using Test.UiMaps.UiMapItems.RadioButton;

namespace Test.TestSuite.UiMapLevel.Strategies.Verification
{
    public abstract class RadioButton_Verification : VerificationBase
    {
        private readonly Func<IRadioButton> _SUT;

        public RadioButton_Verification(Func<INavigator> path, Func<IRadioButton> SUT)
            : this(path, () => { }, SUT)
        { }

        public RadioButton_Verification(Func<INavigator> path, Action precondition, Func<IRadioButton> SUT)
            : base(path, SUT)
        {
            this._SUT = SUT;
        }

        [Test]
        public void Can_Be_Selected()
        {
            this._SUT().Select();
            this._SUT().IsSelected.ShouldBeTrue();
        }
    }
}