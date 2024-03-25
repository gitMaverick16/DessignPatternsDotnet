using Facade.Example03;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComputerFacade computerFacade = new ComputerFacade();
            computerFacade.StartComputer();
            Console.WriteLine();
            computerFacade.StopComputer();
        }
    }
}
