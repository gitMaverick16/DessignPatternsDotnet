using Command.Example01;
using Command.Example02;

//Example 01
Order order = new Order();
Command.Example01.ICommand placeOrder = new PlaceOrderCommand(order);
Command.Example01.ICommand cancelOrder = new CancelOrderCommand(order);

Waiter waiter = new Waiter();
waiter.TakeCommand(placeOrder);
waiter.TakeCommand(cancelOrder);

//Example 02
SmartTV smartTV = new SmartTV();
Command.Example02.ICommand netflix = new NetflixCommand(smartTV);
Command.Example02.ICommand amazon = new AmazonCommand(smartTV);

RemoteControl remoteControl = new RemoteControl();
remoteControl.TakeCommand(netflix);
remoteControl.TakeCommand(amazon);