using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwaggerApiDemo.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class MyModelBinder : DefaultModelBinder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="bindingContext"></param>
        /// <param name="modelType"></param>
        /// <returns></returns>
        protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
        {
            string FirstName = controllerContext.RequestContext.HttpContext.Request.Form["FName"];
            string LastName = controllerContext.RequestContext.HttpContext.Request.Form["LName"];
            int Salary = int.Parse(controllerContext.RequestContext.HttpContext.Request.Form["Salary"]);
            return null;
        }
    }
}