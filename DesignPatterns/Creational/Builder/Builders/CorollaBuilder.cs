using Builder.Abstractions.Builders;

namespace Builder.Builders
{
    public class CorollaBuilder : CarBuilder
    {
        public CorollaBuilder() : base("Corolla") { }
        public override void BuildEngine() => Car.AddPart($"{GetType().Name}Engine");
        public override void BuildFrame() => Car.AddPart($"{GetType().Name}Frame");
    }
}
