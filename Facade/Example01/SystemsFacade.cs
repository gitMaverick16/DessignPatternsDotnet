namespace Facade.Example01
{
    public class SystemsFacade
    {
        private Subsystem1 _subsystem1;
        private Subsystem2 _subsystem2;
        public SystemsFacade()
        {
            _subsystem1 = new Subsystem1();
            _subsystem2 = new Subsystem2();
        }

        public void Operation()
        {
            Console.WriteLine("Start of operation");
            _subsystem1.MethodA();
            _subsystem1.MethodB();
            _subsystem2.MethodC();
            _subsystem2.MethodD();
        }
    }
}
