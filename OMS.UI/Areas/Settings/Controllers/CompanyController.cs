using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Settings.Controllers
{
    [Area("Settings")]
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Dashboard";

            return View();
        }

        public IActionResult Company()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Company Setup";

            return View();
        }

        public IActionResult Consumer()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Consumer Settings";
            ViewData["bChild"] = "Consumer Creation";

            return View();
        }

        public IActionResult BusinessAddress()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Business Address";

            return View();
        }

        public IActionResult Department()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Department Settings";
            ViewData["bChild"] = "Department Creation";

            return View();
        }
        public IActionResult Designation()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Designation Settings";
            ViewData["bChild"] = "Designation Creation";

            return View();
        }


        public IActionResult Notifications()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Notifications";

            return View();
        }

        public IActionResult Currency()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Currency";

            return View();
        }

        public IActionResult Contract()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Contract";

            return View();
        }

        public IActionResult Roles()
        {
            // Roles & Permissions both here only.

            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Roles";

            return View();
        }

        public IActionResult Message()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Message";

            return View();
        }

        public IActionResult Security()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Security";

            return View();
        }

        public IActionResult Permissions()
        {
            // Module Settings.

            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Permissions";

            return View();
        }

        public IActionResult Assets()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Assets";

            return View();
        }

        public IActionResult SMS()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "SMS";

            return View();
        }

        public IActionResult Planning()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Planning";

            return View();
        }
        
        public IActionResult Client()
        {
            // Page Title
            ViewData["pTitle"] = "Company Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Company";
            ViewData["bChild"] = "Client";

            return View();
        }
    }
}
