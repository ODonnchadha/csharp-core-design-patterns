using Bridge.Interfaces;

namespace Bridge.Models.Coupons
{
    public class NoCoupon : ICoupon
    {
        public int CouponValue { get => 0; }
    }
}
