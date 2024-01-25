﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12_1.Models
{
    public interface IAccount<out T>
    {
        T Type { get; }
        decimal Amount { get; set; }
        void TopUp(decimal amount);
    }


}
