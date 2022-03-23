using Bridge.Interfaces;

namespace Bridge.Abstractions
{
    public abstract class Menu
    {
        public readonly ICoupon _coupon = null!;
        public Menu(ICoupon coupon) => _coupon = coupon;
        public abstract int CalculatePrice();
    }
}
