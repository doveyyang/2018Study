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
    
    public partial class company
    {
        public int company_id { get; set; }
        public int parent_id { get; set; }
        public int level { get; set; }
        public string company_path { get; set; }
        public string company_name { get; set; }
        public string company_code { get; set; }
        public string remark { get; set; }
        public int delete_status { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<int> create_staff_id { get; set; }
        public Nullable<System.DateTime> delete_time { get; set; }
        public Nullable<int> delete_staff_id { get; set; }
        public int manager_id { get; set; }
        public string railway_company_code { get; set; }
        public string railway_company_path { get; set; }
    }
}
