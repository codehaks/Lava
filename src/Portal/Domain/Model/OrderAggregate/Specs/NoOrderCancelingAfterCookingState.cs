using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities.OrderAggregate.Specs
{
    class NoOrderCancelingAfterCookingState : ISpecification<Order>
    {
        public bool IsSatisfiedBy(Order Entity)
        {
            return Entity.State != Core.Enums.OrderState.New;
        }
    }
}
