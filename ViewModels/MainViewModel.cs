using Module_12_1.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Module_12_1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Client> _clientsList;
        private Client _selectedClient;
        private ObservableCollection<IAccount<DepositAccount>> _depositAccountList;
        private ObservableCollection<IAccount<NonDepositAccount>> _nonDepositAccountList;
        private IAccount<DepositAccount> _selectedDepositAccount;
        private IAccount<NonDepositAccount> _selectedNonDepositAccount;


        public ObservableCollection<Client> ClientsList { get => _clientsList; set => SetProperty(ref _clientsList, value); }
        public Client SelectedClient
        {
            get => _selectedClient;
            set
            {
                SetProperty(ref _selectedClient, value);

                var depositList = new List<IAccount<DepositAccount>>
                {
                    _selectedClient.DepositAccount
                };
                DepositAccountList = new ObservableCollection<IAccount<DepositAccount>>(depositList);
            }
        }
        public ObservableCollection<IAccount<DepositAccount>> DepositAccountList { get => _depositAccountList; set => SetProperty(ref _depositAccountList, value); }
        public ObservableCollection<IAccount<NonDepositAccount>> NonDepositAccountList { get => _nonDepositAccountList; set => SetProperty(ref _nonDepositAccountList, value); }
        public IAccount<DepositAccount> SelectedDepositAccount { get => _selectedDepositAccount; set => SetProperty(ref _selectedDepositAccount, value); }
        public IAccount<NonDepositAccount> SelectedNonDepositAccount { get => _selectedNonDepositAccount; set => SetProperty(ref _selectedNonDepositAccount, value); }

        public MainViewModel()
        {
            ClientsList = new ObservableCollection<Client>()
            {
                new Client("John", new Account<DepositAccount>(new DepositAccount(), 100), new Account<NonDepositAccount>(new NonDepositAccount(), 200)),
                new Client("Alex", new Account<DepositAccount>(new DepositAccount(), 200), new Account<NonDepositAccount>(new NonDepositAccount(), 300))
            };
        }
    }
}
