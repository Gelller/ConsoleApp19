using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount test = new BankAccount(100);
            BankAccount test2 = new BankAccount(BankAccount.EnumBankAccountType.Type_2);
      
            test.AccountWithdrawal();
            test2.AccountWithdrawal();

            test.Withdraw(1, 20);
            test2.Withdraw(2, 40);

            test.PutOnTheAccount(1, 2000);
            test2.PutOnTheAccount(2, 400);

            test.AccountWithdrawal();
            test2.AccountWithdrawal();

            Console.ReadLine();
        }
    }
}
