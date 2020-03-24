using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloMvcCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMvcCore.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Show()
        {
            ViewBag.Title = "Showing Hello World";
            ViewBag.Message = "Hello World";
            ViewBag.DummyProperty = 666;
            ViewBag.Names = new string[] { "Hansi", "Susi", "Quaxi" };            
            return View();
        }        

        public IActionResult ShowObject()
        {
            var obj = new ClassA
            {
                IntVal = 1234,
                StringVal = "xxyyzz"
            };
            return View(obj);
        }
    }
}
