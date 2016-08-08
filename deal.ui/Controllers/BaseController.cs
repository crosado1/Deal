using deal.model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace deal.ui.Controllers
{
    public class BaseController : Controller
    {


        // GET: Base


        protected List<ServiceTypeModel> GetAll_ServiceType()
        {
            var client = new LookUpSrv.LookUpRepositoryClient();
            var response = client.GetAll_ServiceType();
            List<ServiceTypeModel> returnValues = new List<ServiceTypeModel>();

            if (response.Response == LookUpSrv.ServiceResponses.Failure)
                throw new Exception(response.Reason);

            foreach (var item in response.Data)
            {
                returnValues.Add(new ServiceTypeModel
                {
                    ServiceTypeDescription = item.ServiceTypeDescription,
                    ServiceTypeId = item.ServiceTypeId
                });
            }

            return returnValues;
            
        }
    }
}