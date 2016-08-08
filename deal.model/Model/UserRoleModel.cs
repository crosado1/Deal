using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace deal.model.Model
{
    [DataContract]
    public class UserRoleModel
    {
        [DataMember]
        public int UserRoleId { get; set; }

        [DataMember]
        public UserModel UserModel { get; set; }

        [DataMember]
        public RoleModel RoleModel { get; set; }

        [DataMember]
        public DateTime FromDate { get; set; }

        [DataMember]
        public DateTime? ToDate { get; set; }
    }
}
