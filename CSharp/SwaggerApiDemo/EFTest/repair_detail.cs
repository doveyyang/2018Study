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
    
    public partial class repair_detail
    {
        public int detail_id { get; set; }
        public Nullable<int> apply_id { get; set; }
        public Nullable<int> equipment_id { get; set; }
        public Nullable<int> failure_id { get; set; }
        public Nullable<int> operation_id { get; set; }
        public string failure_cause { get; set; }
        public int detail_status { get; set; }
        public string repair_company { get; set; }
    }
}
