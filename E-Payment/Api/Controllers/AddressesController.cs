using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressesController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var addresses = _addressService.GetAll();
            return Ok(addresses);
        }
        //[HttpPost]
        //public IActionResult AddAddress(Address address)
        //{
        //    var addedResponse = _addressService.Add(address);
        //    return Ok(addedResponse);
        //}
    }
}
