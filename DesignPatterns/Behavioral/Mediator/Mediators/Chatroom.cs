using Mediator.Abstractions;
using Mediator.Interfaces;

namespace Mediator.Mediators
{
    public class Chatroom : IChatroom
    {
        private readonly Dictionary<string, TeamMember> _members = new();
        public void Register(TeamMember t)
        {
            t.SetChatroom(this);

            if (!_members.ContainsKey(t.Name))
            {
                _members.Add(t.Name, t);
            }
        }

        public void Send(string from, string message)
        {
            foreach (var member in _members.Values)
            {
                member.Receive(from, message);
            }
        }

        public void Send(string from, string to, string message) => 
            _members[to]?.Receive(from, message);

        public void SendTo<T>(string from, string message) where T : TeamMember
        {
            foreach (var member in _members.Values.OfType<T>())
            {
                member.Receive(from, message);
            }
        }
    }
}
