using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Models.Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonalAccountDal : EfEntityRepositoryBase<PersonalAccount, PaymentDbContext>, IPersonalAccountDal
    {
    }
}
