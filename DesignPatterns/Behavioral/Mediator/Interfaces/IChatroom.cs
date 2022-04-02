using Mediator.Abstractions;

namespace Mediator.Interfaces
{
    /// <summary>
    /// Mediator.
    /// </summary>
    public interface IChatroom
    {
        void Register(TeamMember t);
        void Send(string from, string message);
    }
}
