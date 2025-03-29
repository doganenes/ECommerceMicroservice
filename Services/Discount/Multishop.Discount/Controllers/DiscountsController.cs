using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multishop.Discount.Dtos;
using Multishop.Discount.Services;

namespace Multishop.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDiscountCouponsAsync()
        {
            var values = await _discountService.GetAllDiscountCouponsAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdDiscountCouponAsync(int id)
        {
            var value = await _discountService.GetByIdDiscountCouponAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscountCouponAsync([FromBody] CreateDiscountCouponDto createCouponDto)
        {
            await _discountService.CreateDiscountCouponAsync(createCouponDto);
            return Ok("Coupon created successfully!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCouponAsync([FromBody] UpdateDiscountCouponDto updateCouponDto)
        {
            await _discountService.UpdateDiscountCouponAsync(updateCouponDto);
            return Ok("Coupon updated successfully!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscountCouponAsync(int id)
        {
            await _discountService.DeleteDiscountCouponAsync(id);
            return Ok("Coupon deleted successfully!");
        }
    }
}
