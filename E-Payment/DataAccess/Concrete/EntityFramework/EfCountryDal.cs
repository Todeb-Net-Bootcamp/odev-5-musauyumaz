using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Models.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCountryDal : EfEntityRepositoryBase<Country, PaymentDbContext>, ICountryDal
    {
    }
}
