using System.Collections.Generic;

namespace Module_12_1.Models
{
    public class NonDepositAccount : IAccount<NonDepositAccount>
    {
        public decimal Amount { get; set; }
        public NonDepositAccount AccountType { get; set; }
        public List<IAccount> Accounts { get; set; }
        public string Type { get; }

        public NonDepositAccount() { }

        public void TopUp<K>(IAccount<K> account, decimal amount)
        {
            throw new System.NotImplementedException();
        }

        public void TopUp<K>(decimal amount)
        {
            throw new System.NotImplementedException();
        }
    }
}
