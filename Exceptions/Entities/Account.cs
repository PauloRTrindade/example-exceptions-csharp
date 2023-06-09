﻿using Exceptions.Entities.Exception;

namespace Exceptions.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < WithdrawLimit && amount < Balance)
            {
                Balance -= amount;
            }
            else if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else
            {
                throw new DomainException("Not enough balance");
            }
        }
    }
}
