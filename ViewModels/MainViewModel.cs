using Module_12_1.Commands;
using Module_12_1.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Principal;
using System.Windows.Input;

namespace Module_12_1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Client> _clientsList;
        private Client _selectedClient;
        private Client _destinationClient;
        private decimal _amount;
        private decimal _transferAmount;
        private IAccount<object> _topUpAccount;
        private IAccount<object> _selectedAccount;
        private IAccount<object> _destinationAccount;

        /// <summary>
        /// Список клиентов 
        /// </summary>
        public ObservableCollection<Client> ClientsList { get => _clientsList; set => SetProperty(ref _clientsList, value); }

        /// <summary>
        /// Выбранный клиент
        /// </summary>
        public Client SelectedClient { get => _selectedClient; set => SetProperty(ref _selectedClient, value); }

        /// <summary>
        /// Клиент для перевода 
        /// </summary>
        public Client DestinationClient { get => _destinationClient; set => SetProperty(ref _destinationClient, value); }

        /// <summary>
        /// Сумма пополнения
        /// </summary>
        public decimal Amount { get => _amount; set => SetProperty(ref _amount, value); }

        /// <summary>
        /// Сумма перевода другому клиенту
        /// </summary>
        public decimal TransferAmount { get => _transferAmount; set => SetProperty(ref _transferAmount, value); }

        /// <summary>
        /// Аккаунт для списания
        /// </summary>
        public IAccount<object> SelectedAccount { get => _selectedAccount; set => SetProperty(ref _selectedAccount, value); }

        /// <summary>
        /// Аккаунт для пополнения текущего клиента
        /// </summary>
        public IAccount<object> TopUpAccount { get => _topUpAccount; set => SetProperty(ref _topUpAccount, value); }

        /// <summary>
        /// Аккаунт для пополнения
        /// </summary>
        public IAccount<object> DestinationAccount { get => _destinationAccount; set => SetProperty(ref _destinationAccount, value); }


        /// <summary>
        /// Команда пополнения текущего счета
        /// </summary>
        public ICommand TopUpBalanceCommand { get; }

        /// <summary>
        /// Команда для перевода средств между счетами
        /// </summary>
        public ICommand TransferCommand { get; }

        public MainViewModel()
        {
            ClientsList = new ObservableCollection<Client>()
            {
                new Client("John", new Account<DepositAccount>(new DepositAccount(), 100), new Account<NonDepositAccount>(new NonDepositAccount(), 200)),
                new Client("Alex", new Account<DepositAccount>(new DepositAccount(), 200), new Account<NonDepositAccount>(new NonDepositAccount(), 300))
            };

            TopUpBalanceCommand = new RelayCommand(ExecuteTopUp, CanTopUp);
            TransferCommand = new RelayCommand(ExecuteTransfer, CanTransfer);
        }


        #region TopUpBalanceCommand
        private bool CanTopUp(object p) => true;
        private void ExecuteTopUp(object p)
        {
            TopUpAccount.TopUp(Amount);
        }
        #endregion

        #region TransferCommand
        private bool CanTransfer(object p) => true;
        private void ExecuteTransfer(object p)
        {
            var account = new Account<object>(SelectedAccount);
            account.TransferTo(DestinationAccount, TransferAmount);
            SelectedAccount.Amount -= TransferAmount;
        }
        #endregion
    }
}
