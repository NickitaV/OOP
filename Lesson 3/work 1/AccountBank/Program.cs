using System;

namespace AccountBank
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountBank accountBank = new AccountBank { BalanceOfAccount = 100000, NumberOfAccount = 1 };
            AccountBank accountBank1 = new AccountBank { BalanceOfAccount = 0, NumberOfAccount = 2 };
            accountBank.BalanceOfAccount = 100000;
            Console.WriteLine($"Номер счёта: {accountBank.NumberOfAccount} остаток: {accountBank.BalanceOfAccount}");


            Console.WriteLine("Введите сумму перевода:");
            string sum = Console.ReadLine();
            if (String.IsNullOrEmpty(sum)) { Console.WriteLine("строка пуста"); }
            else
            {
                int sumMoney = Convert.ToInt32(sum);
                if (accountBank.BalanceOfAccount >= sumMoney)
                {
                    accountBank.BankTransferMinus(ref accountBank, ref sumMoney);

                    accountBank1.BankTransferPlus(ref accountBank1, ref sumMoney);
                    Console.WriteLine($"Номер счёта: {accountBank.NumberOfAccount} остаток: {accountBank.BalanceOfAccount}");
                    Console.WriteLine($"Номер нового счёта: {accountBank1.NumberOfAccount} остаток: {accountBank1.BalanceOfAccount}");
                }
                else Console.WriteLine("Вы не сможет перевести такую сумму денег");


            }

        }
    }
}
