using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multishop.Cargo.BusinessLayer.Abstract;
using Multishop.Cargo.EntityLayer.Concrete;
using Multishop.Cargo.DtoLayer.Dtos.CargoCompanyDtos;
using Microsoft.AspNetCore.Authorization;

namespace Multishop.Cargo.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCompaniesController : ControllerBase
    {
        private readonly ICargoCompanyService _cargoCompanyService;

        public CargoCompaniesController(ICargoCompanyService cargoCompanyService)
        {
            _cargoCompanyService = cargoCompanyService;
        }

        [HttpGet("cargoCompanyList")]
        public IActionResult CargoCompanyList()
        {
            var result = _cargoCompanyService.TGetAll();
            return Ok(result);
        }

        [HttpPost("createCargoCompany")]
        public IActionResult CreateCargoCompany(CreateCargoCompanyDto createCargoCompanyDto)
        {
            CargoCompany cargoCompany = new CargoCompany()
            {
                CargoCompanyName = createCargoCompanyDto.CargoCompanyName

            };

            _cargoCompanyService.TInsert(cargoCompany);
            return Ok("Cargo company created successfully");
        }
        [HttpPut("updateCargoCompany")]
        public IActionResult UpdateCargoCompany(UpdateCargoCompanyDto updateCargoCompanyDto)
        {
            CargoCompany cargoCompany = new CargoCompany()
            {
                CargoCompanyId = updateCargoCompanyDto.CargoCompanyId,
                CargoCompanyName = updateCargoCompanyDto.CargoCompanyName
            };
            _cargoCompanyService.TUpdate(cargoCompany);
            return Ok("Cargo company updated successfully");
        }

        [HttpGet("getCargoCompanyById")]
        public IActionResult GetCargoCompanyById(int id)
        {
            var values = _cargoCompanyService.TGetById(id);
            return Ok(values);
        }

        [HttpDelete("removeCargoCompany")]
        public IActionResult RemoveCargoCompany(int id)
        {
            _cargoCompanyService.TDelete(id);
            return Ok("Cargo company deleted successfully");
        }
    }
}
