namespace Command.Interfaces.Commands
{
    /// <summary>
    /// Command.
    /// </summary>
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
        void Undo();
    }
}
