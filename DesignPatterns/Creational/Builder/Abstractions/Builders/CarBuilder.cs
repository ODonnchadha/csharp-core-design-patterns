using Builder.Models;

namespace Builder.Abstractions.Builders
{
    public abstract class CarBuilder
    {
        public Car Car { get; private set; }
        public CarBuilder(string type) => Car = new Car(type);
        public abstract void BuildEngine();
        public abstract void BuildFrame();
    }
}
