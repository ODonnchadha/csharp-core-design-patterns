using AbstractFactory.Factories;
using AbstractFactory.Models;
using NUnit.Framework;

namespace DesignPatterns.Creational
{
    public class AbstractFactoryShould
    {
        ShoppingCart? cart;

        [TearDown()]
        public void TearDown() => cart = null;

        [Test()]
        public void CalculateBelgiumCosts()
        {
            cart = new ShoppingCart(new BelgiumShoppingCartPurchaseFactory());
            Assert.AreEqual(cart.CalculateCost(), 40M);
        }

        [Test()]
        public void CalculateFranceCosts()
        {
            cart = new ShoppingCart(new FranceShoppingCartPurchaseFactory());
            Assert.AreEqual(cart.CalculateCost(), -6M);
        }
    }
}
