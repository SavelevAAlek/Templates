using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12_1.Models
{
    public class Client
    {
        public string Name { get; set; }
        public DepositAccount DepositAccount { get; set; }
        public NonDepositAccount NonDepositAccount { get; set; }
    }
}
