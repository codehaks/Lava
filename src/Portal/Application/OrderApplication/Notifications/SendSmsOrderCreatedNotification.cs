using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.OrderApplication.Notifications
{
    class SendSmsOrderCreatedNotification : INotificationHandler<OrderCreatedNotification>
    {
        public Task Handle(OrderCreatedNotification notification, CancellationToken cancellationToken)
        {
            // Send sms
            return Task.CompletedTask;
        }
    }
}
