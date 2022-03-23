using Bridge.Interfaces;

namespace Bridge.Models.Coupons
{
    public class TwoEuroCoupon : ICoupon
    {
        public int CouponValue { get => 2; }
    }
}
