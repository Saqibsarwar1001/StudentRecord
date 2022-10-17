using Microsoft.AspNetCore.Mvc;
using StudentRecord.Models;
using System.Diagnostics;

namespace StudentRecord.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }

    }
}