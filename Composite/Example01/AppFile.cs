namespace Composite.Example01
{
    public class AppFile : IFileSystemItem
    {
        private readonly string _name;
        public AppFile(string name)
        {

            _name = name;
        }
        public void Display(string indent = "")
        {
            Console.WriteLine($"{indent}- {this.GetType().Name}: {_name}");
        }
    }
}
