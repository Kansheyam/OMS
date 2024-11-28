using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Settings.Controllers
{
    [Area("Settings")]
    public class FinanceController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Dashboard";

            return View();
        }

        public IActionResult Payment()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Payment";

            return View();
        }

        public IActionResult Finance()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Finance Setup";

            return View();
        }

        public IActionResult Tax()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Tax Setup";

            return View();
        }

        public IActionResult Payroll()
        {
            // Page Title
            ViewData["pTitle"] = "Finance Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Finance";
            ViewData["bChild"] = "Payroll Setup";

            return View();
        }
    }
}
