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
    
    public partial class station
    {
        public int station_id { get; set; }
        public string station_name { get; set; }
        public string kilo_mark { get; set; }
        public string remark { get; set; }
        public string jm { get; set; }
        public int station_type { get; set; }
        public int station_meter { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<int> create_staff_id { get; set; }
        public Nullable<System.DateTime> delete_time { get; set; }
        public Nullable<int> delete_staff_id { get; set; }
        public Nullable<float> station_latitude { get; set; }
        public Nullable<float> station_longtitude { get; set; }
        public int delete_status { get; set; }
        public Nullable<int> manager { get; set; }
        public Nullable<float> longitude { get; set; }
        public Nullable<float> latitude { get; set; }
        public string rfid { get; set; }
        public string address { get; set; }
        public string qrcode { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
    }
}
