using System;

namespace AccountBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AccountBank accountBankN = new AccountBank();
            AccountBank accountBankBalance = new AccountBank(10000);
            AccountBank accountBankType = new AccountBank(AccountBank.AccountType.Current);
            AccountBank accountBankAll = new AccountBank(500000, AccountBank.AccountType.Credit);


        }
    }
}
