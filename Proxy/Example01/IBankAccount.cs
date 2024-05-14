namespace Proxy.Example01
{
    public interface IBankAccount
    {
        void Deposit(int amount);
        bool Withdraw(int amount);
        int GetBalance();
    }
}
