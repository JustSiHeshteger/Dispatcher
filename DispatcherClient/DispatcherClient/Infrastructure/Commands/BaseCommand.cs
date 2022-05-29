using System;
using System.Windows.Input;

namespace DispatcherClient.Infrastructure.Commands
{
    internal abstract class BaseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
