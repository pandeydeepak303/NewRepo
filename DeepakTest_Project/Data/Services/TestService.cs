using DeepakTest_Project.Data.Interfaces;

using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace DeepakTest_Project.Data.Services
{
    public class TestService : ItestService
    {
        
        ApiResponse _response;

        public TestService( )
        {
            //_context =  new Test_DeepakContext();
            _response =  new ApiResponse();
        }

        public ApiResponse CalculateCommission()
        {
            throw new NotImplementedException();
        }

        public ApiResponse HighestCOmmission()
        {


          throw new System.NotImplementedException();
        }

        public ApiResponse SalseAmount()
        {


            throw new System.NotImplementedException();
        }
    }
}
