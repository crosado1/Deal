using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace deal.model.Model
{
    [DataContract]
    public class ServiceRequestModel
    {
        [DataMember]
        public int ServiceRequestId { get; set; }

        [DataMember]
        public ServiceTypeModel ServiceTypeModel { get; set; }

        [DataMember]
        public UserRoleModel RequestByModel { get; set; }

        [DataMember]
        public string RequestDescription { get; set; }

        [DataMember]
        public DateTime RequestDate { get; set; }

        [DataMember]
        public decimal RequestBudgetFrom { get; set; }

        [DataMember]
        public decimal RequestBudgetTo { get; set; }

        [DataMember]
        public StateCityModel ServiceRequestCityModel { get; set; }
    }
}
