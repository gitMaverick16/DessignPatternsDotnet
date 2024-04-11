namespace AbstractFactory.Example01.ConcreteClasses
{
    public class MacDropDown : IDropDown
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac dropdown");
        }
    }
}
