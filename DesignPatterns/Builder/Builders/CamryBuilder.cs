using Builder.Abstractions.Builders;

namespace Builder.Builders
{
    public class CamryBuilder : CarBuilder
    {
        public CamryBuilder() : base("Camry") { }
        public override void BuildEngine() => Car.AddPart($"{GetType().Name}Engine");
        public override void BuildFrame() => Car.AddPart($"{GetType().Name}Frame");
    }
}
