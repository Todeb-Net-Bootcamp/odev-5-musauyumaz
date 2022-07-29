using Core.Utilities.Results.Abstract;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAddressService : IBaseService<Address>
    {
        IResult Add(Address entity);
    }
}
