using Microsoft.AspNetCore.Mvc;

namespace Multishop.WebUI.Areas.User.Controllers
{
    [Area("User")]
    public class MyOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
