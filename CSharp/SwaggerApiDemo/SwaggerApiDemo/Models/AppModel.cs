using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerApiDemo.Models
{
    /// <summary>
    /// App 信息
    /// </summary>
    public class AppModel
    {
        /// <summary>
        /// App ID号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// App 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// App 说明
        /// </summary>
        public string Remark { get; set; }
    }
}