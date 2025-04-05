using Multishop.Order.Application.Features.CQRS.Commands.AddressCommands;
using Multishop.Order.Application.Interfaces;
using Multishop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _addressRepository;
        public UpdateAddressCommandHandler(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public async Task Handle(UpdateAddressCommand command)
        {
            var values = await _addressRepository.GetByIdAsync(command.AddressID);
            values.City = command.City;
            values.District = command.District;
            values.Detail = command.Detail;
            values.UserID = command.UserID;
            await _addressRepository.UpdateAsync(values);
        }
    }
}
