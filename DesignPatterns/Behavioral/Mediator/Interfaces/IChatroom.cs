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
        void Send(string from, string to, string message);
        void SendTo<T>(string from, string message) where T : TeamMember;
    }
}
