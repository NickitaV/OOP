using System;

namespace AccountBank
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountBank accountBank1 = new AccountBank();
            accountBank1.NumberOfAccount();
            accountBank1.TypeSetting(AccountBank.AccountType.Current);
            accountBank1.BalanceOfAccount(100000);
            accountBank1.AllInfo();
            AccountBank accountBank2 = new AccountBank();
            accountBank2.NumberOfAccount();
            accountBank2.TypeSetting(AccountBank.AccountType.Credit);
            accountBank2.BalanceOfAccount(200000);
            accountBank2.AllInfo();
        }
    }
}
