using System.Collections.Generic;

namespace Module_12_1.Models
{
    public class Client : IAccount
    {
        public string Name { get; set; }
        public IAccount<DepositAccount> DepositAccount { get; set; }
        public IAccount<NonDepositAccount> NonDepositAccount { get; set; }

        public List<IAccount> Accounts { get; set; }

        public Client(string name, IAccount<DepositAccount> depositAccount, IAccount<NonDepositAccount> nonDepositAccount)
        {
            Name = name;
            DepositAccount = depositAccount;
            NonDepositAccount = nonDepositAccount;

            Accounts = new List<IAccount>
            {
                DepositAccount,
                NonDepositAccount
            };
        }

        public void TopUp<T>(IAccount<T> account, decimal amount)
        {
            account.Amount += amount;
        }
    }
}
