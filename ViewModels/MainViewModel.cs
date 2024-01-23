using Module_12_1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Module_12_1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Client> _clientsList;
        private Client _selectedClient;

        public ObservableCollection<Client> ClientsList { get => _clientsList; set => SetProperty(ref _clientsList, value); }
        public Client SelectedClient { get => _selectedClient; set => SetProperty(ref _selectedClient, value); }

        public MainViewModel()
        {
            ClientsList = new ObservableCollection<Client>();
        }
    }
}
