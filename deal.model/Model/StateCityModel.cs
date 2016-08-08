using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace deal.model.Model
{
    [DataContract]
    public class StateCityModel
    {
        [DataMember]
        public int StateCityId { get; set; }

        [DataMember]
        public StateModel StateModel { get; set; }

        [DataMember]
        public string CityDescription { get; set; }
    }
}
