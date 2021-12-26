using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class BankAccount
    {
        private static int _accountСounter = 1;

        private int _accountNumber;
        private int _accountBalance;
        private EnumBankAccountType _bankAccountType;
        private int AccountNumber 
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
                _accountСounter++;
            }
        }
        private int AccountBalance 
         {
            get
            {
                return _accountBalance;
            }
            set
            {
                _accountBalance = value;                
            }
        }
        private EnumBankAccountType BankAccountType 
         {
            get
            {
                return _bankAccountType;
            }
            set
            {
                _bankAccountType = value;                
            }
        }

        public enum EnumBankAccountType
        {
            None,
            Type_1,
            Type_2,
            Type_3
        };

        public BankAccount(int accountBalance) : this(accountBalance, EnumBankAccountType.None)
        {                   
        }

        public BankAccount(EnumBankAccountType bankAccountType) : this(0, bankAccountType)
        {
        }

        public BankAccount(int accountBalance, EnumBankAccountType bankAccountType)
        {
            AccountNumber = _accountСounter;
            AccountBalance = accountBalance;
            BankAccountType = bankAccountType;
        }



        public void Withdraw(int accountNumber, int withdrawalAmount)
        {
            if(AccountNumber== accountNumber && AccountBalance >= withdrawalAmount && withdrawalAmount > 0)
            {
                AccountBalance = AccountBalance - withdrawalAmount;
            }

        }

        public void PutOnTheAccount(int accountNumber, int amountForReplenishment)
        {
            if (AccountNumber == accountNumber && amountForReplenishment > 0)
            {
                AccountBalance = AccountBalance + amountForReplenishment;
            }
        }

        public void AccountWithdrawal()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}  Баланс: {AccountBalance} Тип счета: { BankAccountType} ");
        }
    }
}
