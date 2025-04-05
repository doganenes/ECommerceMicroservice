using Multishop.Order.Application.Features.CQRS.Commands.AddressCommands;
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
    public class UpdateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _orderDetailRepository;
        public UpdateOrderDetailCommandHandler(IRepository<OrderDetail> orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }
        public async Task Handle(UpdateOrderDetailCommand command)
        {
            var values = await _orderDetailRepository.GetByIdAsync(command.OrderDetailID);
            values.OrderDetailID = command.OrderDetailID;
            values.ProductID = command.ProductID;
            values.ProductName = command.ProductName;
            values.ProductPrice = command.ProductPrice;
            values.ProductAmount = command.ProductAmount;
            values.ProductTotalPrice = command.ProductTotalPrice;
            values.OrderingID = command.OrderingID;

            await _orderDetailRepository.UpdateAsync(values);
        }

    }
}
