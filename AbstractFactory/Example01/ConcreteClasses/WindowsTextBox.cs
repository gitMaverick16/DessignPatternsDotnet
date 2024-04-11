namespace AbstractFactory.Example01.ConcreteClasses
{
    public class WindowsTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows textbox");
        }
    }
}
