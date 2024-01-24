using Module_12_1.Models;
using System;
using System.Windows.Input;

namespace Module_12_1.Commands
{
    public class TopUpCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private decimal _amount;
        private Client _selectedClient;
        private IAccount _account;

        public TopUpCommand(decimal amount, Client selectedClient, IAccount selectedAccount)
        {
            _amount = amount;
            _selectedClient = selectedClient;
            _account = selectedAccount;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            switch (_account)
            {
                case DepositAccount: _account.TopUp<DepositAccount>(_amount); break;
                case NonDepositAccount: _account.TopUp<NonDepositAccount>(_amount); break;
            }            
        }
    }
}
