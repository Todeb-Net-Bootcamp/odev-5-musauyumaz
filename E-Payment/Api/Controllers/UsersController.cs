using Business.Abstract;
using DTOs.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : BaseController<IUserService,User>
    {
        public UsersController(IUserService userService)
        {
            _service = userService;
        }
      
    }
}
