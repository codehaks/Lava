using MediatR;
using Portal.Application.Common;
using Portal.Common.Values;
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.OrderApplication.Commands
{
    public class CreateOrderCommand: IRequest<OperationResult<CreateOrderCommandResult>>
    {
        public string UserId { get; set; }

        public int FoodId { get; set; }
        public byte Count { get; set; }
        public string CoupanCode { get; set; }

        public Money UnitPrice { get; set; }
    }
}
