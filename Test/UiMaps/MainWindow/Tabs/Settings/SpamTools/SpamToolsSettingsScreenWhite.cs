using System;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.BlackList;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.Filters;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.FirstAlert;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.FriendsList;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.LearningSettings;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.OriginOfSpam;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.ProfanityList;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.SpamRatings;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.SpamReporting;
using TestStack.White.ScreenObjects;
using TestStack.White.UIItems.WindowItems;

namespace Test.UiMaps.MainWindow.Tabs.Settings.SpamTools
{
    public class SpamToolsSettingsScreenWhite : AppScreen, ISpamToolsSettingsScreen
    {
        public SpamToolsSettingsScreenWhite(Window window, ScreenRepository screenRepository)
            : base(window, screenRepository)
        { }

        ISpamToolsBlackListScreen ISpamToolsSettingsScreen.Black_List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ISpamToolsFiltersScreen ISpamToolsSettingsScreen.Filters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ISpamToolsFirstAlertScreen ISpamToolsSettingsScreen.First_Alert
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ISpamToolsFriendsListScreen ISpamToolsSettingsScreen.Friends_List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ISpamToolsLearningSettingsScreen ISpamToolsSettingsScreen.Learning_Settings
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ISpamToolsOriginOfSpamScreen ISpamToolsSettingsScreen.Origin_Of_Spam
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ISpamToolsProfanityListScreen ISpamToolsSettingsScreen.Profanity_List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ISpamToolsSpamRatingsScreen ISpamToolsSettingsScreen.Spam_Ratings
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ISpamToolsSpamReportingScreen ISpamToolsSettingsScreen.Spam_Reporting
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}