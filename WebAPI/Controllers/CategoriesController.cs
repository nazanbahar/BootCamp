using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categortyService;

        public CategoriesController(ICategoryService categortService)
        {
            _categortyService = categortService;
        }



        [HttpPost("add")]
        public IActionResult Add(Category basket)
        {
            var result = _categortyService.Add(basket);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categortyService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }


    }
}
