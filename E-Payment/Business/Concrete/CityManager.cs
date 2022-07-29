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
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City entity)
        {
            _cityDal.Add(entity);
            return new SuccessResult(CityMessages.CityAdded);
        }

        public IResult Delete(City entity)
        {
            _cityDal.Delete(entity);
            return new SuccessResult(CityMessages.CityDeleted);
        }

        public IDataResult<IList<City>> GetAll()
        {
            var cities = _cityDal.GetAll();
            return new SuccessDataResult<IList<City>>(CityMessages.CityListed,cities);
        }

        public IDataResult<City> GetById(int id)
        {
            var city = _cityDal.Get(x => x.Id == id);
            return new SuccessDataResult<City>(CityMessages.CityBrought,city);
        }

        public IResult Update(City entity)
        {
            _cityDal.Update(entity);
            return new SuccessResult(CityMessages.CityUpdated);
        }
    }
}
