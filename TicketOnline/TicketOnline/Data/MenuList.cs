//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketOnline.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MenuList
    {
        public int Id { get; set; }
        public string nameOption { get; set; }
        public string controller { get; set; }
        public string action { get; set; }
        public string area { get; set; }
        public string imageClass { get; set; }
        public string activeli { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> parentId { get; set; }
        public Nullable<bool> isParent { get; set; }
    }
}
