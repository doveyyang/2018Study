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
    
    public partial class warn_level_relation
    {
        public int relation_id { get; set; }
        public int warn_level_id { get; set; }
        public int company_id { get; set; }
        public int model_id { get; set; }
        public int type_id { get; set; }
        public Nullable<int> create_staff_id { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public Nullable<int> update_staff_id { get; set; }
        public Nullable<int> delete_staff_id { get; set; }
        public Nullable<System.DateTime> delete_date { get; set; }
        public bool delete_state { get; set; }
    }
}