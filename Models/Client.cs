using System.Collections.Generic;

namespace Module_12_1.Models
{
    public class Client 
    {
        public string Name { get; set; }
        public List<IAccount<object>> AccountsList { get; set; }
        public Client(string name, Account<DepositAccount> depositAccount, Account<NonDepositAccount> nonDepositAccount)
        {
            Name = name;
            AccountsList = new List<IAccount<object>>() { depositAccount, nonDepositAccount };
        }

    }
}
