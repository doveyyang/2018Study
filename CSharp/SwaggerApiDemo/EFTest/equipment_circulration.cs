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
    
    public partial class equipment_circulration
    {
        public int circulration_id { get; set; }
        public Nullable<int> equipment_id { get; set; }
        public Nullable<int> operation_id { get; set; }
        public Nullable<int> src_company_id { get; set; }
        public Nullable<int> desc_company_id { get; set; }
        public Nullable<System.DateTime> circulration_date { get; set; }
        public Nullable<int> create_staff_id { get; set; }
        public Nullable<int> create_time { get; set; }
        public string circulration_mem { get; set; }
        public string circulration_path { get; set; }
    }
}
