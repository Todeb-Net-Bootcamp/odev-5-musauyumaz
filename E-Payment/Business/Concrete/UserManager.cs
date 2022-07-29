using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DTOs.User;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;

        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }


        public IResult Add(User entity)
        {
            //var boundEntity = _mapper.Map<User>(entity);
            _userDal.Add(entity);
            return new SuccessResult(UserMessages.UserAdded);
        }

        public IResult Delete(User entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult(UserMessages.UserDeleted);
        }

        public IDataResult<IList<User>> GetAll()
        {
            var users = _userDal.GetAll();
            return new SuccessDataResult<IList<User>>(UserMessages.UserListed,users);
        }

        public IDataResult<User> GetById(int id)
        {
            var user = _userDal.Get(x=>x.Id == id);
            return new SuccessDataResult<User>(UserMessages.UserBrought,user);
        }

        public IResult Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult(UserMessages.UserUpdated);
        }
    }
}
