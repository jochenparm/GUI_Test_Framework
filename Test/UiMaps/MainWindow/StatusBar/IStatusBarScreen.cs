namespace Test.UiMaps.MainWindow.StatusBar
{
    public interface IStatusBarScreen
    {
        UiMaps.UiMapItems.TextLabel.ITextLabel MailStatus_TextLabel { get; }
        UiMaps.UiMapItems.Button.IButton DeleteStatus_Button { get; }
    }
}