using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test_Ashish_Garg.DataLayer.Services;
using Test_Ashish_Garg.Models;

namespace Test_Ashish_Garg.Controllers
{
    public class GetDetailController : ApiController
       
    {
        TblServiceProviderServices _services;
        TblCustomerServices _services1;
        TblServiceProviderCityServices _services2;
        public GetDetailController() 
        { 
            _services = new TblServiceProviderServices();
            _services1 = new TblCustomerServices();
            _services2 = new TblServiceProviderCityServices();
        }
            [HttpGet]
        [Route("GetAllServiceProvider")]
        public ServicesResponse GetAllServiceProvider(string serviceName="Cleaning")
        {
            return _services.GetAllServiceProvider(serviceName);
        }
        [HttpGet]
        [Route("GetAllCustomer")]
        public ServicesResponse GetAllCustomer(string serviceName = "Baby Care")
        {
            return _services1.GetAllCustomer(serviceName);
        }
        [HttpGet]
        [Route("GetTotalBabyCareService")]
        public ServicesResponse GetTotalBabyCareService(string serviceName = "Baby Care", string city="Chandigarh")
        {
            return _services2.GetTotalBabyCareService(serviceName,city);
        }
    }
}