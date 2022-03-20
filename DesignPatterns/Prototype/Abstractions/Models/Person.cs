namespace Prototype.Abstractions.Models
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract Person Clone();
    }
}
