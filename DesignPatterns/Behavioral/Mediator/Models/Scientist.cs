using Mediator.Abstractions;

namespace Mediator.Models
{
    public class Scientist : TeamMember
    {
        public Scientist(string name) : base(name) { }
        public override string Receive(string from, string message) => base.Receive($"{nameof(Scientist)}", message);

    }
}
