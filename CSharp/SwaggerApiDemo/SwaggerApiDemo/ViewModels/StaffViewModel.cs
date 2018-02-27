using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SwaggerApiDemo.Tools;

namespace SwaggerApiDemo.ViewModels
{
    /// <summary>
    /// StaffViewModel
    /// </summary>
    public class StaffViewModel
    {
        public string CardNumber { get; set; }
        public string LoginName { get; set; }

        [RFIDValidation]
        public string RFID { get; set; }
    }
}