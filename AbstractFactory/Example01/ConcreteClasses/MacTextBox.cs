namespace AbstractFactory.Example01.ConcreteClasses
{
    public class MacTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac textbox");
        }
    }
}
