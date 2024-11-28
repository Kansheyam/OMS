using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace OMS.UI.Areas.Settings.Controllers
{
    [Area("Settings")]
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Settings Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Main";
            ViewData["bChild"] = "Dashboard";

            return View();
        }

        public IActionResult Application()
        {
            // Page Title
            ViewData["pTitle"] = "Application Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Main";
            ViewData["bChild"] = "Application";

            return View();
        }

        public IActionResult Purchase()
        {
            // Page Title
            ViewData["pTitle"] = "Purchase Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Main";
            ViewData["bChild"] = "Purchase";

            return View();
        }
    }
}
