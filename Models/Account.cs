using System.Collections.Generic;

namespace Module_12_1.Models
{
    public class Account<T> : IAccount<T>
    {
        public T AccountType { get; set; }
        public decimal Amount { get; set; }

        public string Type
        {
            get
            {
                switch (AccountType)
                {
                    case DepositAccount: return "Депозитный";
                    case NonDepositAccount: return "Недепозитный";
                    default: return "-";
                }
            }
        }

        public List<IAccount> Accounts { get; set; }


        public Account(T accountType, decimal amount)
        {
            AccountType = accountType;
            Amount = amount;
        }

        public void TopUp<K>(decimal amount)
        {
            Amount += amount;
        }

        public void TopUp<K>(IAccount<K> account, decimal amount)
        {
            account.Amount += amount;
        }
    }
}
