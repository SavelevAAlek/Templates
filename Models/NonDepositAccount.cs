using System.Collections.Generic;

namespace Module_12_1.Models
{
    public class NonDepositAccount : IAccount<NonDepositAccount>
    {
        public NonDepositAccount Type { get; }
        public decimal Amount { get; set; }
        public void TopUp(decimal amount)
        {
            Amount += amount;
        }
    }
}
