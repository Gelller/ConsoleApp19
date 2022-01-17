using System;
using System.Collections.Generic;
using System.IO;
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

            test2.TransferMoney(test, 100);

            test.AccountWithdrawal();
            test2.AccountWithdrawal();

            var testString = test.TestMethod("qwerty");
            Console.WriteLine(testString);


            string firtstTxt = "\\test.txt";
            string secondTxt = "\\test2.txt";

            string info = "Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & Pasha@mail.ru";
            var path = Directory.GetCurrentDirectory();
            File.WriteAllText(path + firtstTxt, info);


            string outputText=File.ReadAllText(path + firtstTxt );         
            test.TestMethodEmail(ref outputText);

            File.WriteAllText(path + secondTxt, outputText);

            BankAccount test3 = new BankAccount(100);
            BankAccount test4 = new BankAccount(0, BankAccount.EnumBankAccountType.Type_2);

            bool testBool = test3 == test4;

            bool testBool2 = test3 != test4;


            Console.WriteLine(test4.ToString());
            Console.ReadLine();
        }
    }
}
