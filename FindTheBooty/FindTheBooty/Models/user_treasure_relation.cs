//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FindTheBooty.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_treasure_relation
    {
        public string user_user_id { get; set; }
        public int treasure_treasure_id { get; set; }
        public int treasure_hunt_hunt_id { get; set; }
        public string found { get; set; }
    
        public virtual treasure treasure { get; set; }
        public virtual user user { get; set; }
    }
}
