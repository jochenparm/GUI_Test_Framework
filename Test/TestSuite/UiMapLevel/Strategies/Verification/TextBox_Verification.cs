﻿using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.FunctionalLibrary.Navigator;
using Test.UiMaps.UiMapItems.TextBox;

namespace Test.TestSuite.UiMapLevel.Strategies.Verification
{
    public abstract class TextBox_Verification : VerificationBase
    {
        private readonly Func<ITextBox> _SUT;
        private readonly string testdata = "thisshouldberandomized";

        public TextBox_Verification(Func<INavigator> path, Func<ITextBox> SUT)
            : this(path, () => { }, SUT)
        { }

        public TextBox_Verification(Func<INavigator> path, Action precondition, Func<ITextBox> SUT)
            : base(path, SUT)
        {
            this._SUT = SUT;
        }

        [Test]
        public void Can_Be_Edited()
        {
            this._SUT().Content = testdata;
            this._SUT().Content.ShouldBe(testdata);
        }
    }
}