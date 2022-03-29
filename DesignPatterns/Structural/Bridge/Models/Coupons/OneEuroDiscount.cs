using Bridge.Interfaces;

namespace Bridge.Models.Coupons
{
    public class OneEuroDiscount : ICoupon
    {
        public int CouponValue { get => 1; }
    }
}
