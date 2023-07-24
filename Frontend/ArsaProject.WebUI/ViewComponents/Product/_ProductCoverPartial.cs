using Microsoft.AspNetCore.Mvc;

namespace ArsaProject.WebUI.ViewComponents.Product
{
    public class _ProductCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
