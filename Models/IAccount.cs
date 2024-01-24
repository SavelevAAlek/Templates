using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12_1.Models
{
    public interface IAccount<out T> : IAccount
    {
        public decimal Amount { get; set; }
        string Type { get; }
        
    }
    
    public interface IAccount
    {
        string Type { get; }
        List<IAccount> Accounts { get; set; }
        void TopUp<K>(IAccount<K> account, decimal amount);
    }
}
