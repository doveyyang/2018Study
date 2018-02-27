using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using SwaggerApiDemo.Models;
using SwaggerApiDemo.Tools;

namespace SwaggerApiDemo.Controllers
{
    /// <summary>
    /// Demo 控制器
    /// </summary>
    public class TestController : ApiController
    {
        private List<AppModel> list = new List<AppModel>() {
            new AppModel(){
                Id = 1,
                Name = "工器具·智能管理系统",
                Remark = "对工器具的出入库、出入场管理，人员出入场管理，防护记录，设备维护等操作"
            },
            new AppModel(){
                Id = 2,
                Name = "检修所·资产管理系统",
                Remark = "对设备出入库管理，设备装配等操作"
            },
            new AppModel(){
                Id = 3,
                Name = "铁路·巡检系统",
                Remark = "对铁路设备的定期维护管理，天窗计划和应急计划管理"
            },
        };
        /// <summary>
        /// 获取所有的模型数据
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        public HttpResponseMessage GetAll()
        {
            return Trans.ToJson(this.list);
        }

        /// <summary>
        /// 获取指定APP
        /// </summary>
        /// <param name="id">需要获取APP的id</param>
        /// <returns>返回指定APP</returns>
        [System.Web.Http.HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var app = list.Where(m => m.Id.Equals(id)).FirstOrDefault();
            return Trans.ToJson(app);
        }

        /// <summary>
        /// 增加App信息
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [System.Web.Http.HttpPost]
        public HttpResponseMessage Insert([FromBody]AppModel value)
        {
            var json = new JsonResult() {                
                Data = 200, ContentType= "text/json"};
            return Trans.ToJson(json);
        }

        /// <summary>
        /// 更新APP信息
        /// </summary>
        /// <param name="value">APP信息</param>
        /// <returns>更新结果</returns>
        [System.Web.Http.HttpPut]
        public HttpResponseMessage UpdateApp([FromBody]AppModel value)
        {
            var json = new JsonResult()
            {
                Data = 200,
                ContentType = "text/json"
            };
            return Trans.ToJson(json);
        }

        /// <summary>
        /// 删除APP信息
        /// </summary>
        /// <param name="id">APP编号</param>
        /// <returns>删除结果</returns>
        [System.Web.Http.HttpDelete]
        public HttpResponseMessage DeleteApp(int id)
        {
            var json = new JsonResult()
            {
                Data = 200,
                ContentType = "text/json"
            };
            return Trans.ToJson(json);
        }
    }
}
