using DeepakTest_Project.Data.Interfaces;
using DeepakTest_Project.Data.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace DeepakTest_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TestController : ControllerBase
    {
        private ItestService  _testService;
        private ApiResponse _response; 

        public TestController( )    
        {
           
           _testService = new TestService();
            _response = new ApiResponse();

        }


        [AllowAnonymous]
        [Route("GetCommission")]
        [HttpGet]
        public ApiResponse GetCommisiion()
        {
            return _testService.CalculateCommission();
        }

       


    }
}
