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
    
    public partial class warn_message
    {
        public int id { get; set; }
        public Nullable<int> warn_level_id { get; set; }
        public Nullable<int> company_id { get; set; }
        public Nullable<int> work_id { get; set; }
        public Nullable<int> requisit_main_id { get; set; }
        public Nullable<int> model_id { get; set; }
        public int type_id { get; set; }
        public Nullable<int> mobile_id { get; set; }
        public Nullable<System.DateTime> receive_time { get; set; }
        public Nullable<int> deal_staff_id { get; set; }
        public string message { get; set; }
        public Nullable<System.DateTime> deal_time { get; set; }
        public string handle_opinions { get; set; }
        public int create_staff_id { get; set; }
        public bool message_state { get; set; }
        public Nullable<float> longitude { get; set; }
        public Nullable<float> latitude { get; set; }
        public string epc { get; set; }
        public string name { get; set; }
    }
}