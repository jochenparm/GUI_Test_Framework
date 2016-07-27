namespace Test.UiMaps.UiMapItems.Button
{
    public interface IButton
    {
        void Click();

        bool IsEnabled { get; }
        bool IsOnScreen { get; }
    }
}