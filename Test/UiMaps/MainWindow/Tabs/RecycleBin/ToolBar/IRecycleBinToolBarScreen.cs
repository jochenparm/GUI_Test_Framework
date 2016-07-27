namespace Test.UiMaps.MainWindow.Tabs.RecycleBin.ToolBar
{
    public interface IRecycleBinToolBarScreen
    {
        UiMapItems.Button.IButton Restore_Button { get; }
        UiMapItems.Button.IButton EmptyBin_Button { get; }

        UiMapItems.Button.IButton DisplayOption_Button { get; }

        UiMapItems.CheckBox.ICheckBox ShowAllEmailLogged_CheckBox { get; }
        UiMapItems.CheckBox.ICheckBox HideAutodeletedEmails_CheckBox { get; }
    }
}