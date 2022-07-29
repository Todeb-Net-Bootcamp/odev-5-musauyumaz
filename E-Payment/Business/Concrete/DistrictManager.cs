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
    public class DistrictManager : IDistrictService
    {
        private readonly IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public IResult Add(District entity)
        {
            _districtDal.Add(entity);
            return new SuccessResult(DistrictMessages.DistrictAdded);
        }

        public IResult Delete(District entity)
        {
            _districtDal.Delete(entity);
            return new SuccessResult(DistrictMessages.DistrictDeleted);
        }

        public IDataResult<IList<District>> GetAll()
        {
            var districts = _districtDal.GetAll();
            return new SuccessDataResult<IList<District>>(DistrictMessages.DistrictListed,districts);
        }

        public IDataResult<District> GetById(int id)
        {
            var district = _districtDal.Get(x => x.Id == id);
            return new SuccessDataResult<District>(DistrictMessages.DistrictBrought, district);
        }

        public IResult Update(District entity)
        {
            _districtDal.Update(entity);
            return new SuccessResult(DistrictMessages.DistrictUpdated);
        }
    }
}
