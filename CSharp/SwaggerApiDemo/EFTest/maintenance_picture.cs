//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class maintenance_picture
    {
        public int picture_id { get; set; }
        public Nullable<int> equipment_id { get; set; }
        public Nullable<int> mobile_id { get; set; }
        public Nullable<int> plan_id { get; set; }
        public Nullable<int> staff_id { get; set; }
        public Nullable<int> company_id { get; set; }
        public string work_image { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> work_id { get; set; }
    }
}