namespace Test.UiMaps.UiMapItems.CheckBox
{
    public interface ICheckBox : IUiMapItem
    {
        void Enable();

        void Disable();

        bool IsEnabled { get; }
    }
}