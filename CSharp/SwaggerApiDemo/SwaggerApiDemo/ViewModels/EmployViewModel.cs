using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SwaggerApiDemo.Tools;

namespace SwaggerApiDemo.ViewModels
{
    public class EmployViewModel
    {
        [NameValidation]
        public string FName { get; set; }
        public string LName { get; set; }
        public int Salary { get; set; }
    }
}