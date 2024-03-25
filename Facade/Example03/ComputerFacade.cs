namespace Facade.Example03
{
    public class ComputerFacade
    {
        private CPU cpu;
        private Memory memory;
        private HardDrive hardDrive;
        public ComputerFacade()
        {
            cpu = new CPU();
            memory = new Memory();
            hardDrive = new HardDrive();
        }
        public void StartComputer()
        {
            Console.WriteLine("Starting computer...");
            cpu.StartCPU();
            memory.StartMemory();
            hardDrive.StartHardDrive();
            Console.WriteLine("Computer started successfully");
        }

        public void StopComputer()
        {
            Console.WriteLine("Shutting down computer...");
            cpu.StopCPU();
            memory.StopMemory();
            hardDrive.StopHardDrive();
            Console.WriteLine("Computer shut down successfully");
        }
    }
}
