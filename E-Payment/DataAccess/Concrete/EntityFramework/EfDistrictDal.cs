using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Models.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDistrictDal : EfEntityRepositoryBase<District, PaymentDbContext>, IDistrictDal
    {
    }
}
