//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BenjaminShirk_Prog_POE_Part2
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLEmployee
    {
        public int EmployeeID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int LoginID { get; set; }
    
        public virtual TBLLogin TBLLogin { get; set; }
    }
}