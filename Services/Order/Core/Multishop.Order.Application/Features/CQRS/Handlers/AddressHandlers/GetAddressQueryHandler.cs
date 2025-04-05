using Multishop.Order.Application.Features.CQRS.Results.AddressResults;
using Multishop.Order.Application.Interfaces;
using Multishop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _addressRepository;

        public GetAddressQueryHandler(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<List<GetAddressQueryResult>> Handle()
        {
            var values = await _addressRepository.GetAllAsync();
            return values.Select(x => new GetAddressQueryResult
            {
                AddressID = x.AddressID,
                City = x.City,
                District = x.District,
                Detail = x.Detail,
                UserID = x.UserID
            }).ToList();
        }
    }
}
