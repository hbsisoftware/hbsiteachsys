//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeachSys.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Departments
    {
        public Departments()
        {
            this.Majors = new HashSet<Majors>();
            this.Teachers = new HashSet<Teachers>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    
        public virtual Departments Departments1 { get; set; }
        public virtual Departments Departments2 { get; set; }
        public virtual ICollection<Majors> Majors { get; set; }
        public virtual ICollection<Teachers> Teachers { get; set; }
    }
}
