using Creational.FactoryMethod.Abstractions.Factories;
using Creational.FactoryMethod.Factories;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational
{
    public class FactoryMethodShould
    {
        List<DiscountFactory> factories = new List<DiscountFactory> { };

        [SetUp()]
        public void SetUp()
        {
            factories.Add(new CodeDiscountFactory(Guid.NewGuid()));
            factories.Add(new CountryDiscountFactory("BE"));
        }

        [Test()]
        public void Create()
        {
            factories.ForEach(f =>
            {
                var i = f.Create().DiscountPercentage;
                Assert.AreEqual(i, 15);
            });
        }
    }
}
