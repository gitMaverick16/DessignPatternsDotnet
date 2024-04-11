namespace AbstractFactory.Example01
{
    public interface IThemeFactory
    {
        IButton CreateButton();
        IDropDown CreateDropDown();
        ITextBox CreateTextBox();
    }
}
