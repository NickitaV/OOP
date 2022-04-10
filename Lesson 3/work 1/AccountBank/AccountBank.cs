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


        public int NumberOfAccount
        {
            get { return _numberOfAccount; }
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
        public decimal BalanceOfAccountPlus
        {
            get { return _balanceOfAccount; }
            set { _balanceOfAccount += value; }
        }
        public decimal BalanceOfAccountMinus
        {
            get { return _balanceOfAccount; }
            set
            {
                if (_balanceOfAccount >= value) { _balanceOfAccount -= value; }
                else Console.WriteLine("Вы не сможет снять такую сумму денег");
            }
        }
        public void BankTransferMinus(ref AccountBank accountBank, ref int sumMoney)
        {
            accountBank.BalanceOfAccountMinus = sumMoney;



        }

        public void BankTransferPlus(ref AccountBank accountBank, ref int sumMoney)
        {
            accountBank.BalanceOfAccountPlus = sumMoney;




        }
    }
}
