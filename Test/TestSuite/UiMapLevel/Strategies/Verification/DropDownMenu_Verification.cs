using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;
using Test.UiMaps.UiMapItems.DropDownMenu;

namespace Test.TestSuite.UiMapLevel.Strategies.Verification
{
    public abstract class DropDownMenu_Verification : VerificationBase
    {
        private readonly Func<IDropDownMenu> _SUT;

        public DropDownMenu_Verification(Func<INavigator> path, Func<IDropDownMenu> SUT)
            : this(path, () => { }, SUT)
        { }

        public DropDownMenu_Verification(Func<INavigator> path, Action precondition, Func<IDropDownMenu> SUT)
            : base(path, SUT)
        {
            this._SUT = SUT;
        }

        [Test]
        public void Property_CurrentSelection_Is_Accessible()
        {
            this._SUT().CurrentSelection.ShouldNotBeNull();
        }
    }
}