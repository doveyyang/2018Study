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
    
    public partial class v2_protection_log
    {
        public long log_id { get; set; }
        public Nullable<int> work_id { get; set; }
        public Nullable<int> plan_id { get; set; }
        public Nullable<int> staff_id { get; set; }
        public System.DateTime work_time { get; set; }
        public string work_proj { get; set; }
        public Nullable<System.DateTime> agree_time { get; set; }
        public string command_code { get; set; }
        public string job_location { get; set; }
        public Nullable<int> staff_num { get; set; }
        public Nullable<bool> train_flag { get; set; }
        public Nullable<System.DateTime> stop_time { get; set; }
        public Nullable<System.DateTime> stop_time2 { get; set; }
        public Nullable<System.DateTime> back_time { get; set; }
        public Nullable<bool> gate_flag { get; set; }
        public Nullable<System.DateTime> gate_time { get; set; }
        public string out_gate_loc { get; set; }
        public Nullable<System.DateTime> out_gate_time { get; set; }
        public Nullable<bool> photo_flag { get; set; }
        public string remark { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<bool> delete_flag { get; set; }
        public Nullable<System.DateTime> delete_time { get; set; }
        public string gate_loc { get; set; }
        public string out_gate_loc2 { get; set; }
        public Nullable<System.DateTime> out_gate_time2 { get; set; }
    }
}
