using Core.DataAccess.Abstract;
using Models.Entities;

namespace DataAccess.Abstract
{
    public interface ICountryDal : IEntityRepository<Country>
    {
    }
}
