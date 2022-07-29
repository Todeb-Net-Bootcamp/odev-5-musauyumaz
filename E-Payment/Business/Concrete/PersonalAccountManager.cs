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
    public class PersonalAccountManager : IPersonalAccountService
    {
        private readonly IPersonalAccountDal _personalAccountDal;

        public PersonalAccountManager(IPersonalAccountDal personalAccountDal)
        {
            _personalAccountDal = personalAccountDal;
        }

        public IResult Add(PersonalAccount entity)
        {
            _personalAccountDal.Add(entity);
            return new SuccessResult(PersonalAccountMessages.PersonalAccountAdded);
        }

        public IResult Delete(PersonalAccount entity)
        {
            _personalAccountDal.Delete(entity);
            return new SuccessResult(PersonalAccountMessages.PersonalAccountDeleted);
        }

        public IDataResult<IList<PersonalAccount>> GetAll()
        {
            var personalAccounts = _personalAccountDal.GetAll();
            return new SuccessDataResult<IList<PersonalAccount>>(PersonalAccountMessages.PersonalAccountListed,personalAccounts);
        }

        public IDataResult<PersonalAccount> GetById(int id)
        {
            var personalAccount = _personalAccountDal.Get(x=>x.Id == id);
            return new SuccessDataResult<PersonalAccount>(PersonalAccountMessages.PersonalAccountBrought, personalAccount);
        }

        public IResult Update(PersonalAccount entity)
        {
            _personalAccountDal.Update(entity);
            return new SuccessResult(PersonalAccountMessages.PersonalAccountUpdated);
        }
    }
}
