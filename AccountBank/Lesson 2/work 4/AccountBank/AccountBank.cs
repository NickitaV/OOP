using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBank
{
    class AccountBank
    {
        private int _number=1;
        private int _numberOfAccount;
        private decimal _balanceOfAccount;

        public int Number() { return _number++; }
        public int NumberOfAccount{ get{ return _numberOfAccount= Number(); }
            set { _numberOfAccount = value; }
        }


        public enum AccountType
        {
            Current, Sattlement, Savings, Credit


        }

       

  
        public decimal BalanceOfAccount
        {
            get { return _balanceOfAccount; }
            set { _balanceOfAccount = value; }
        }
        public AccountType TypeSetting { get; set; }

       
    }
}
