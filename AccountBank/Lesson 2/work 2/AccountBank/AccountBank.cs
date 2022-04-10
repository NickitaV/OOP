using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBank
{
    class AccountBank
    {
        private static int _number = 1;
        private int _numberOfAccount;
        private decimal _balanceOfAccount;
        private AccountType _type;

        public int Number() { return _number++; }

        public enum AccountType
        {
            Current, Sattlement, Savings, Credit


        }



        public int NumberOfAccount()
        {
            _numberOfAccount = Number();
            return _numberOfAccount;
        }
        public decimal BalanceOfAccount(decimal balanceOfAccount)
        {
            _balanceOfAccount = balanceOfAccount;
            return _balanceOfAccount;
        }
        public AccountType TypeSetting(AccountType type)
        {
            _type = type;
            return _type;
        }
        public void AllInfo() { Console.WriteLine($"Тип счёта: {_type}\nНомер счёта: { _numberOfAccount}\nБаланс на счёте: {_balanceOfAccount}"); }

    }
}
