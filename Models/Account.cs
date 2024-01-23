using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12_1.Models
{
    public class Account<T>
    {
        public T AccountType { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public Account(T accountType, string name, decimal amount)
        {
            AccountType = accountType;
            Name = name;
            Amount = amount;
        }
    }
}
