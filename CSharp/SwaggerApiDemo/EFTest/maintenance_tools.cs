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
    
    public partial class maintenance_tools
    {
        public int ID { get; set; }
        public int staff_id { get; set; }
        public Nullable<int> in_number { get; set; }
        public Nullable<System.DateTime> in_date { get; set; }
        public Nullable<int> out_number { get; set; }
        public Nullable<System.DateTime> out_date { get; set; }
        public int mobile_id { get; set; }
        public string picture_path { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<int> create_staff_id { get; set; }
        public Nullable<System.DateTime> delete_time { get; set; }
        public Nullable<int> delete_staff_id { get; set; }
        public int delete_status { get; set; }
        public int requisit_main_id { get; set; }
    }
}