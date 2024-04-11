namespace AbstractFactory.Example01.ConcreteClasses
{
    public class LinuxTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux textbox");
        }
    }
}
