﻿using System.Windows.Input;

namespace Hobby_Viewlist.Command
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object?> execute;
        private readonly Func<object?, bool>? canExecute;

        public event EventHandler? CanExecuteChanged;

        public void RaiseCanExecuteCahnged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public DelegateCommand(Action<object?> execute, Func<object?, bool>? canExecute = null )
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => canExecute == null ? true : canExecute(parameter);
        public void Execute(object? parameter) => execute(parameter);
    }
}
