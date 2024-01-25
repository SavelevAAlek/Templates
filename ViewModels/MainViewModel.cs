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
        private decimal _amount;
        private IAccount<object> _selectedAccount;

        public ObservableCollection<Client> ClientsList { get => _clientsList; set => SetProperty(ref _clientsList, value); }
        public Client SelectedClient { get => _selectedClient; set => SetProperty(ref _selectedClient, value); }
        public decimal Amount { get => _amount; set => SetProperty(ref _amount, value); }
        public IAccount<object> SelectedAccount { get => _selectedAccount; set => SetProperty(ref _selectedAccount, value); }
       


        public ICommand TopUpBalanceCommand { get; }

        public MainViewModel()
        {
            ClientsList = new ObservableCollection<Client>()
            {
                new Client("John", new Account<DepositAccount>(new DepositAccount(), 100), new Account<NonDepositAccount>(new NonDepositAccount(), 200)),
                new Client("Alex", new Account<DepositAccount>(new DepositAccount(), 200), new Account<NonDepositAccount>(new NonDepositAccount(), 300))
            };

            TopUpBalanceCommand = new RelayCommand(ExecuteTopUp, CanTopUp);
        }

        private bool CanTopUp(object p) => true;
        private void ExecuteTopUp(object p)
        {
            SelectedAccount.TopUp(Amount);
        }
    }
}
