using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.OrderApplication.Notifications
{
    class SendEmailOrderCreatedNotificationHandler : INotificationHandler<OrderCreatedNotification>
    {
        public Task Handle(OrderCreatedNotification notification, CancellationToken cancellationToken)
        {
            // Send email to user 
            return Task.CompletedTask;
        }
    }
}
