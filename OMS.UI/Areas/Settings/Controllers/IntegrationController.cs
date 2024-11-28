using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Settings.Controllers
{
    [Area("Settings")]
    public class IntegrationController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Integration Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Integration";
            ViewData["bChild"] = "Dashboard";

            return View();
        }

        public IActionResult Calendar()
        {
            // Google Calendar

            // Page Title
            ViewData["pTitle"] = "Integration Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Integration";
            ViewData["bChild"] = "Google Calendar";

            return View();
        }
    }
}
