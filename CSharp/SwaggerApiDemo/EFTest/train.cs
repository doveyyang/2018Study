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
    
    public partial class train
    {
        public int train_id { get; set; }
        public string train_code { get; set; }
        public Nullable<int> train_style_id { get; set; }
        public Nullable<int> create_id { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<int> delete_id { get; set; }
        public Nullable<System.DateTime> delete_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public int train_status { get; set; }
    }
}
