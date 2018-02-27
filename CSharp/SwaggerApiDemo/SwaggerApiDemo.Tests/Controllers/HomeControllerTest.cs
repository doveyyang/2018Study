using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwaggerApiDemo;
using SwaggerApiDemo.Controllers;

namespace SwaggerApiDemo.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // 排列
            StaffController controller = new StaffController();

            // 操作
            ViewResult result = controller.Index() as ViewResult;

            // 断言
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
