using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace deal.model.Model
{
    [DataContract]
    public class StateModel
    {
        [DataMember]
        public int StateId { get; set; }

        [DataMember]
        public string StateDescription { get; set; }

        [DataMember]
        public string StateLetters { get; set; }
    }
}
