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

        public Account(T accountType, decimal amount)
        {
            AccountType = accountType;
            Amount = amount;
        }

        //public void TopUp<T>(Client selectedClient, IAccount<T> account, decimal amount)
        //{
        //    if (account is DepositAccount) selectedClient.DepositAccount.Amount += amount;
        //    else if (account is NonDepositAccount) selectedClient.NonDepositAccount.Amount += amount;
        //    else return;
        //}

    }
}
