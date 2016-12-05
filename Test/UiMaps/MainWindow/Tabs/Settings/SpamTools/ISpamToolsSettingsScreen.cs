using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.BlackList;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.Filters;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.FirstAlert;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.FriendsList;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.LearningSettings;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.OriginOfSpam;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.ProfanityList;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.SpamRatings;
using Test.UiMaps.MainWindow.Tabs.Settings.SpamTools.SpamReporting;

namespace Test.UiMaps.MainWindow.Tabs.Settings.SpamTools
{
    public interface ISpamToolsSettingsScreen
    {
        ISpamToolsBlackListScreen Black_List { get; }
        ISpamToolsFiltersScreen Filters { get; }
        ISpamToolsFirstAlertScreen First_Alert { get; }
        ISpamToolsFriendsListScreen Friends_List { get; }
        ISpamToolsLearningSettingsScreen Learning_Settings { get; }
        ISpamToolsOriginOfSpamScreen Origin_Of_Spam { get; }
        ISpamToolsProfanityListScreen Profanity_List { get; }
        ISpamToolsSpamRatingsScreen Spam_Ratings { get; }
        ISpamToolsSpamReportingScreen Spam_Reporting { get; }
    }
}