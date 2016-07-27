namespace Test.UiMaps.UiMapItems.CheckBox
{
    public interface ICheckBox
    {
        bool IsEnabled { get; }

        bool IsOnScreen { get; }

        void Enable();

        void Disable();
    }
}