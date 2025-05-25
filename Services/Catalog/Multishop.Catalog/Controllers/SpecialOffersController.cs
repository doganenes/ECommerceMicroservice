using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multishop.Catalog.Dtos.SpecialOfferDtos;
using Multishop.Catalog.Services.SpecialOfferServices;

namespace Multishop.Catalog.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialOffersController : ControllerBase
    {
        private readonly ISpecialOfferService _SpecialOfferService;

        public SpecialOffersController(ISpecialOfferService SpecialOfferService)
        {
            _SpecialOfferService = SpecialOfferService;
        }

        [HttpGet]
        public async Task<IActionResult> SpecialOfferList()
        {
            var values = await _SpecialOfferService.GetAllSpecialOfferAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpecialOfferById(string id)
        {
            var values = await _SpecialOfferService.GetByIdSpecialOfferAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSpecialOffer([FromBody] CreateSpecialOfferDto createSpecialOfferDto)
        {
            await _SpecialOfferService.CreateSpecialOfferAsync(createSpecialOfferDto);
            return Ok("SpecialOffer added successfully!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpecialOffer(string id)
        {
            await _SpecialOfferService.DeleteSpecialOfferAsync(id);
            return Ok("SpecialOffer deleted successfully!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSpecialOffer([FromBody] UpdateSpecialOfferDto updateSpecialOfferDto)
        {
            await _SpecialOfferService.UpdateSpecialOfferAsync(updateSpecialOfferDto);
            return Ok("SpecialOffer updated successfully!");
        }
    }
}
