using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFTest;
using SwaggerApiDemo.Models;
using SwaggerApiDemo.ViewModels;

namespace SwaggerApiDemo.Controllers
{
    /// <summary>
    /// Home Controller
    /// </summary>
    public class StaffController : Controller
    {

        /// <summary>
        /// Test API
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            EFEntities entities = new EFEntities();
            var staffList = entities.maintenance_staff.ToList();

            StaffListView vModel = new StaffListView()
            {
                sList = new List<StaffViewModel>()
            };

            if (staffList != null && staffList.Count > 0)
            {
                foreach (var staff in staffList)
                {
                    vModel.sList.Add(new StaffViewModel()
                    {
                        LoginName = staff.name,
                        RFID = staff.rfid_code,
                        CardNumber = staff.card_number
                    });
                }
            }

            return View(vModel);
        }
        /// <summary>
        /// Test Model API
        /// </summary>
        /// <returns></returns>
        public ActionResult TestModel()
        {
            EFEntities entities = new EFEntities();
            var staff = entities.maintenance_staff.Find(1);
            StaffViewModel vModel = new StaffViewModel()
            {
                LoginName = staff.name,
                RFID = staff.rfid_code,
                CardNumber = staff.card_number
            };
            return View(vModel);
        }
        /// <summary>
        /// Add API
        /// </summary>
        /// <returns></returns>
        public ActionResult Add(/*StaffViewModel model*/)
        {

            return View();
        }

        /// <summary>
        /// Save Staff
        /// </summary>
        /// <param name="model"></param>
        /// <param name="RFID"></param>
        /// <returns></returns>
        public ActionResult SaveStaff(StaffViewModel model, string RFID, string Submit)
        {
            switch (Submit)
            {
                case "取消":
                    return RedirectToAction("Index");
            }
            return new JsonResult()
            {
                Data = model.LoginName + " " + model.CardNumber + " " + model.RFID + "" + RFID,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>        
        public ActionResult CancelSave()
        {
            return new JsonResult()
            {
                Data = "test",
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="RFID"></param>
        /// <param name="Submit"></param>
        /// <returns></returns>
        public ActionResult SaveStaffTwo([ModelBinder(typeof(MyModelBinder))] StaffViewModel model, string RFID, string Submit)
        {
            string FName = Request.Form["FName"];
            string LName = Request.Form["LName"];
            string Salary = Request.Form["Salary"];

            switch (Submit)
            {
                case "取消":
                    return RedirectToAction("Index");
            }
            return new JsonResult()
            {
               // Data = model.LoginName + " " + model.CardNumber + " " + model.RFID + "" + RFID
            };
        }

        //添加验证
        public ActionResult ValidateTest(EmployViewModel model)
        {

            return View();
        }


        public ActionResult AddNew(/*StaffViewModel model*/)
        {
            EmployeeListViewModel vmodel = new EmployeeListViewModel()
            {
                sList = new List<EmployViewModel>() {
                    new EmployViewModel(){
                    FName = "zhang",
                    LName = "san",
                    Salary = 100
                    },
                     new EmployViewModel(){
                    FName = "li",
                    LName = "si",
                    Salary = 200
                    },
                      new EmployViewModel(){
                    FName = "wang",
                    LName = "wu",
                    Salary = 300
                    }
                }
            };
            return View(vmodel);
        }

        public ActionResult SaveEmployee(EmployViewModel e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        return RedirectToAction("Index");
                    }else
                    {
                        CreateEmployeeViewModel vm = new CreateEmployeeViewModel() {
                            FirstName = e.FName,
                            LastName = e.LName,
                            Salary = e.Salary.ToString()
                        };

                        return View("CreateEmployee", vm);
                    }

                case "取消":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }

    }

}
