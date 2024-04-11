namespace AbstractFactory.Example01.ConcreteClasses
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac button");
        }
    }
}
