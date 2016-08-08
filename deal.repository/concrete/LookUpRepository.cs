using deal.repository.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deal.model.Model;
using System.ServiceModel;
using deal.model.Response;
using System.ServiceModel.Web;
using deal.repository.entityFramework;
using static deal.model.Enum.Enumerator;
using AutoMapper;

namespace deal.repository.concrete
{
   
    public class LookUpRepository : ILookUpRepository
    {
        
        private void Dispose()
        {
            throw new NotImplementedException();
        }

        public ServiceResponseWithResultset<ServiceTypeModel> GetAll_ServiceType()
        {
            try
            {
                using (var _context = new DealOptionEntities())
                {
                    Mapper.Initialize(cfg => {
                        cfg.CreateMap<ServiceType, ServiceTypeModel>()
                         .ForMember(z => z.ServiceTypeId, o => o.MapFrom(t => t.serviceTypeId))
                         .ForMember(z => z.ServiceTypeDescription, o => o.MapFrom(t => t.serviceTypeDescription));
                    });

                    var collection = _context.ServiceTypes.ToList();
                    return new ServiceResponseWithResultset<ServiceTypeModel>
                    {
                        Response = ServiceResponses.Success,
                        Reason = "OK",
                        Data = Mapper.Map<List<ServiceType>, List<ServiceTypeModel>>(collection),
                        TotalRecords = collection.Count()
                    };
                }
            }
            catch(Exception ex)
            {
                return new ServiceResponseWithResultset<ServiceTypeModel>
                {
                    Response = ServiceResponses.Failure,
                    Reason = "Error on GetAll_ServiceType method. " +  ex.Message
                };
            }
        }
       
    }
}
