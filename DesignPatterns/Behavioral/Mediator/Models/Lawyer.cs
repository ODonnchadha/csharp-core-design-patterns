using Mediator.Abstractions;

namespace Mediator.Models
{
    public class Lawyer : TeamMember
    {
        public Lawyer(string name) : base(name) { }
        public override string Receive(string from, string message) => base.Receive($"{nameof(Lawyer)}", message);

    }
}
