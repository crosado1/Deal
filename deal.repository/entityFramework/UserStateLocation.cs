//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace deal.repository.entityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserStateLocation
    {
        public int userStateLocationId { get; set; }
        public int userRoleId { get; set; }
        public int stateId { get; set; }
        public bool active { get; set; }
    
        public virtual State State { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}