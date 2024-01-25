using Module_12_1.ViewModels;
using System.Collections.Generic;

namespace Module_12_1.Models
{
    public class Account<T> : ViewModelBase, IAccount<T>
    {
        private decimal _amount;
        public T Type { get; set; }
        public decimal Amount { get => _amount; set => SetProperty(ref _amount, value); }
        public Account(T type, decimal amount)
        {
            Type = type;
            Amount = amount;
        }

        public Account() { }
        public void TopUp(decimal amount)
        {
            Amount += amount;
        }
    }
}
