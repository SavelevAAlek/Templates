namespace Module_12_1.Models
{
    public class DepositAccount : IAccount<DepositAccount>
    {
        public decimal Amount { get; set; }
        public DepositAccount AccountType {get; set; }  

        public DepositAccount() { }

    }
}
