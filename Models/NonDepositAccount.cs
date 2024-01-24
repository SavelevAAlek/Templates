namespace Module_12_1.Models
{
    public class NonDepositAccount : IAccount<NonDepositAccount>
    {
        public decimal Amount { get; set; }
        public NonDepositAccount AccountType { get; set; }

        public NonDepositAccount() { }
    }
}
