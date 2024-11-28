using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Settings.Controllers
{
    public class CreateController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Create Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Dashboard";

            return View();
        } public IActionResult Consumer()
        {
            // Page Title
            ViewData["pTitle"] = "Create Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Consumer Settings";
            ViewData["bChild"] = "Consumer Creation";

            return View();
        } public IActionResult Planning()
        {
            // Page Title
            ViewData["pTitle"] = "Create Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Planning Settings";
            ViewData["bChild"] = "Planning Creation";

            return View();
        }
    }
}
