using Mediator.Interfaces;

namespace Mediator.Abstractions
{
    /// <summary>
    /// Colleague.
    /// </summary>
    public abstract class TeamMember
    {
        private IChatroom? _room;
        internal void SetChatroom(IChatroom room) => _room = room;
        public string Name { get; private set; }
        public TeamMember(string name) => Name = name;
        public void Send(string message) => _room?.Send(Name, message);
        public void Send(string to, string message) => _room?.Send(Name, to, message);
        public void SendTo<T>(string message) where T : TeamMember
        {
            _room?.SendTo<T>(Name, message);
        }
        public virtual string Receive(string from, string message) => $"{from} to {Name}: {message}";
    }
}
