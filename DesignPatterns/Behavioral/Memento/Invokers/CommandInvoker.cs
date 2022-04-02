using Memento.Interfaces.Commands;

namespace Memento.Invokers
{
    public class CommandInvoker
    {
        // First in, last out structure.
        private readonly Stack<ICommand> _commands = new Stack<ICommand>();
        public void Invoke(ICommand cmd)
        {
            if (cmd.CanExecute())
            {
                cmd.Execute();
                _commands.Push(cmd);
            }
        }

        public void Undo()
        {
            if (_commands.Any())
            {
                _commands.Pop()?.Undo();
            }
        }

        public void UndoAll()
        {
            while (_commands.Any())
            {
                _commands.Pop()?.Undo();
            }
        }
    }
}
