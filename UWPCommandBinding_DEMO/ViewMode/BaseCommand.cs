using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UWPCommandBinding_DEMO.ViewMode
{
    class BaseCommand : ICommand
    {
       
            public event EventHandler CanExecuteChanged;

            private Action _action;

            public BaseCommand(Action action)
            {
                this._action = action;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                this._action();
            }
        
    }
}
