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
    
    public partial class CompanyUser
    {
        public int companyUserId { get; set; }
        public int companyId { get; set; }
        public int userRoleId { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
