using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public System.Web.Mvc.ActionResult Index()
        {
            return View();
        }

        public System.Web.Mvc.ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public System.Web.Mvc.ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public System.Web.Mvc.ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                TempData["message"] = "歡迎登入！";
                // 模擬登入成功（這裡應用認證邏輯）
                return RedirectToAction("Welcome", "Home");
            }

            ViewBag.LoginFailed = true;
            return View("Index");
        }

        public System.Web.Mvc.ActionResult Welcome()
        {
            return View(); // 可建立 Views/Home/Welcome.cshtml 顯示登入成功畫面
        }
    }
}