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
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }



        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            //gelen işlem sonuçları
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            //gelen işlem sonuçları
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
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
            var result = _productService.GetAll();
            //gelen işlem sonuçları
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("getallbycategory")]
        public IActionResult GetAllByCategory(int categoryId)
        {
            var result = _productService.GetAllByCategory(categoryId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("getallbybrand")]
        public IActionResult GetAllByBrand(int brandId)
        {
            var result = _productService.GetAllByBrand(brandId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


     
    }
}
