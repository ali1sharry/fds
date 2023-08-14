using FDS.MVVM.Model;
using System;

using System.Threading.Tasks;
using System.Windows.Input;
namespace FDS.Core
{
    class RelayCommand : ICommand
    {
        
        private Action<object> _execute;
        private Func<object, bool> _canExecute;
        
        private Func<object, bool> p;
        private ICommand addDisCommmand;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {

            _execute = execute;
            _canExecute = canExecute;

        }

        public RelayCommand(ICommand addDisCommmand, Func<object, bool> p)
        {
            this.addDisCommmand = addDisCommmand;
            this.p = p;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    

    }
}

