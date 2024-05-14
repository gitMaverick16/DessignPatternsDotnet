using Proxy.Example01;
using Proxy.Example02;

//Example 01
BankAccount myAccount = new BankAccount(15000);

BankAccountProxy myAccountProxy = new BankAccountProxy(myAccount);

bool result = myAccountProxy.Withdraw(500);

if (result)
{
    Console.WriteLine($"Withdrawal successful. Balance is now {myAccountProxy.GetBalance()}");
}
else
{
    Console.WriteLine("Withdrawal not possible");
}


result = myAccountProxy.Withdraw(12000);
if (result)
{
    Console.WriteLine($"Withdrawal successful. Balance is now {myAccountProxy.GetBalance}");
}
else
{
    Console.WriteLine("Withdrawal not possible");
}

//Example 02
ISecurityCamera bedroomCamera = new SecurityCameraProxy("bedroom", false);
bedroomCamera.DisplayLiveFeed();

ISecurityCamera livingroomCamera = new SecurityCameraProxy("livingroom", false);
livingroomCamera.DisplayLiveFeed();

