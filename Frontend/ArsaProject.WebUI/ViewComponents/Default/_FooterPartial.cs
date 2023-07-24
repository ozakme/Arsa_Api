using Microsoft.AspNetCore.Mvc;
namespace ArsaProject.WebUI.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
