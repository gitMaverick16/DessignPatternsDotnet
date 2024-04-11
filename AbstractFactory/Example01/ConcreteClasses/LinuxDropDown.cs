namespace AbstractFactory.Example01.ConcreteClasses
{
    public class LinuxDropDown : IDropDown
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux dropdown");
        }
    }
}
