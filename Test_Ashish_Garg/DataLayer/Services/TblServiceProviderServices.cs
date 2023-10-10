using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test_Ashish_Garg.DataLayer.Interfaces;
using Test_Ashish_Garg.Models;

namespace Test_Ashish_Garg.DataLayer.Services
{
    public class TblServiceProviderServices : ITblServiceProvider
    {
        DB_Ashish_GargEntities _entities = null;
        ServicesResponse response = null;
        public TblServiceProviderServices()
        {
            _entities = new DB_Ashish_GargEntities();
            response = new ServicesResponse();
        }
        public ServicesResponse GetAllServiceProvider(string serviceName="Cleaning")
        {
            List<TblServiceProviderVM> list = new List<TblServiceProviderVM>();
            try
            {
                var record = (from serviceProvider in _entities.tblServiceProviders
                              join providerCity in _entities.tblServiceProviderCities on serviceProvider.Id equals providerCity.ServiceProviderId
                              select new 
                              {
                                  serviceProvider.Id,
                                  serviceProvider.ProviderName,
                                  serviceProvider.ServiceName,
                                  providerCity.ServiceProviderId,
                                  providerCity.City,
                              }).ToList();
                if (record != null)
                {
                    record = record.Where(x => x.ServiceName == serviceName).ToList();
                }
                foreach (var item in record)
                
                    {   
                    TblServiceProviderVM serviceProviderVM = new TblServiceProviderVM();
                    serviceProviderVM.Id = item.Id;
                    serviceProviderVM.ServiceName= item.ServiceName;
                    serviceProviderVM.ProviderName = item.ProviderName;
                    serviceProviderVM.City = item.City;
                    list.Add(serviceProviderVM);
                    response.statusCode = 200;
                    response.message = "Success";
                    response.data = list;

                    }
             
            }
            catch (Exception ex)
            {
                response.statusCode = 201;
                response.message = ex.Message;
            }
            return response;
        }

        
    }
}