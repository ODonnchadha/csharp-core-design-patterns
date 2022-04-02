using Memento.Commands;
using Memento.Interfaces.Commands;
using Memento.Mementos;

namespace Memento.Invokers
{
    /// <summary>
    /// Caretaker.
    /// </summary>
    public class CommandInvoker
    {
        private readonly Stack<EmployeeManagerMemento> _mementos = new();
        private EmployeeCommand? _command;
        public void Invoke(ICommand cmd)
        {
            // For reuse (Instead of stroing different instances.)
            if (_command == null)
            {
                _command = (EmployeeCommand)cmd;
            }

            if (cmd.CanExecute())
            {
                cmd.Execute();
                _mementos.Push(((EmployeeCommand)cmd).CreateMemento());
            }
        }

        public void Undo()
        {
            if (_mementos.Any())
            {
                _command?.RestoreMemento(_mementos.Pop());
                _command?.Undo();
            }
        }

        public void UndoAll()
        {
            while (_mementos.Any())
            {
                _command?.RestoreMemento(_mementos.Pop());
                _command?.Undo();
            }
        }
    }
}
