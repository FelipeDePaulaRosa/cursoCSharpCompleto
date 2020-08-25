using ExercicioTryCatch.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTryCatch.Entities
{
    class Account
    {
        public int Number { get; set; } //numero da conta
        public string Holder { get; set; } //titular
        public double Balance { get; set; } //saldo
        public double WithdrawLimit { get; set; } //limite de saque

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            /*if(balance == 0)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }*/
            
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) //depositar
        {
            Balance += amount;
        }

        public void WithDraw(double amount) //sacar
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }
            Balance -= amount;
        }
    }
}
