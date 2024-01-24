using System.Collections.Generic;

namespace Module_12_1.Models
{
    public class DepositAccount : IAccount<DepositAccount>
    {
        public decimal Amount { get; set; }
        public DepositAccount AccountType {get; set; }
        public List<IAccount> Accounts { get; set; }
        public string Type { get; }
        public DepositAccount() { }

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
