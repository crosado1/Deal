using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static deal.model.Enum.Enumerator;

namespace deal.model.Response
{
    public class ServiceResponse
    {
        public ServiceResponses Response { get; set; }
        public string Reason { get; set; }
    }
}
