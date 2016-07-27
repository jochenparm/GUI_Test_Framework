namespace Test.UiMaps.MainWindow.Menu.File
{
    public interface IFileMenuScreen
    {
        UiMapItems.Button.IButton CheckMail_Button { get; }
        UiMapItems.Button.IButton WashMail_Button { get; }
        UiMapItems.Button.IButton MailProgram_Button { get; }
        UiMapItems.Button.IButton Import_Button { get; }
        UiMapItems.Button.IButton Export_Button { get; }
        UiMapItems.Button.IButton Exit_Button { get; }
    }
}