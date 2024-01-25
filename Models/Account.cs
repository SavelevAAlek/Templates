using Module_12_1.ViewModels;
using System.Collections.Generic;

namespace Module_12_1.Models
{
    public class Account<T> : ViewModelBase, IAccount<T>, ITransfer<T>
    {
        public IAccount<object> SelectedAccount { get; set; }
        private decimal _amount;
        public T Type { get; set; }

        /// <summary>
        /// Название аккаунта для View
        /// </summary>
        public string Name
        {
            get
            {
                if (Type is DepositAccount) return "Депозитный";
                else return "Недепозитный";
            }
        }
        public decimal Amount { get => _amount; set => SetProperty(ref _amount, value); }
        public Account(T type, decimal amount)
        {
            Type = type;
            Amount = amount;
        }
        public Account() { }
        public Account(IAccount<object> account) { SelectedAccount = account; }

        /// <summary>
        /// Пополнение счета текущего аккаунта
        /// </summary>
        /// <param name="amount"></param>
        public void TopUp(decimal amount)
        {
            Amount += amount;
        }

        /// <summary>
        /// Перевод средств на другой аккаунт
        /// </summary>
        /// <param name="destinationAccount"></param>
        /// <param name="amount"></param>
        public void TransferTo(IAccount<T> destinationAccount, decimal amount)
        {
            Amount -= amount;
            destinationAccount.TopUp(amount);
        }
    }
}
