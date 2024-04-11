namespace AbstractFactory.Example01.ConcreteClasses
{
    public class WindowsDropDown : IDropDown
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows dropdown");
        }
    }
}
