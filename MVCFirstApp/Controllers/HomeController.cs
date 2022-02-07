using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // การใช้คีย์ลัดในการ comment
        // Ctrl+k, Ctrl+c
        // เอา comment ออก
        // Ctrl+k, Ctrl+u
        public ActionResult Index()
        {
            var userDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            // การส่ง (pass) ตัวแปรไปแสดงผลที่ View 
            // สามารถทำได้ 3 คำสั่ง
            // ViewData["name"]
            ViewData["mytime"] = userDate;
            // ViewBag.name
            ViewBag.Description = "This is my web page";
            // TempData["name"]
            TempData["title"] = "Welcome to my site";

            return View();
        }

        // http://localhost:61660/Home/Index
        // http://localhost:61660/
        //public string Index()
        //{
        //    return "สวัสดี, ASP.net MVC สำหรับผู้เริ่มต้น";
        //}

        // http://localhost:61660/Home/About
        //public string About()
        //{
        //    return "Hello, from About method";
        //}

        // http://localhost:61660/Home/Profile/5
        // http://localhost:61660/Home/Profile/5?Name=Samit&Department=Business
        //public string Profile(string Name, string Department)
        //{
        //    try
        //    {
        //        var id = Request.Url.Segments[3]; // คืนค่ามาเป็น string
        //        return "Hello, from Profile id=" + (Int32.Parse(id)+10)+" Name="+ Name+ " Department="+Department;
        //    }
        //    catch(IndexOutOfRangeException e)
        //    {
        //        return e.Message;
        //    }

        //}

    }
}