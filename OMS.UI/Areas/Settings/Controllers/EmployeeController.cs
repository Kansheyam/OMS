using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Settings.Controllers
{
    [Area("Settings")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Employee Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Employee";
            ViewData["bChild"] = "Dashboard";

            return View();
        }

        public IActionResult EmployeeCreation()
        {
            // Page Title
            ViewData["pTitle"] = "Employee Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Employee";
            ViewData["bChild"] = "EmployeeCreation";

            return View();
        }

        public IActionResult Attendance()
        {
            // Page Title
            ViewData["pTitle"] = "Employee Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Employee";
            ViewData["bChild"] = "Attendance";

            return View();
        }

        public IActionResult LeavesType()
        {
            // Page Title
            ViewData["pTitle"] = "Employee Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Employee";
            ViewData["bChild"] = "Leaves Type";

            return View();
        }

        public IActionResult TimeLog()
        {
            // Page Title
            ViewData["pTitle"] = "Employee Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Employee";
            ViewData["bChild"] = "Time Log";

            return View();
        }

        public IActionResult Recruit()
        {
            // Page Title
            ViewData["pTitle"] = "Employee Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Employee";
            ViewData["bChild"] = "Recruit";

            return View();
        }
    }
}
