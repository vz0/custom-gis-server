//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.Lands = new HashSet<Land>();
            this.Stations = new HashSet<Station>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Speciality { get; set; }
        public string Phone { get; set; }
    
        public virtual ICollection<Land> Lands { get; set; }
        public virtual Spec Spec { get; set; }
        public virtual ICollection<Station> Stations { get; set; }
    }
}
