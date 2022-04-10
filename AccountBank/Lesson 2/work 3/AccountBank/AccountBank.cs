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


        public int Number() { return _number++; }
        public enum AccountType
        {
            Current, Sattlement, Savings, Credit


        }
        private AccountType _type;



        public AccountBank()
        {
            _numberOfAccount = Number();

            Console.WriteLine($"Номер счёта: {this._numberOfAccount}");

        }
        public AccountBank(decimal balanceOfAccount)
        {
            _numberOfAccount = Number();
            _balanceOfAccount = balanceOfAccount;
            Console.WriteLine($"Номер счёта: {this._numberOfAccount}" + $" Баланс на счёте: {this._balanceOfAccount}");

        }
        public AccountBank(AccountType typeSetting)
        {
            _numberOfAccount = Number();
            _type = typeSetting;
            Console.WriteLine($"Номер счёта: {this._numberOfAccount}" + $" Тип счёта: {typeSetting}");
        }
        public AccountBank(decimal balanceOfAccount, AccountType typeSetting)
        {
            _numberOfAccount = Number();
            _balanceOfAccount = balanceOfAccount;
            _type = typeSetting;
            Console.WriteLine($"Номер счёта: {this._numberOfAccount}" + $" Баланс на счёте: {this._balanceOfAccount}" + $" Тип счёта: {typeSetting}");
        }












    }
}
