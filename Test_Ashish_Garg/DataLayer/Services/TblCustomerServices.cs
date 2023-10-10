using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test_Ashish_Garg.DataLayer.Interfaces;
using Test_Ashish_Garg.Models;

namespace Test_Ashish_Garg.DataLayer.Services
{
    public class TblCustomerServices :ITblCustomer
    {
        DB_Ashish_GargEntities _entities = null;
        ServicesResponse response = null;
        public TblCustomerServices()
        {
            _entities = new DB_Ashish_GargEntities();
            response = new ServicesResponse();
        }
        public ServicesResponse GetAllCustomer(string serviceName = "Baby Care")
        {
            List<TblCustomerVM> list = new List<TblCustomerVM>();
            try
            {
                var record = (from customer in _entities.tblCustomers
                              join serviceProvider in _entities.tblServiceProviders on customer.ServiceTaken equals serviceProvider.Id
                              select new
                              {
                                  customer.Id,
                                  customer.CustomerName,
                                  customer.Gender,
                                  customer.Email,
                                  customer.ContactNo,
                                  serviceProvider.ServiceName,
                              }).ToList();
                if (record != null)
                {
                    record = record.Where(x => x.ServiceName == serviceName).ToList();
                }
                foreach (var item in record)

                {
                    TblCustomerVM tblCustomerVM = new TblCustomerVM();
                    tblCustomerVM.Id = item.Id;
                    tblCustomerVM.CustomerName = item.CustomerName;
                    tblCustomerVM.Gender = item.Gender;
                    tblCustomerVM.Email = item.Email;
                    tblCustomerVM.ContactNo = item.ContactNo;
                    tblCustomerVM.ServiceName = item.ServiceName;
                    list.Add(tblCustomerVM);
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
