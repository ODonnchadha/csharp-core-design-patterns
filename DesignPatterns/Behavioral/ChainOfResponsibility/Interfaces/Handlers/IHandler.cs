namespace ChainOfResponsibility.Interfaces.Handlers
{
    /// <summary>
    /// Handler.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHandler<T> where T : class
    {
        IHandler<T> SetSuccessor(IHandler<T> successor);
        void Handle(T request);
    }
}
