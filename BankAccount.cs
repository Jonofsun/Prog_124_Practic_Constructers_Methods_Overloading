using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Practic_Constructers_Methods_Overloading
{
    internal class BankAccount
    {
        string _accountNumber;
        string _customerName;
        double _balance;

        public BankAccount(string accountNumber, string customerName, double balance)
        {
            _accountNumber = accountNumber;
            _customerName = customerName;
            _balance = balance;
        }

        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public double Balance { get => _balance;}

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && _balance >= amount) { _balance -= amount; }
        }
        public override string ToString()
        {
            return $"{AccountNumber} - {CustomerName} - Current Balance: {Balance.ToString("c")}";
        }
    }
}
