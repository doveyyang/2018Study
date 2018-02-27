using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace SwaggerApiDemo.Tools
{
    /// <summary>
    /// Trans 转换工具类
    /// </summary>
    public static class Trans
    {
        /// <summary>
        /// Object 转 Json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static HttpResponseMessage ToJson(object obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string str = serializer.Serialize(obj);
            var result = new HttpResponseMessage()
            {
                Content = new StringContent(str, Encoding.UTF8,"text/json")
            };
            return result;
        }
    }
}