namespace Test.UiMaps.UiMapItems.CheckBox
{
    public interface ICheckBox : IUiMapItem
    {
        void Enable();

        void Disable();

        void Set(bool enable);

        bool IsEnabled { get; }
    }
}