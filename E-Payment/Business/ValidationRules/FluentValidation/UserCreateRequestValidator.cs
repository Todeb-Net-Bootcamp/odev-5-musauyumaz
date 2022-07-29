using FluentValidation;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserCreateRequestValidator:AbstractValidator<User>
    {
        public UserCreateRequestValidator()
        {
            RuleFor(x => x.Email).NotEmpty().NotNull();
            RuleFor(x => x.Password).NotEmpty().NotNull();
            RuleFor(x => x.FirstName).NotEmpty().NotNull();
            RuleFor(x => x.LastName).NotEmpty().NotNull();
            RuleFor(x => x.NationalIdentity).NotEmpty().NotNull();
            RuleFor(x => x.PhoneNumber).NotEmpty().NotNull();

            RuleFor(x => x.Email).EmailAddress();
            


        }
    }
}
