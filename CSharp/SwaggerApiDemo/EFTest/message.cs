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
    
    public partial class message
    {
        public int id { get; set; }
        public sbyte message_type_id { get; set; }
        public string message_title { get; set; }
        public string message_detail { get; set; }
        public string ref_table { get; set; }
        public Nullable<int> ref_id { get; set; }
        public Nullable<int> send_staff_id { get; set; }
        public Nullable<System.DateTime> send_date { get; set; }
        public int receive_staff_id { get; set; }
        public System.DateTime receive_time { get; set; }
        public string forward_path { get; set; }
        public int delete_status { get; set; }
        public Nullable<System.DateTime> delete_time { get; set; }
        public Nullable<int> delete_staff_id { get; set; }
    }
}