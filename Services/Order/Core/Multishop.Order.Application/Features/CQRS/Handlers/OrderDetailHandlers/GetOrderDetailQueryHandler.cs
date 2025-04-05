using Multishop.Order.Application.Features.CQRS.Results.AddressResults;
using Multishop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using Multishop.Order.Application.Interfaces;
using Multishop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailQueryHandler
    {
        private readonly IRepository<OrderDetail> _orderDetailRepository;

        public GetOrderDetailQueryHandler(IRepository<OrderDetail> orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<List<GetOrderDetailQueryResult>> Handle()
        {
            var values = await _orderDetailRepository.GetAllAsync();
            return values.Select(x => new GetOrderDetailQueryResult
            {
                OrderDetailID = x.OrderDetailID,
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductAmount = x.ProductAmount,
                ProductTotalPrice = x.ProductTotalPrice,
                OrderingID = x.OrderingID
            }).ToList();
        }
    }
}
