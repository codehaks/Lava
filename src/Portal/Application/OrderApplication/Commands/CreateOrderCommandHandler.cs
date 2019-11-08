using AutoMapper;
using MediatR;
using Portal.Application.Common;
using Portal.Application.OrderApplication.Notifications;
using Portal.Domain.Entities;
using Portal.Domain.Model.OrderAggregate;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.OrderApplication.Commands
{
    public class CreateOrderCommandHandler :
        IRequestHandler<CreateOrderCommand, OperationResult<CreateOrderCommandResult>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMediator _mediator;

        public CreateOrderCommandHandler(IOrderRepository orderRepository, IMediator mediator)
        {
            _orderRepository = orderRepository;
            _mediator = mediator;
        }

        public async Task<OperationResult<CreateOrderCommandResult>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order(request.UserId, request.FoodId, request.Count, request.UnitPrice);
            var orderId = await _orderRepository.Create(order);

            await _mediator.Publish(new OrderCreatedNotification());

            var result = OperationResult<CreateOrderCommandResult>
               .BuildSuccessResult(new CreateOrderCommandResult
               {
                   OrderId = orderId
               });
            await Task.CompletedTask;
            return result;

        }
    }
}
