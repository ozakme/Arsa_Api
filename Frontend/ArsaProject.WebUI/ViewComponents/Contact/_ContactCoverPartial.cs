using Microsoft.AspNetCore.Mvc;

namespace ArsaProject.WebUI.ViewComponents.Contact
{
    public class _ContactCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
