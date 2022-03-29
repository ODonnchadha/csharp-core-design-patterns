using Command.Interfaces.Commands;

namespace Command.Invokers
{
    public class CommandInvoker
    {
        public void Invoke(ICommand cmd)
        {
            if (cmd.CanExecute())
            {
                cmd.Execute();
            }
        }
    }
}
