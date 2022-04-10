using System;

namespace AccountBank
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountBank accountBank = new AccountBank();
           
            Console.WriteLine($"Тип счёта: {accountBank.TypeSetting(AccountBank.AccountType.Current)}");
            Console.WriteLine($"Номер счёта: { accountBank.NumberOfAccount(1)}");
            Console.WriteLine($"Баланс на счёте: {accountBank.BalanceOfAccount(100000)}");
        }
    }
}
