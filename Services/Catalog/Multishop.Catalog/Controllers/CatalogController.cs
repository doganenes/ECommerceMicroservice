using Microsoft.AspNetCore.Mvc;

namespace Multishop.Catalog.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
