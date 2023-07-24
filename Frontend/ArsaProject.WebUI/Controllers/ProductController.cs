using Microsoft.AspNetCore.Mvc;

namespace ArsaProject.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
