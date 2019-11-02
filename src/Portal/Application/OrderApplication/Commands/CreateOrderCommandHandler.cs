using AutoMapper;
using MediatR;
using Portal.Application.Common;
using Portal.Application.OrderApplication.Notifications;
using Portal.Domain.Entities;
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
        private readonly PortalDbContext _db;
        private readonly IMediator _mediator;

        public CreateOrderCommandHandler(PortalDbContext db, IMediator mediator)
        {
            _db = db;
            _mediator = mediator;
        }

        public async Task<OperationResult<CreateOrderCommandResult>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order(request.UserId, request.FoodId, request.Count, request.UnitPrice);
            _db.Orders.Add(order);

            await _mediator.Publish(new OrderCreatedNotification());

            var result = OperationResult<CreateOrderCommandResult>
               .BuildSuccessResult(new CreateOrderCommandResult
               {
                   OrderId = order.Id
               });
            await Task.CompletedTask;
            return result;

        }
    }
}
