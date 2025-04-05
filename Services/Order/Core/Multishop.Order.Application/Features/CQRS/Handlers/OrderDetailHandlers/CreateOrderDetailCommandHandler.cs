using Multishop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using Multishop.Order.Application.Interfaces;
using Multishop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _orderDetailRepository;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task Handle(CreateOrderDetailCommand command)
        {
            await _orderDetailRepository.CreateAsync(new OrderDetail
            {
                ProductID = command.ProductID,
                ProductName = command.ProductName,
                ProductPrice = command.ProductPrice,
                ProductAmount = command.ProductAmount,
                ProductTotalPrice = command.ProductTotalPrice,
                OrderingID = command.OrderingID
            });
        }
    }
}
