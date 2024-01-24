using System.Collections.Generic;

namespace Module_12_1.Models
{
    public class Client
    {
        public string Name { get; set; }
        public IAccount<DepositAccount> DepositAccount { get; set; }
        public IAccount<NonDepositAccount> NonDepositAccount { get; set; }

        public Client(string name, IAccount<DepositAccount> depositAccount, IAccount<NonDepositAccount> nonDepositAccount)
        {
            Name = name;
            DepositAccount = depositAccount;
            NonDepositAccount = nonDepositAccount;
        }

        public void TopUp<T>(/*Client selectedClient, */IAccount<T> account, decimal amount)
        {
            //if (account is DepositAccount) selectedClient.DepositAccount.Amount += amount;
            //else if (account is NonDepositAccount) selectedClient.NonDepositAccount.Amount += amount;
            //else return;

            account.Amount += amount;
        }
    }
}
