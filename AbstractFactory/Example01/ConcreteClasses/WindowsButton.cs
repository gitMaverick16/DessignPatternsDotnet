namespace AbstractFactory.Example01.ConcreteClasses
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows button");
        }
    }
}
