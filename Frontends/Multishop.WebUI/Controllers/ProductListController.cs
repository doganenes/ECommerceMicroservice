using Microsoft.AspNetCore.Mvc;
using Multishop.DtoLayer.CommentDtos;
using Newtonsoft.Json;

namespace Multishop.WebUI.Controllers
{
    public class ProductListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductDetail()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
                return PartialView();
        }

                
        
        [HttpPost]
        public IActionResult AddComment(CreateCommentDto dto)
        {
            return View();
        }
    }
}
