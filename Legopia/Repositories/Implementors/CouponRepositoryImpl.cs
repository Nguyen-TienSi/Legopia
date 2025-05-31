using Legopia.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Repositories.Implementors
{
    public class CouponRepositoryImpl : GenericRepositoryImpl<Coupon>, ICouponRepository
    {
        public CouponRepositoryImpl(DbContext context) : base(context)
        {
        }
    }
}
