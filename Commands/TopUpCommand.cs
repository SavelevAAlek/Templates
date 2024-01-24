using Module_12_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Module_12_1.Commands
{
    public class TopUpCommand : ICommand
    {
        private decimal _amount;
        private Client _selectedClient;      

        public TopUpCommand(decimal amount, Client selectedClient)
        {
            _amount = amount;
            _selectedClient = selectedClient;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return _selectedClient == null ? false : true;
        }

        public void Execute(object? parameter)
        {
            
        }
    }
}
