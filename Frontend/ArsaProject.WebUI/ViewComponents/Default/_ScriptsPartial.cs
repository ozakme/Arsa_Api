using Microsoft.AspNetCore.Mvc;
namespace ArsaProject.WebUI.ViewComponents.Default
{
    public class _ScriptsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
