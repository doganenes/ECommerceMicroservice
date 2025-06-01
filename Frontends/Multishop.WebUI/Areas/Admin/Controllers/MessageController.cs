using Microsoft.AspNetCore.Mvc;

namespace Multishop.WebUI.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
