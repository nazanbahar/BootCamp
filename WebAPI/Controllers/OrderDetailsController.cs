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
    public class OrderDetailsController : ControllerBase
    {
        IOrderDetailService _orderDetailService;

        public OrderDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }



        [HttpPost("add")]
        public IActionResult Add(OrderDetail orderDetail)
        {
            var result = _orderDetailService.Add(orderDetail);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _orderDetailService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }


    }
}
