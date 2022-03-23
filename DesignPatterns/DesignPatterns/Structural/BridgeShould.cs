using Bridge.Abstractions;
using Bridge.Interfaces;
using Bridge.Models.Coupons;
using Bridge.Models.Menus;
using NUnit.Framework;

namespace DesignPatterns.Structural
{
    public class BridgeShould
    {
        private ICoupon? coupon;

        [TearDown()]
        public void TearDown() => coupon = null;

        [Test()]
        public void CalculateVegetarian()
        {
            coupon = new NoCoupon { };
            Menu m = new VegetarianMenu(coupon);

            Assert.AreEqual(m.CalculatePrice(), 2000);
        }

        [Test()]
        public void CalculateMeat()
        {
            coupon = new TwoEuroCoupon { };
            Menu m = new MeatMenu(coupon);

            Assert.AreEqual(m.CalculatePrice(), 18);
        }
    }
}
