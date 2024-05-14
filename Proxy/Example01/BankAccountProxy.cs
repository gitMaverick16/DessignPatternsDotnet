namespace Proxy.Example01
{
    public class BankAccountProxy : IBankAccount
    {
        private BankAccount _bankAccount;
        public BankAccountProxy(BankAccount bankAccount)
        {
            _bankAccount = bankAccount;
        }
        public void Deposit(int amount)
        {
            _bankAccount.Deposit(amount);
        }

        public int GetBalance()
        {
            return _bankAccount.GetBalance();
        }

        public bool Withdraw(int amount)
        {
            if(amount > 10000)
            {
                Console.WriteLine("Yo need manager approval for withdraws over 10000");
                return false;
            }
            return _bankAccount.Withdraw(amount);
        }
    }
}
