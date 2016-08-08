using deal.model.Model;
using deal.model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace deal.repository.abstracts
{
    [ServiceContract]
    [XmlSerializerFormat]
    public interface ILookUpRepository
    {        
        [OperationContract]
        ServiceResponseWithResultset<ServiceTypeModel> GetAll_ServiceType();

        //ServiceResponseWithResultset<ServiceTypeModel> GetAll_ServiceType();
    }
}
