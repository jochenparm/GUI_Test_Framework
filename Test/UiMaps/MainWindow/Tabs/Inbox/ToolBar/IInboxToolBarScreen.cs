namespace Test.UiMaps.MainWindow.Tabs.Inbox.ToolBar
{
    public interface IInboxToolBarScreen
    {
        UiMaps.UiMapItems.Button.IButton CheckMail_Button { get; }
        UiMaps.UiMapItems.DropDownMenu.IDropDownMenu CheckMail_DropDownMenu { get; }
        UiMaps.UiMapItems.TextLabel.ITextLabel CheckMail_TextLabel { get; }
        UiMaps.UiMapItems.Button.IButton WashMail_Button { get; }
        UiMaps.UiMapItems.Button.IButton MailProgram_Button { get; }
        UiMaps.UiMapItems.Button.IButton Register_Button { get; }
        UiMaps.UiMapItems.Button.IButton SearchInbox_Button { get; }
        UiMaps.UiMapItems.Button.IButton DisplayOptions_Button { get; }
    }
}