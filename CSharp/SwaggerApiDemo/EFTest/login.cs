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
    
    public partial class login
    {
        public string salt { get; set; }
        public string password { get; set; }
        public System.DateTime reg_time { get; set; }
        public Nullable<System.DateTime> last_login_time { get; set; }
        public Nullable<long> status { get; set; }
        public int staff_id { get; set; }
        public string login_name { get; set; }
        public string login_type { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<int> create_staff_id { get; set; }
        public Nullable<System.DateTime> delete_time { get; set; }
        public Nullable<int> delete_staff_id { get; set; }
        public int delete_status { get; set; }
        public Nullable<System.DateTime> validity_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public string session_id { get; set; }
    }
}
