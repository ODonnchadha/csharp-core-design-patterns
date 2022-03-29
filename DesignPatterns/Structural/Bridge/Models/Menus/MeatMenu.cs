using Bridge.Abstractions;
using Bridge.Interfaces;

namespace Bridge.Models.Menus
{
    public class MeatMenu : Menu
    {
        public MeatMenu(ICoupon c) : base(c) { }
        public override int CalculatePrice() => 20 - _coupon.CouponValue;
    }
}