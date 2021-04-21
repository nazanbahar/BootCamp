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
    public class BasketsController : ControllerBase
    {

        IBasketService _basketService;

        public BasketsController(IBasketService basketService)
        {
            _basketService = basketService;
        }



        [HttpPost("add")]
        public IActionResult Add(Basket basket)
        {
            var result = _basketService.Add(basket);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }



        [HttpPost("update")]
        public IActionResult Update(Basket basket)
        {
            var result = _basketService.Update(basket);
            //gelen işlem sonuçları
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Basket basket)
        {
            var result = _basketService.Delete(basket);
            //gelen işlem sonuçları
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _basketService.GetAll();
            if (result.Success)
            {
                return Ok(result);
        
            }
            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _basketService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
