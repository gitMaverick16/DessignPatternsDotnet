using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example01
{
    public class BankAccount : IBankAccount
    {
        private int _balance;
        public BankAccount(int balance)
        {
            _balance = balance;
        }
        public void Deposit(int amount)
        {
            _balance += amount;
        }

        public int GetBalance()
        {
            return _balance;
        }

        public bool Withdraw(int amount)
        {
            if(_balance >= amount)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }
    }
}
