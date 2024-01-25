using Module_12_1.Models;
using System;
using System.Windows.Input;

namespace Module_12_1.Commands
{
    public class TopUpCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;


        public TopUpCommand()
        {
            
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
                    
        }
    }
}
