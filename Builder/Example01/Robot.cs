namespace Builder.cs.Example01
{
    public class Robot
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public string Arms { get; set; }
        public string Legs { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine("Robot info:");
            Console.WriteLine($"Head: {Head}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Arms: {Arms}");
            Console.WriteLine($"Legs: {Legs}");
        }
    }
}
