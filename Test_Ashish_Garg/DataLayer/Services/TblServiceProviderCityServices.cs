using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test_Ashish_Garg.DataLayer.Interfaces;
using Test_Ashish_Garg.Models;

namespace Test_Ashish_Garg.DataLayer.Services
{
    public class TblServiceProviderCityServices : ITblServiceProviderCity
    {
        DB_Ashish_GargEntities _entities = null;
        ServicesResponse response = null;
        public TblServiceProviderCityServices()
        {
            _entities = new DB_Ashish_GargEntities();
            response = new ServicesResponse();
        }
        public ServicesResponse GetTotalBabyCareService(string serviceName = "Baby Care",string city = "Chandigarh")
        {
            List<TblServiceProviderVM> list = new List<TblServiceProviderVM>();
            try
            {
                var record = (from serviceProvider in _entities.tblServiceProviders
                              join providerCity in _entities.tblServiceProviderCities 
                              on serviceProvider.Id equals providerCity.ServiceProviderId
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
                    record = record.Where(x => x.City == city /*&& x.ServiceName==serviceName*/).ToList();
                    if (record != null)
                    {
                        record = record.Where(x => x.ServiceName == serviceName).ToList();
                    }
                }
                foreach (var item in record)

                {
                    TblServiceProviderVM tblServiceProviderVM = new TblServiceProviderVM();
                    tblServiceProviderVM.Id = item.Id;
                    tblServiceProviderVM.ProviderName = item.ProviderName;
                    tblServiceProviderVM.ServiceProviderId = item.ServiceProviderId;
                    tblServiceProviderVM.ServiceName = item.ServiceName;
                    tblServiceProviderVM.City = item.City;
                    list.Add(tblServiceProviderVM);
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