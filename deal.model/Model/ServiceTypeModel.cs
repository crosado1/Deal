using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace deal.model.Model
{
    [DataContract]
    public class ServiceTypeModel
    {
        [DataMember]
        public int ServiceTypeId { get; set; }

        [DataMember]
        public string ServiceTypeDescription { get; set; }
    }
}
