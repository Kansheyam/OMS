using Microsoft.AspNetCore.Mvc;

namespace OMS.UI.Areas.Settings.Controllers
{
    [Area("Settings")]
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            // Page Title
            ViewData["pTitle"] = "Profile Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Profile";
            ViewData["bChild"] = "Dashboard";

            return View();
        }

        public IActionResult ChangePassword()
        {
            // Page Title
            ViewData["pTitle"] = "Profile Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Profile";
            ViewData["bChild"] = "Change Password";

            return View();
        }

        public IActionResult EmergencyContact()
        {
            // Page Title
            ViewData["pTitle"] = "Profile Controll";

            // Breadcrumb
            ViewData["bGParent"] = "Settings";
            ViewData["bParent"] = "Profile";
            ViewData["bChild"] = "Emergency Contact";

            return View();
        }
    }
}
