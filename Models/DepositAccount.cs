using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12_1.Models
{
    public class DepositAccount : Account<DepositAccount>
    {
        public DepositAccount(DepositAccount type, string name, decimal amount) : base(type, name, amount) { }
    }
}
