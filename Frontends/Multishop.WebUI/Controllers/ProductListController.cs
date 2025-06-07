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
        public async Task<IActionResult> AddComment(CreateCommentDto dto)
        {
            dto.ImageUrl = "test";
            dto.Rating = 1;
            dto.Status = false;
            dto.ProductId = "67e7dce07d1d2a1a4f32dd24";
            dto.CreatedDate =DateTime.Parse (DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:7182/api/Comments", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Comment");
            }
            else
            {
                return View();
            }   
        }
    }
}
