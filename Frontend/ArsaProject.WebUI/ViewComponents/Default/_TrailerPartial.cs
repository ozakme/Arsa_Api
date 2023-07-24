using Microsoft.AspNetCore.Mvc;

namespace ArsaProject.WebUI.ViewComponents.Default
{
    public class _TrailerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
