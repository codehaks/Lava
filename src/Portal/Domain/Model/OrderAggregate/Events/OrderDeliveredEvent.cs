using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Model.OrderAggregate.Events
{
    class OrderDeliveredEvent
    {
        public OrderDeliveredEvent(Order order)
        {
            Order = order;
        }
        public Order Order { get;private set; }
    }

    class OrderDeliveryEvents
    {
        public delegate void OrderDeliveredEventHandler(OrderDeliveredEvent e);
        public event OrderDeliveredEventHandler OrderDeliveredEvent;

    }
}
