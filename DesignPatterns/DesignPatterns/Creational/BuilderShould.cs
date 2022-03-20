using Builder.Abstractions.Builders;
using Builder.Builders;
using Builder.Directors;
using NUnit.Framework;

namespace DesignPatterns.Creational
{
    public class BuilderShould
    {
        CarBuilder? builder;
        Garage? garage;

        [SetUp()]
        public void SetUp() => garage = new Garage { };

        [TearDown()]
        public void TearDown() => builder = null;

        [Test()]
        public void BuildCamry()
        {
            builder = new CamryBuilder { };
            garage?.Construct(builder);
            Assert.AreEqual(builder.Car.ToString(), "CamryBuilderEngine CamryBuilderFrame");
        }

        [Test()]
        public void BuildCorolla()
        {
            builder = new CorollaBuilder { };
            garage?.Construct(builder);
            Assert.AreEqual(builder.Car.ToString(), "CorollaBuilderEngine CorollaBuilderFrame");
        }
    }
}
