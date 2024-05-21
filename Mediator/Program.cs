using Mediator.Example01;
using Mediator.Example02;

//Example 01
var inventorySystem = new InvetorySystem(null);
var shoppingCart = new ShoppingCart(null);

var ecommercePlatform = new EcommercePlatform(shoppingCart, inventorySystem);

inventorySystem.SetMediator(ecommercePlatform);
shoppingCart.SetMediator(ecommercePlatform);

shoppingCart.AddItem("Apple");
shoppingCart.AddItem("Orange");

//Example 02
IAirTrafficControl tower = new Tower();
Aircraft airplane1 = new Airplane(tower, "Airplane1");
Aircraft airplane2 = new Airplane(tower, "Airplane2");

airplane1.SendMessage("Hello from Airplane1!");
