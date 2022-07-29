using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public IResult Add(Address entity)
        {
            _addressDal.Add(entity);
            return new SuccessResult(AddressMessages.AddressAdded); 
        }

        public IResult Delete(Address entity)
        {
            _addressDal.Delete(entity);
            return new SuccessResult(AddressMessages.AddressDeleted);
        }

        public IDataResult<IList<Address>> GetAll()
        {
            var addresses = _addressDal.GetAll();
            return new SuccessDataResult<IList<Address>>(AddressMessages.AddressesListed,addresses);
        }

        public IDataResult<Address> GetById(int id)
        {
            var address = _addressDal.Get(x => x.Id == id);
            return new SuccessDataResult<Address>(AddressMessages.AddressBrought,address);
        }

        public IResult Update(Address entity)
        {
            _addressDal.Update(entity);
            return new SuccessResult(AddressMessages.AddressUpdated);
        }
    }
}
