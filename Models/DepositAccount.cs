using System.Collections.Generic;

namespace Module_12_1.Models
{
    public class DepositAccount : IAccount<DepositAccount>
    {
        public decimal Amount { get; set; }

        public DepositAccount Type { get; }

        public void TopUp(decimal amount)
        {
            Amount += amount;
        }
    }
}
