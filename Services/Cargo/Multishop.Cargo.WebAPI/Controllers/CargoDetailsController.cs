using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multishop.Cargo.BusinessLayer.Abstract;
using Multishop.Cargo.DtoLayer.Dtos.CargoDetailDtos;
using Multishop.Cargo.EntityLayer.Concrete;

namespace Multishop.Cargo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailsController(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }

        [HttpGet("cargoDetailList")]
        public IActionResult CargoDetailList()
        {
            var result = _cargoDetailService.TGetAll();
            return Ok(result);
        }
        [HttpPost("createCargoDetail")]
        public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
        {
            CargoDetail cargoDetail = new CargoDetail()
            {
                SenderCustomer = createCargoDetailDto.SenderCustomer,
                ReceiverCustomer = createCargoDetailDto.ReceiverCustomer,
                Barcode = createCargoDetailDto.Barcode,
                CargoCompanyId = createCargoDetailDto.CargoCompanyId
            };
            _cargoDetailService.TInsert(cargoDetail);
            return Ok("Cargo detail created successfully");
        }

        [HttpPut("updateCargoDetail")]
        public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
        {
            CargoDetail cargoDetail = new CargoDetail()
            {
                CargoDetailId = updateCargoDetailDto.CargoDetailId,
                SenderCustomer = updateCargoDetailDto.SenderCustomer,
                ReceiverCustomer = updateCargoDetailDto.ReceiverCustomer,
                Barcode = updateCargoDetailDto.Barcode,
                CargoCompanyId = updateCargoDetailDto.CargoCompanyId
            };
            _cargoDetailService.TUpdate(cargoDetail);
            return Ok("Cargo detail updated successfully");
        }

        [HttpGet("getCargoDetailById")]
        public IActionResult GetCargoDetailById(int id)
        {
            var values = _cargoDetailService.TGetById(id);
            return Ok(values);
        }

        [HttpDelete("removeCargoDetail")]
        public IActionResult RemoveCargoDetail(int id)
        {
            _cargoDetailService.TDelete(id);
            return NotFound("Cargo detail not found");
        }
    }
}
