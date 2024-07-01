using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Map_Gen_SND
{
    public class CMD_Handler : ICommand
    {
 
        private readonly bool _canExecute;
        private readonly Action _action;

        public CMD_Handler(Action action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
