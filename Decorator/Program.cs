using Decorator.Example01;
using Decorator.Example02;

//Example 01
ICoffee coffee = new SimpleCoffee();
Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

coffee = new MilkDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

coffee = new WhippedCreamDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} : ${coffee.GetCost()}");

//Example 02
IBurger burger = new BasicBurger();
Console.WriteLine($"{burger.GetDescription()} : ${burger.GetCost()}");

burger = new CheeseDecorator(burger);
Console.WriteLine($"{burger.GetDescription()} : ${burger.GetCost()}");

burger = new BaconDecorator(burger);
Console.WriteLine($"{burger.GetDescription()} : ${burger.GetCost()}");
