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
    
    public partial class train_video
    {
        public int video_id { get; set; }
        public int staff_id { get; set; }
        public int equipment_id { get; set; }
        public int company_id { get; set; }
        public int train_id { get; set; }
        public string video_path { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<int> create_id { get; set; }
        public Nullable<int> delete_id { get; set; }
        public Nullable<System.DateTime> delete_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public string picture_path { get; set; }
        public int train_video_status { get; set; }
    }
}
