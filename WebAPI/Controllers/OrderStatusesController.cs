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
    public class OrderStatusesController : ControllerBase
    {
        IOrderStatusService _orderStatusService;

        public OrderStatusesController(IOrderStatusService orderStatusService)
        {
            _orderStatusService = orderStatusService;
        }



        [HttpPost("add")]
        public IActionResult Add(OrderStatus orderStatus)
        {
            var result = _orderStatusService.Add(orderStatus);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _orderStatusService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

    }
}
