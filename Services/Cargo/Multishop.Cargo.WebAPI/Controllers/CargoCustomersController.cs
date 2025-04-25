using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multishop.Cargo.BusinessLayer.Abstract;
using Multishop.Cargo.DtoLayer.Dtos.CargoCustomerDtos;
using Multishop.Cargo.EntityLayer.Concrete;

namespace Multishop.Cargo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCustomersController : ControllerBase
    {
        private readonly ICargoCustomerService _cargoCustomerService;

        public CargoCustomersController(ICargoCustomerService cargoCustomerService)
        {
            _cargoCustomerService = cargoCustomerService;
        }

        [HttpGet("cargoCustomerList")]
        public IActionResult CargoCustomerList()
        {
            var result = _cargoCustomerService.TGetAll();
            return Ok(result);
        }
        [HttpPost("createCargoCustomer")]
        public IActionResult CreateCargoCustomer(CreateCargoCustomerDto createCargoCustomerDto)
        {
            CargoCustomer cargoCustomer = new CargoCustomer()
            {
                Name = createCargoCustomerDto.Name,
                Surname = createCargoCustomerDto.Surname,
                Email = createCargoCustomerDto.Email,
                Phone = createCargoCustomerDto.Phone,
                District = createCargoCustomerDto.District,
                City = createCargoCustomerDto.City,
                Address = createCargoCustomerDto.Address
            };
            _cargoCustomerService.TInsert(cargoCustomer);
            return Ok("Cargo customer created successfully");
        }

        [HttpPut("updateCargoCustomer")]
        public IActionResult UpdateCargoCustomer(UpdateCargoCustomerDto updateCargoCustomerDto)
        {
            CargoCustomer cargoCustomer = new CargoCustomer()
            {
                CargoCustomerId = updateCargoCustomerDto.CargoCustomerId,
                Name = updateCargoCustomerDto.Name,
                Surname = updateCargoCustomerDto.Surname,
                Email = updateCargoCustomerDto.Email,
                Phone = updateCargoCustomerDto.Phone,
                District = updateCargoCustomerDto.District,
                City = updateCargoCustomerDto.City,
                Address = updateCargoCustomerDto.Address
            };
            _cargoCustomerService.TUpdate(cargoCustomer);
            return Ok("Cargo customer updated successfully");
        }

        [HttpGet("getCargoCustomerById")]
        public IActionResult GetCargoCustomerById(int id)
        {
            var values = _cargoCustomerService.TGetById(id);
            return Ok(values);
        }

        [HttpDelete("removeCargoCustomer")]
        public IActionResult RemoveCargoCustomer(int id)
        {
            _cargoCustomerService.TDelete(id);
            return Ok("Cargo customer deleted successfully");
        }
    }
}
