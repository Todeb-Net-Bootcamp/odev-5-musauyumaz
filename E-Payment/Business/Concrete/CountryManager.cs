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
    public class CountryManager : ICountryService
    {
        private readonly ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public IResult Add(Country entity)
        {
            _countryDal.Add(entity);
            return new SuccessResult(CountryMessages.CountryAdded);
        }

        public IResult Delete(Country entity)
        {
            _countryDal.Delete(entity);
            return new SuccessResult(CountryMessages.CountryDeleted);
        }

        public IDataResult<IList<Country>> GetAll()
        {
            var countries = _countryDal.GetAll();
            return new SuccessDataResult<IList<Country>>(CountryMessages.CountryListed,countries);
        }

        public IDataResult<Country> GetById(int id)
        {
            var country = _countryDal.Get(x=>x.Id == id);
            return new SuccessDataResult<Country>(CountryMessages.CountryBrought, country);
        }

        public IResult Update(Country entity)
        {
            _countryDal.Update(entity);
            return new SuccessResult(CountryMessages.CountryUpdated);
        }
    }
}
