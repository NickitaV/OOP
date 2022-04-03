using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBank
{
    class AccountBank
    {
        private int _numberOfAccount;
        private decimal _balanceOfAccount;
        private AccountType _type;



        public enum AccountType
        {
            Current, Sattlement, Savings, Credit


        }



        public int NumberOfAccount(int numberOfAccount)
        {
            _numberOfAccount = numberOfAccount;
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


    }
}
