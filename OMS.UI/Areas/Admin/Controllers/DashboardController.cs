using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Settings Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Pages";
            ViewData["bChild"] = "Dashboard";

            

            return View();
        }
    }
}
