using deal.model.Model;
using deal.repository.abstracts;
using deal.repository.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using deal.model.Response;
using System.ServiceModel;

namespace deal.service
{
    public class LookUpService : ILookUpRepository
    {
        [WebInvoke(Method = "GET",
                  ResponseFormat = WebMessageFormat.Json)]
        public ServiceResponseWithResultset<ServiceTypeModel> GetAll_ServiceType()
        {
            return new LookUpRepository().GetAll_ServiceType();
        }

        
    }
}
