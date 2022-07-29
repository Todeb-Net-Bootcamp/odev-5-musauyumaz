using Core.Entities.Abstract;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBaseService<TEntity> where TEntity : class,IEntity, new()
    {
        //IResult Add(TEntity entity);
        IResult Delete(TEntity entity);
        IResult Update(TEntity entity);
        IDataResult<IList<TEntity>> GetAll();
        IDataResult<TEntity> GetById(int id);
    }
}
