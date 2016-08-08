using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deal.model.Response
{
    public class ServiceResponseModel<T> : ServiceResponse where T : class
    {
        public ServiceResponseModel()
        {

        }

        public T Model { get; set; }
    }
}
