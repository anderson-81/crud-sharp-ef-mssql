//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace crud
{
    using System;
    using System.Collections.Generic;
    
    public partial class USERSYS_LOGIN
    {
        public int ID { get; set; }
        public int USERSYS_ID { get; set; }
        public System.DateTime DATELOG { get; set; }
    
        public virtual USERSYS USERSYS { get; set; }
    }
}
