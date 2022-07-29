using Business.Abstract;
using Core.Entities.Abstract;
using Core.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseController<TService,TEntity> : ControllerBase where TService : IBaseService<TEntity> where TEntity : class,IEntity,new()
    {
        public TService _service;
        public IActionResult Response(IResult result)
        {
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet]
        public virtual IActionResult GetAll()
        {
            return Response(_service.GetAll());
        }
        [HttpGet]
        public virtual IActionResult GetById(int entityId)
        {
            return Response(_service.GetById(entityId));
        }
        //[HttpPost]
        //public virtual IActionResult Add(TEntity entity)
        //{
        //    return Response(_service.Add(entity));
        //}
        [HttpDelete]
        public virtual IActionResult Delete(TEntity entity)
        {
            return Response(_service.Delete(entity));
        }
        [HttpPut]
        public virtual IActionResult Update(TEntity entity)
        {
            return Response(_service.Update(entity));

        }
    }
}
