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
    
    public partial class line
    {
        public int line_id { get; set; }
        public Nullable<int> parent { get; set; }
        public string name { get; set; }
        public string remark { get; set; }
        public string jm { get; set; }
        public string path { get; set; }
        public string begin_kilo_mark { get; set; }
        public Nullable<int> begin_meter { get; set; }
        public Nullable<int> end_meter { get; set; }
        public string end_kilo_mark { get; set; }
        public Nullable<float> begin_longitude { get; set; }
        public Nullable<float> end_longitude { get; set; }
        public Nullable<float> begin_latitude { get; set; }
        public Nullable<float> end_latitude { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<int> create_staff_id { get; set; }
        public Nullable<System.DateTime> delete_time { get; set; }
        public Nullable<int> delete_staff_id { get; set; }
        public int delete_status { get; set; }
    }
}
