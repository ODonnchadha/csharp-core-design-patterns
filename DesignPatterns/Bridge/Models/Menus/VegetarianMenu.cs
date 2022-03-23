using Bridge.Abstractions;
using Bridge.Interfaces;

namespace Bridge.Models.Menus
{
    public class VegetarianMenu : Menu
    {
        public VegetarianMenu(ICoupon c) : base(c) { }
        public override int CalculatePrice() => 2000 - _coupon.CouponValue;
    }
}
