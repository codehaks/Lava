using AutoMapper;
using MediatR;
using Portal.Application.Common;
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
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(PortalDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<OperationResult<CreateOrderCommandResult>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order(request.UserId, request.FoodId, request.Count, request.UnitPrice);
            //_db.Orders.Add(order);

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
