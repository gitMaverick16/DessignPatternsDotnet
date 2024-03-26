namespace Builder.Example02
{
    public class Burger
    {
        public string Bread { get; set; }
        public string Meat { get; set; }
        public string Cheese { get; set; }
        public string Dressing { get; set; }
        public string Lettuce { get; set; }
        public string Tomato { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine("Burger info:");
            Console.WriteLine($"Bread: {Bread}");
            Console.WriteLine($"Meat: {Meat}");
            Console.WriteLine($"Cheese: {Cheese}");
            Console.WriteLine($"Dressing: {Dressing}");
            Console.WriteLine($"Lettuce: {Lettuce}");
            Console.WriteLine($"Tomato: {Tomato}");
        }
    }
}
