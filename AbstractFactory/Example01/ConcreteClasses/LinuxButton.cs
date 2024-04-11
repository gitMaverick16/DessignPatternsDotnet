namespace AbstractFactory.Example01.ConcreteClasses
{
    public class LinuxButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux button");
        }
    }
}
