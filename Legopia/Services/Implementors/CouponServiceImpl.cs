using Legopia.Repositories;

namespace Legopia.Services.Implementors
{
    public class CouponServiceImpl : ICouponService
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CouponServiceImpl(ICouponRepository couponRepository, IUnitOfWork unitOfWork)
        {
            _couponRepository = couponRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
