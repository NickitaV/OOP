using System;

namespace AccountBank
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountBank accountBank = new AccountBank();
           
            accountBank.BalanceOfAccount = 100000;
            accountBank.TypeSetting = AccountBank.AccountType.Current;
            Console.WriteLine($"Тип счёта: {accountBank.TypeSetting}");
            Console.WriteLine($"Номер счёта: {accountBank.NumberOfAccount}");
            Console.WriteLine($"Баланс на счёте: {accountBank.BalanceOfAccount}");
            AccountBank accountBank2 = new AccountBank();

            accountBank.BalanceOfAccount = 200000;
            accountBank.TypeSetting = AccountBank.AccountType.Savings;
            Console.WriteLine($"Тип счёта: {accountBank.TypeSetting}");
            Console.WriteLine($"Номер счёта: {accountBank.NumberOfAccount}");
            Console.WriteLine($"Баланс на счёте: {accountBank.BalanceOfAccount}");
        }
    }
}
