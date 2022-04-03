using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTestApp.IAL;
using static MyTestApp.DAL.MyCustomEntity;

namespace MyTestApp.Controllers
{
    [Route("MyNewAPI/")]
    [ApiController]
    public class MyNewAPIController : ControllerBase
    {
        private readonly IMyNewAPI _myNewAPI;

        public MyNewAPIController(IMyNewAPI myNewAPI)
        {
            _myNewAPI = myNewAPI;
        }

        [HttpGet]
        [Route("GetAllData")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllData()
        {
            MyCustomResponse response = new MyCustomResponse();
            response = _myNewAPI.GetAllData();
            if (response.status == true)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}